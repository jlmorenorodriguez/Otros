package es.altair.Struts2Web.dao;

import java.util.ArrayList;

import org.hibernate.Session;

import es.altair.Struts2Web.bean.Producto;
import es.altair.Struts2Web.modelo.HibernateUtil;

public class ProductoImpl implements ProductoDAO {

	public ArrayList<Producto> listarProductos() {
		ArrayList<Producto> productos = new ArrayList<Producto>();

		HibernateUtil.buildSessionFactory();
		Session sesion = null;
		try {
			HibernateUtil.openSessionAndBindToThread();

			sesion = HibernateUtil.getSessionFactory().getCurrentSession();

			sesion.beginTransaction();

			productos = (ArrayList<Producto>) sesion.createQuery("FROM Producto p").list();

			sesion.getTransaction().commit();

		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			HibernateUtil.closeSessionAndUnbindFromThread();
		}

		HibernateUtil.closeSessionFactory();

		return productos;
	}

	public void anadirProducto(Producto p) {
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

	public Producto obtenerProductoPorId(Integer idProducto) {
		Producto p = null;

		HibernateUtil.buildSessionFactory();
		Session sesion = null;
		try {
			HibernateUtil.openSessionAndBindToThread();
			sesion = HibernateUtil.getSessionFactory().getCurrentSession();
			sesion.beginTransaction();

			p = (Producto) sesion.createQuery("FROM Producto p WHERE p.idProducto=:id")
					.setParameter("id", idProducto)
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

	public void actualizarProducto(Producto producto) {
		HibernateUtil.buildSessionFactory();
		Session sesion = null;
		try {
			HibernateUtil.openSessionAndBindToThread();

			sesion = HibernateUtil.getSessionFactory().getCurrentSession();

			sesion.beginTransaction();

			sesion.update(producto);

			sesion.getTransaction().commit();

		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			HibernateUtil.closeSessionAndUnbindFromThread();
		}

		HibernateUtil.closeSessionFactory();
	}

	public void borrarProductoPorId(Integer idProducto) {
		HibernateUtil.buildSessionFactory();
		Session sesion = null;
		try {
			HibernateUtil.openSessionAndBindToThread();
			sesion = HibernateUtil.getSessionFactory().getCurrentSession();
			sesion.beginTransaction();

			sesion.createQuery("DELETE FROM Producto WHERE idProducto=:id").setParameter("id", idProducto).executeUpdate();

			sesion.getTransaction().commit();
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			HibernateUtil.closeSessionAndUnbindFromThread();
		}
		HibernateUtil.closeSessionFactory();
	}

}
