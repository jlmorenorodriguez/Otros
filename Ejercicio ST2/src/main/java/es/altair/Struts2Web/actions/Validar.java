package es.altair.Struts2Web.actions;

import java.util.Map;

import org.apache.commons.lang3.StringUtils;
import org.apache.struts2.dispatcher.SessionMap;
import org.apache.struts2.interceptor.SessionAware;

import com.opensymphony.xwork2.ActionSupport;

import es.altair.Struts2Web.bean.Usuario;
import es.altair.Struts2Web.dao.UsuarioDAO;
import es.altair.Struts2Web.dao.UsuarioImpl;

public class Validar extends ActionSupport implements SessionAware {
	
	private SessionMap<String, Object> session;

	private String user;
	
	private String pwd;

	public String getUser() {
		return user;
	}

	public void setUser(String user) {
		this.user = user;
	}

	public String getPwd() {
		return pwd;
	}

	public void setPwd(String pwd) {
		this.pwd = pwd;
	}
	
	public String comprobar() {
		System.out.println(user + "-" + pwd);
		if (StringUtils.isEmpty(user) || StringUtils.isEmpty(pwd)) {
			addActionError("Error Usuario / Password");
			return ActionSupport.INPUT;
		}
		UsuarioDAO usudao = new UsuarioImpl();
		Usuario usu = usudao.validarUsuario(user, pwd);
		if (usu != null) {
			session.put("usulogeado", usu);
			return ActionSupport.SUCCESS;
		} else {
			addActionError("Usuario / Password No Encontrado");
			return ActionSupport.INPUT;
		}
		
	}
	
	public String cerrarSesion() {
		if (session != null) {
			session.clear();
			session.invalidate();
		}
		return ActionSupport.SUCCESS;
	}

	public void setSession(Map<String, Object> session) {
		this.session = (SessionMap<String, Object>) session;
	}
	
//	@Override
//	public void validate() {
//		if (StringUtils.isEmpty(user))
//			addFieldError("user", "Error. Usuario Vacío");
//		if (StringUtils.isEmpty(pwd))
//			addFieldError("pwd", "Error. Password Vacío");
//	}
}
