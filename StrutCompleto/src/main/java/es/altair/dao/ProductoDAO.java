package es.altair.dao;

import java.util.ArrayList;

import org.hibernate.HibernateException;
import org.hibernate.Session;
import es.altair.bean.Producto;

public class ProductoDAO {


	public ArrayList<Producto> listar() {
		
		ConexionDAO.buildSessionFactory();
		Session sesion = null;
		
		ArrayList<Producto> productos = new ArrayList<Producto>();
				
		try {
			
			productos = new ArrayList<Producto>();
			
			ConexionDAO.openSessionAndBindToThread();

			sesion = ConexionDAO.getSessionFactory().getCurrentSession();

			sesion.beginTransaction();

			productos = (ArrayList<Producto>) sesion.createQuery("FROM Producto p").list();

			System.out.println(productos);
			
			sesion.getTransaction().commit();

		} catch (Exception e) {
			
			e.printStackTrace();
			
		} finally {
			ConexionDAO.closeSessionAndUnbindFromThread();
		}

		ConexionDAO.closeSessionFactory();

		return productos;
	}

	public void borrar(int idProducto) {
		
		
		ConexionDAO.buildSessionFactory();
		Session sesion = null;
		
		Producto p = new Producto();
		
		try {
						
			ConexionDAO.openSessionAndBindToThread();

			sesion = ConexionDAO.getSessionFactory().getCurrentSession();

			sesion.beginTransaction();

			p = new Producto(idProducto);
			
			sesion.delete(p);
			
			sesion.getTransaction().commit();

		} catch (Exception e) {
			
			e.printStackTrace();
			
		} finally {
			ConexionDAO.closeSessionAndUnbindFromThread();
		}

		ConexionDAO.closeSessionFactory();

		
		
	}

	public void add(Producto producto) {
		
		ConexionDAO.buildSessionFactory();
		Session sesion = null;
		System.out.println(producto);
		Producto p = new Producto();
		
		try {
						
			ConexionDAO.openSessionAndBindToThread();

			sesion = ConexionDAO.getSessionFactory().getCurrentSession();

			sesion.beginTransaction();
			
			sesion.saveOrUpdate(producto);
			
			sesion.getTransaction().commit();

		} catch (Exception e) {
			
			e.printStackTrace();
			
		} finally {
			ConexionDAO.closeSessionAndUnbindFromThread();
		}

		ConexionDAO.closeSessionFactory();
	
	}

	public Producto obtenerProducto(int idProducto) {
		
		ConexionDAO.buildSessionFactory();
		Session sesion = null;
		
		Producto producto = new Producto();
		
			try{
				
				ConexionDAO.openSessionAndBindToThread();

				sesion = ConexionDAO.getSessionFactory().getCurrentSession();

				sesion.beginTransaction();
			
			producto = (Producto) sesion.get(Producto.class, idProducto);
			
			}catch(HibernateException e){			
				e.printStackTrace();
				sesion.getTransaction().rollback();
			}finally {
				ConexionDAO.closeSessionAndUnbindFromThread();
				ConexionDAO.closeSessionFactory();
			}	
		return producto;
		
	}

}
