
package es.altair.dao;

import java.io.ByteArrayOutputStream;
import java.util.ArrayList;
import java.util.List;

import org.hibernate.Query;
import org.hibernate.Session;

import es.altair.bean.Instrumento;
import es.altair.bean.Usuario;
import es.altair.datos.HibernateUtil;

public class InstrumentoDAO {

	public static ArrayList<Instrumento> listarInstrumentoPorUsuario(int idUsuario) {
		ArrayList<Instrumento> instrumentos = new ArrayList<Instrumento>();

		HibernateUtil.buildSessionFactory();
		Session sesion = null;
		try {
			HibernateUtil.openSessionAndBindToThread();
			sesion = HibernateUtil.getSessionFactory().getCurrentSession();
			sesion.beginTransaction();

			instrumentos = (ArrayList<Instrumento>) sesion.createQuery("FROM Instrumento i where idUsuario=:idU")
					.setParameter("idU", idUsuario).list();

			sesion.getTransaction().commit();
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			HibernateUtil.closeSessionAndUnbindFromThread();
		}
		HibernateUtil.closeSessionFactory();

		return instrumentos;
	}

	public static ArrayList<Instrumento> listarInstrumento() {
		ArrayList<Instrumento> instrumentos = new ArrayList<Instrumento>();

		HibernateUtil.buildSessionFactory();
		Session sesion = null;
		try {
			HibernateUtil.openSessionAndBindToThread();
			sesion = HibernateUtil.getSessionFactory().getCurrentSession();
			sesion.beginTransaction();

			instrumentos = (ArrayList<Instrumento>) sesion.createQuery("FROM Instrumento i").list();

			sesion.getTransaction().commit();
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			HibernateUtil.closeSessionAndUnbindFromThread();
		}
		HibernateUtil.closeSessionFactory();

		return instrumentos;
	}

	public static byte[] obtenerImagenPorId(int idInstrumento) {
		byte[] imagen = null;

		HibernateUtil.buildSessionFactory();
		Session sesion = null;
		try {
			HibernateUtil.openSessionAndBindToThread();
			sesion = HibernateUtil.getSessionFactory().getCurrentSession();
			sesion.beginTransaction();

			imagen = (byte[]) sesion.createQuery("SELECT l.imagen FROM Instrumento l WHERE idInstrumento=:id")
					.setParameter("id", idInstrumento).uniqueResult();

			sesion.getTransaction().commit();
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			HibernateUtil.closeSessionAndUnbindFromThread();
		}
		HibernateUtil.closeSessionFactory();

		return imagen;
	}

	public static void anadirInstrumento(Instrumento i) {
		HibernateUtil.buildSessionFactory();
		Session sesion = null;
		try {
			HibernateUtil.openSessionAndBindToThread();
			sesion = HibernateUtil.getSessionFactory().getCurrentSession();
			sesion.beginTransaction();

			sesion.save(i);

			sesion.getTransaction().commit();
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			HibernateUtil.closeSessionAndUnbindFromThread();
		}
		HibernateUtil.closeSessionFactory();
	}

	public static void borrarInstrumento(int idInstrumento) {
		HibernateUtil.buildSessionFactory();
		Session sesion = null;
		try {
			HibernateUtil.openSessionAndBindToThread();
			sesion = HibernateUtil.getSessionFactory().getCurrentSession();
			sesion.beginTransaction();

			Instrumento l = (Instrumento) sesion.get(Instrumento.class, idInstrumento);
			sesion.delete(l);

			sesion.getTransaction().commit();
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			HibernateUtil.closeSessionAndUnbindFromThread();
		}
		HibernateUtil.closeSessionFactory();
	}

	public static void borrarInstrumento(String uuid) {
		HibernateUtil.buildSessionFactory();
		Session sesion = null;
		try {
			HibernateUtil.openSessionAndBindToThread();
			sesion = HibernateUtil.getSessionFactory().getCurrentSession();
			sesion.beginTransaction();

			sesion.createQuery("DELETE FROM Instrumento WHERE uuid=:encrypt").setParameter("encrypt", uuid)
					.executeUpdate();

			sesion.getTransaction().commit();
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			HibernateUtil.closeSessionAndUnbindFromThread();
		}
		HibernateUtil.closeSessionFactory();
	}

	public static Instrumento obtenerInstrumentoPorId(int idInstrumento) {
		Instrumento i = null;

		HibernateUtil.buildSessionFactory();
		Session sesion = null;
		try {
			HibernateUtil.openSessionAndBindToThread();
			sesion = HibernateUtil.getSessionFactory().getCurrentSession();
			sesion.beginTransaction();

			i = (Instrumento) sesion.get(Instrumento.class, idInstrumento);

			sesion.getTransaction().commit();
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			HibernateUtil.closeSessionAndUnbindFromThread();
		}
		HibernateUtil.closeSessionFactory();

		return i;
	}

