package es.altair.Struts2Web.actions;

import java.io.ByteArrayInputStream;
import java.io.InputStream;
import java.util.ArrayList;
import java.util.Map;

import javax.servlet.http.HttpServletResponse;

import org.apache.struts2.ServletActionContext;
import org.apache.struts2.dispatcher.SessionMap;
import org.apache.struts2.interceptor.SessionAware;

import com.opensymphony.xwork2.ActionSupport;

import es.altair.Struts2Web.bean.Pedido;
import es.altair.Struts2Web.bean.Usuario;
import es.altair.Struts2Web.dao.PedidoDAO;
import es.altair.Struts2Web.dao.PedidoImpl;

public class GestionPedidos extends ActionSupport implements SessionAware{

	private SessionMap<String, Object> session;
	
	private ArrayList<Pedido> pedidos = new ArrayList<Pedido>();
	
	private Integer idPedido;
	
	private InputStream inputStream;
	
	private PedidoDAO pedao = new PedidoImpl();
	
	public String listar() {
		pedidos = pedao.listarPedidos(((Usuario)session.get("usulogeado")));
		
		return ActionSupport.SUCCESS;
	}
	
	public String mostrarPDF(){
		
		Pedido p = pedao.obtenerPedidoPorId(idPedido);
		
		byte[] b = p.getFichero();
		
		HttpServletResponse response = ServletActionContext.getResponse();
		if(b!= null){
			inputStream = new ByteArrayInputStream(b);
		}
		
		return ActionSupport.SUCCESS;
	}
	
	public void setSession(Map<String, Object> session) {
		this.session = (SessionMap<String, Object>) session;
	}
	
	public ArrayList<Pedido> getPedidos() {
		return pedidos;
	}
	
	public void setPedidos(ArrayList<Pedido> pedidos) {
		this.pedidos = pedidos;
	}

	public SessionMap<String, Object> getSession() {
		return session;
	}

	public void setSession(SessionMap<String, Object> session) {
		this.session = session;
	}

	public Integer getIdPedido() {
		return idPedido;
	}

	public void setIdPedido(Integer idPedido) {
		this.idPedido = idPedido;
	}

	public PedidoDAO getPedao() {
		return pedao;
	}

	public void setPedao(PedidoDAO pedao) {
		this.pedao = pedao;
	}

	public InputStream getInputStream() {
		return inputStream;
	}

	public void setInputStream(InputStream inputStream) {
		this.inputStream = inputStream;
	}
	
	
	
}