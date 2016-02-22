package es.altair.dao;

import org.hibernate.Query;
import org.hibernate.Session;

import es.altair.bean.Usuario;
import es.altair.datos.HibernateUtil;

public class UsuarioDAO {

	private static final String PASSPHRASE = "Instrumentos123$%";

	public static Usuario comprobarUsuario(String login, String password) {
		Usuario usu = null;

		HibernateUtil.buildSessionFactory();
		Session sesion = null;
		try {
			HibernateUtil.openSessionAndBindToThread();

			sesion = HibernateUtil.getSessionFactory().getCurrentSession();

			sesion.beginTransaction();

			usu = (Usuario) sesion
					.createQuery("SELECT u FROM Usuario u WHERE login=:l AND password=AES_ENCRYPT(:p, :passphrase)")
					.setParameter("l", login).setParameter("p", password).setParameter("passphrase", PASSPHRASE)
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

	public static void anadirUsuario(Usuario u) {
		// TODO Auto-generated method stub
		HibernateUtil.buildSessionFactory();
		Session sesion = null;
		try {
			HibernateUtil.openSessionAndBindToThread();
			sesion = HibernateUtil.getSessionFactory().getCurrentSession();
			sesion.beginTransaction();

			sesion.save(u);
			
	
			Query query = sesion
					.createQuery("update Usuario set password=AES_ENCRYPT(:p, :passphrase) WHERE login=:log ")
					.setParameter("p", u.getPassword()).setParameter("passphrase", PASSPHRASE).setParameter("log", u.getLogin());
			int result = query.executeUpdate();
			System.out.println(u.getPassword() + "   "+  PASSPHRASE + " "+ u.getIdUsuario());
			System.out.println("Filas actualizadas: " + result);
			
			// UPDATE usuarios SET PASSWORD = aes_encrypt("usu", "Libros123$%") WHERE idUsuario = 2;

			sesion.getTransaction().commit();
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			HibernateUtil.closeSessionAndUnbindFromThread();
		}
		HibernateUtil.closeSessionFactory();
	}

	public static Usuario comprobarUsuario(String login) {
		// TODO Auto-generated method stub
		Usuario usu = null;

		HibernateUtil.buildSessionFactory();
		Session sesion = null;
		try {
			HibernateUtil.openSessionAndBindToThread();

			sesion = HibernateUtil.getSessionFactory().getCurrentSession();

			sesion.beginTransaction();

			usu = (Usuario) sesion
					.createQuery("SELECT u FROM Usuario u WHERE login=:l ")
					.setParameter("l", login).uniqueResult();

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
