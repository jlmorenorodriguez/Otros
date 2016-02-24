package es.altair.ExamenTerceraStruts.dao;

import org.hibernate.Session;

import es.altair.ExamenTerceraStruts.modelo.HibernateUtil;

public class ObjetoIMPL implements ObjetoDAO {

	public void metodo() {
		HibernateUtil.buildSessionFactory();
		Session sesion = null;
		try {
			HibernateUtil.openSessionAndBindToThread();
			sesion = HibernateUtil.getSessionFactory().getCurrentSession();
			sesion.beginTransaction();

			// Operaciones

			sesion.getTransaction().commit();
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			HibernateUtil.closeSessionAndUnbindFromThread();
		}
		HibernateUtil.closeSessionFactory();
	}

}
