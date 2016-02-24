package es.altair.action;



import com.opensymphony.xwork2.ActionSupport;
import es.altair.bean.Usuario;
import es.altair.dao.UsuarioDAO;

public class UsuarioAction extends ActionSupport{
	
	private static final long serialVersionUID = 1L;
	String respuesta;
	Usuario usuario;
	UsuarioDAO usuarioDAO;
	
	public UsuarioAction(){		
		usuarioDAO = new UsuarioDAO();		
	}

	
	public Usuario getUsuario() {
		return usuario;
	}

	public void setUsuario(Usuario usuario) {
		this.usuario = usuario;
	}


	public String login(){
		
		Usuario usu = new Usuario();
						
		usu = usuarioDAO.loginDAO(usuario);
						
		if(usu == null){
			
			return ActionSupport.ERROR;
			
		}else{
			
			
			if(usu.getTipo() == 0){
				
				return ActionSupport.SUCCESS;
				
				
			}else{
				
				return "cliente";
				
			}
						
		}	
		
	}


	
}
