package es.altair.ExamenTerceraStruts.dao;

import org.hibernate.Session;

import es.altair.ExamenTerceraStruts.bean.Cliente;
import es.altair.ExamenTerceraStruts.modelo.HibernateUtil;

public class ClienteIMPL implements ClienteDAO {

	public Cliente validarCliente(String codigo) {
		// TODO Auto-generated method stub
		Cliente c = null;
		HibernateUtil.buildSessionFactory();
		Session sesion = null;
		try {
			HibernateUtil.openSessionAndBindToThread();
			sesion = HibernateUtil.getSessionFactory().getCurrentSession();
			sesion.beginTransaction();

			// Operaciones
			
			c = (Cliente)sesion.createQuery("Select c from Cliente c where codigo=:cod").setParameter("cod", codigo).uniqueResult(); 
			
			sesion.getTransaction().commit();
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			HibernateUtil.closeSessionAndUnbindFromThread();
		}
		HibernateUtil.closeSessionFactory();
		
		return c;
	}

	

}
