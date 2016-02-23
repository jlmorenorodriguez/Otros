package es.altair.ExamenTerceraStruts.actions;

import java.util.Map;

import org.apache.commons.lang3.StringUtils;
import org.apache.struts2.dispatcher.SessionMap;
import org.apache.struts2.interceptor.SessionAware;

import com.opensymphony.xwork2.ActionSupport;

import es.altair.ExamenTerceraStruts.bean.Cliente;
import es.altair.ExamenTerceraStruts.dao.ClienteDAO;
import es.altair.ExamenTerceraStruts.dao.ClienteIMPL;

public class Validar extends ActionSupport implements SessionAware{

	private SessionMap<String, Object> session;
	
	private String codigo;
	
	
	public SessionMap<String, Object> getSession() {
		return session;
	}

	

	public String getCodigo() {
		return codigo;
	}

	public void setCodigo(String codigo) {
		this.codigo = codigo;
	}


	public String comprobar(){
		System.out.println(codigo);
		if(StringUtils.isEmpty(codigo)){
			addActionError("Error codigo");
			return ActionSupport.INPUT;
		}
		ClienteDAO clidao= new ClienteIMPL();
		Cliente c = clidao.validarCliente(codigo);
		System.out.println(c);
		if(c != null){
			session.put("clilogueado", c);
			return ActionSupport.SUCCESS;
		}else{
			addActionError("Usuario no encontrado");
			return ActionSupport.INPUT;
		}
		
		
	}

	public void setSession(Map<String, Object> arg0) {
		this.session = (SessionMap<String, Object>) arg0;
	}

}