	public static Instrumento obtenerInstrumentoPorUUID(String uuid) {
		Instrumento i = null;

		HibernateUtil.buildSessionFactory();
		Session sesion = null;
		try {
			HibernateUtil.openSessionAndBindToThread();
			sesion = HibernateUtil.getSessionFactory().getCurrentSession();
			sesion.beginTransaction();

			i = (Instrumento) sesion.createQuery("FROM Instrumento l WHERE l.uuid=:encrypt")
					.setParameter("encrypt", uuid).uniqueResult();

			sesion.getTransaction().commit();
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			HibernateUtil.closeSessionAndUnbindFromThread();
		}
		HibernateUtil.closeSessionFactory();

		return i;
	}

	public static void actualizarInstrumento(String nombre, double precio, String marca, String modelo,
			String referencia, byte[] os, String uuid) {

		HibernateUtil.buildSessionFactory();
		Session sesion = null;

		//System.out.println(nombre +" "+ precio+" "+ marca);
		try {
			HibernateUtil.openSessionAndBindToThread();
			sesion = HibernateUtil.getSessionFactory().getCurrentSession();
			sesion.beginTransaction();

			if (os != null) {
				Query query = sesion
						.createQuery("UPDATE Instrumento SET nombre=:nom, precio=:pre , marca=:mar, modelo=:mod, referencia=:ref, imagen=:ima WHERE uuid=:encrypt")
						.setParameter("nom", nombre).setParameter("pre", precio).setParameter("mar", marca)
						.setParameter("mod", modelo).setParameter("ref", referencia)
						.setParameter("ima", os).setParameter("encrypt", uuid);
				int result = query.executeUpdate();
				System.out.println("Filas actualizadas: " + result);
			} else {
				Query query = sesion
						.createQuery("UPDATE Instrumento SET nombre=:nom, precio=:pre, marca=:mar, modelo=:mod, referencia=:ref WHERE uuid=:encrypt")
						.setParameter("nom", nombre).setParameter("pre", precio).setParameter("mar", marca)
						.setParameter("mod", modelo).setParameter("ref", referencia).setParameter("encrypt", uuid);
				int result = query.executeUpdate();
				System.out.println("Filas actualizadas: " + result);
			}

			sesion.getTransaction().commit();
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			HibernateUtil.closeSessionAndUnbindFromThread();
		}
		HibernateUtil.closeSessionFactory();
	}
	
	public static void actualizarInstrumento(String nombre, double precio, String marca, String modelo,
			String referencia, ByteArrayOutputStream os, String uuid) {

		HibernateUtil.buildSessionFactory();
		Session sesion = null;

		//System.out.println(nombre +" "+ precio+" "+ marca);
		try {
			HibernateUtil.openSessionAndBindToThread();
			sesion = HibernateUtil.getSessionFactory().getCurrentSession();
			sesion.beginTransaction();

			if (os != null) {
				Query query = sesion
						.createQuery("UPDATE Instrumento SET nombre=:nom, precio=:pre , marca=:mar, modelo=:mod, referencia=:ref, imagen=:ima WHERE uuid=:encrypt")
						.setParameter("nom", nombre).setParameter("pre", precio).setParameter("mar", marca)
						.setParameter("mod", modelo).setParameter("ref", referencia)
						.setParameter("ima", os.toByteArray()).setParameter("encrypt", uuid);
				int result = query.executeUpdate();
				System.out.println("Filas actualizadas: " + result);
			} else {
				Query query = sesion
						.createQuery("UPDATE Instrumento SET nombre=:nom, precio=:pre, marca=:mar, modelo=:mod, referencia=:ref WHERE uuid=:encrypt")
						.setParameter("nom", nombre).setParameter("pre", precio).setParameter("mar", marca)
						.setParameter("mod", modelo).setParameter("ref", referencia).setParameter("encrypt", uuid);
				int result = query.executeUpdate();
				System.out.println("Filas actualizadas: " + result);
			}

			sesion.getTransaction().commit();
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			HibernateUtil.closeSessionAndUnbindFromThread();
		}
		HibernateUtil.closeSessionFactory();
	}

	public static List<Instrumento> listarInstrumentosPorId(int idUsuario) {
		// TODO Auto-generated method stub
		ArrayList<Instrumento> instrumentos = new ArrayList<Instrumento>();

		HibernateUtil.buildSessionFactory();
		Session sesion = null;
		try {
			HibernateUtil.openSessionAndBindToThread();
			sesion = HibernateUtil.getSessionFactory().getCurrentSession();
			sesion.beginTransaction();

			instrumentos = (ArrayList<Instrumento>) sesion.createQuery("FROM Instrumento WHERE usuario.idUsuario=:id").setParameter("id", idUsuario).list();

			sesion.getTransaction().commit();
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			HibernateUtil.closeSessionAndUnbindFromThread();
		}
		HibernateUtil.closeSessionFactory();

		return instrumentos;
	}
}
