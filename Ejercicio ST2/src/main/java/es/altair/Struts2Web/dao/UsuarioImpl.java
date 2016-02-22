package es.altair.Struts2Web.dao;

import org.hibernate.Session;

import es.altair.Struts2Web.bean.Usuario;
import es.altair.Struts2Web.modelo.HibernateUtil;

public class UsuarioImpl implements UsuarioDAO {

	public Usuario validarUsuario(String user, String pwd) {
		Usuario usu = null;

		HibernateUtil.buildSessionFactory();
		Session sesion = null;
		try {
			HibernateUtil.openSessionAndBindToThread();

			sesion = HibernateUtil.getSessionFactory().getCurrentSession();

			sesion.beginTransaction();

			usu = (Usuario) sesion
					.createQuery("SELECT u FROM Usuario u WHERE user=:l AND pwd=:p")
					.setParameter("l", user).setParameter("p", pwd)
					.uniqueResult();

			sesion.getTransaction().commit();

		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			HibernateUtil.closeSessionAndUnbindFromThread();
		}

		HibernateUtil.closeSessionFactory();

		return usu;
	}

}
