package es.altair.dao;



import org.hibernate.Session;

import es.altair.bean.Usuario;

public class UsuarioDAO{
	
	
	public Usuario loginDAO(Usuario usuario) {
		
		System.out.println("Metodo login DAO");
		
		ConexionDAO.buildSessionFactory();
		Session sesion = null;
		Usuario usu = new Usuario();
		
		try{
				
		ConexionDAO.openSessionAndBindToThread();
		
		sesion = ConexionDAO.getSessionFactory().getCurrentSession();
		
		sesion.beginTransaction();
		
		usu = (Usuario) sesion.createQuery("SELECT u FROM Usuario u WHERE username=:user AND password=AES_ENCRYPT(:contra, :passphrase)")
				.setParameter("user", usuario.getUsername()).setParameter("contra", usuario.getPassword()).setParameter("passphrase", "passphrase").uniqueResult();
				
		
		}catch(Exception e){
			
			sesion.clear();			
			e.printStackTrace();
			
		}finally{
			
			ConexionDAO.closeSessionAndUnbindFromThread();
			ConexionDAO.closeSessionFactory();
						
		}
		
		return usu;
	}

}
