package es.altair.Struts2Web.dao;

import java.util.ArrayList;

import org.hibernate.Session;

import es.altair.Struts2Web.bean.Pedido;
import es.altair.Struts2Web.bean.Producto;
import es.altair.Struts2Web.bean.Usuario;
import es.altair.Struts2Web.modelo.HibernateUtil;

public class PedidoImpl implements PedidoDAO{

	public void anadirPedido(Pedido p) {
		HibernateUtil.buildSessionFactory();
		Session sesion = null;
		try {
			HibernateUtil.openSessionAndBindToThread();

			sesion = HibernateUtil.getSessionFactory().getCurrentSession();

			sesion.beginTransaction();

			sesion.save(p);

			sesion.getTransaction().commit();

		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			HibernateUtil.closeSessionAndUnbindFromThread();
		}

		HibernateUtil.closeSessionFactory();
	}

	public ArrayList<Pedido> listarPedidos(Usuario usuario) {
		ArrayList<Pedido> pedidos = new ArrayList<Pedido>();

		HibernateUtil.buildSessionFactory();
		Session sesion = null;
		try {
			HibernateUtil.openSessionAndBindToThread();

			sesion = HibernateUtil.getSessionFactory().getCurrentSession();

			sesion.beginTransaction();

			pedidos = (ArrayList<Pedido>) sesion.createQuery("FROM Pedido p WHERE usuario=:u")
					.setParameter("u", usuario)
					.list();

			sesion.getTransaction().commit();

		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			HibernateUtil.closeSessionAndUnbindFromThread();
		}

		HibernateUtil.closeSessionFactory();

		return pedidos;
	}

	public Pedido obtenerPedidoPorId(Integer idPedido) {
		Pedido p = null;

		HibernateUtil.buildSessionFactory();
		Session sesion = null;
		try {
			HibernateUtil.openSessionAndBindToThread();
			sesion = HibernateUtil.getSessionFactory().getCurrentSession();
			sesion.beginTransaction();

			p = (Pedido) sesion.createQuery("FROM Pedido p WHERE p.idPedido=:id")
					.setParameter("id", idPedido)
					.uniqueResult();

			sesion.getTransaction().commit();
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			HibernateUtil.closeSessionAndUnbindFromThread();
		}
		HibernateUtil.closeSessionFactory();

		return p;
	}

}