package es.altair.Struts2Web.dao;

import java.util.ArrayList;

import org.hibernate.Session;

import es.altair.Struts2Web.bean.Cliente;
import es.altair.Struts2Web.bean.Producto;
import es.altair.Struts2Web.bean.Usuario;
import es.altair.Struts2Web.modelo.HibernateUtil;

public class ClienteImpl implements ClienteDAO {

	public ArrayList<Cliente> listarClientes(Usuario usu) {
		ArrayList<Cliente> clientes = new ArrayList<Cliente>();

		HibernateUtil.buildSessionFactory();
		Session sesion = null;
		try {
			HibernateUtil.openSessionAndBindToThread();

			sesion = HibernateUtil.getSessionFactory().getCurrentSession();

			sesion.beginTransaction();

			clientes = (ArrayList<Cliente>) sesion.createQuery("FROM Cliente c WHERE usuario=:u")
					.setParameter("u", usu)
					.list();

			sesion.getTransaction().commit();

		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			HibernateUtil.closeSessionAndUnbindFromThread();
		}

		HibernateUtil.closeSessionFactory();

		return clientes;
	}

	public Cliente obtenerClientePorId(Integer idCliente) {
		Cliente c= null;

		HibernateUtil.buildSessionFactory();
		Session sesion = null;
		try {
			HibernateUtil.openSessionAndBindToThread();
			sesion = HibernateUtil.getSessionFactory().getCurrentSession();
			sesion.beginTransaction();

			c = (Cliente) sesion.createQuery("FROM Cliente c WHERE p.idCliente=:id")
					.setParameter("id", idCliente)
					.uniqueResult();

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
