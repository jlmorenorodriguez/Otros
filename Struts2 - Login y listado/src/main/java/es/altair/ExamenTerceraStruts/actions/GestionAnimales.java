package es.altair.ExamenTerceraStruts.actions;

import es.altair.ExamenTerceraStruts.bean.Animal;
import es.altair.ExamenTerceraStruts.dao.AnimalDAO;
import es.altair.ExamenTerceraStruts.dao.AnimalIMPL;

import java.util.ArrayList;

import com.opensymphony.xwork2.ActionSupport;

public class GestionAnimales extends ActionSupport {

	private ArrayList<Animal> animales = new ArrayList<Animal>();
	private Animal animal = new Animal();
	private AnimalDAO anidao = new AnimalIMPL();
	
	public String listar(){
		animales = anidao.listarAnimales();
		return ActionSupport.SUCCESS;
	}

	public ArrayList<Animal> getAnimales() {
		return animales;
	}

	public void setAnimales(ArrayList<Animal> animales) {
		this.animales = animales;
	}

	public Animal getAnimal() {
		return animal;
	}

	public void setAnimal(Animal animal) {
		this.animal = animal;
	}

	public AnimalDAO getAnidao() {
		return anidao;
	}

	public void setAnidao(AnimalDAO anidao) {
		this.anidao = anidao;
	}
	
	
	
}
