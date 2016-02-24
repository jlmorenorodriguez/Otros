package es.altair.ExamenTerceraStruts.dao;

import java.util.ArrayList;

import org.hibernate.Session;

import es.altair.ExamenTerceraStruts.bean.Animal;
import es.altair.ExamenTerceraStruts.modelo.HibernateUtil;

public class AnimalIMPL implements AnimalDAO{

	public ArrayList<Animal> listarAnimales() {
		// TODO Auto-generated method stub
		ArrayList<Animal> animales = null;
		HibernateUtil.buildSessionFactory();
		Session sesion = null;
		try {
			HibernateUtil.openSessionAndBindToThread();
			sesion = HibernateUtil.getSessionFactory().getCurrentSession();
			sesion.beginTransaction();

			// Operaciones
			animales = (ArrayList<Animal>)sesion.createQuery("From Animal a").list();
			sesion.getTransaction().commit();
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			HibernateUtil.closeSessionAndUnbindFromThread();
		}
		HibernateUtil.closeSessionFactory();
		return animales;
	}

}
