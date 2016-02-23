package es.altair.ExamenTerceraStruts.bean;

import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

@Entity
@Table(name = "animal")
public class Animal implements java.io.Serializable {

	@Id
	private Integer idanimal;

	@ManyToOne
	@JoinColumn(name = "idcliente")
	private Cliente cliente;

	private String nombre;

	private String nacimiento;

	private String identificacion;

	private String raza;

	private String color;

	public Animal() {
	}

	public Animal(Cliente cliente) {
		this.cliente = cliente;
	}

	public Animal(String nombre, String nacimiento, String identificacion,
			String raza, String color, Cliente cliente) {
		this.nombre = nombre;
		this.nacimiento = nacimiento;
		this.identificacion = identificacion;
		this.raza = raza;
		this.color = color;
		this.cliente = cliente;
	}

	public Integer getIdanimal() {
		return this.idanimal;
	}

	public void setIdanimal(Integer idanimal) {
		this.idanimal = idanimal;
	}

	public Cliente getCliente() {
		return this.cliente;
	}

	public void setCliente(Cliente cliente) {
		this.cliente = cliente;
	}

	public String getNombre() {
		return this.nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public String getNacimiento() {
		return this.nacimiento;
	}

	public void setNacimiento(String nacimiento) {
		this.nacimiento = nacimiento;
	}

	public String getIdentificacion() {
		return this.identificacion;
	}

	public void setIdentificacion(String identificacion) {
		this.identificacion = identificacion;
	}

	public String getRaza() {
		return this.raza;
	}

	public void setRaza(String raza) {
		this.raza = raza;
	}

	public String getColor() {
		return this.color;
	}

	public void setColor(String color) {
		this.color = color;
	}

	@Override
	public String toString() {
		return "Animal [idanimal=" + idanimal + ", cliente=" + cliente + ", nombre=" + nombre + ", nacimiento="
				+ nacimiento + ", identificacion=" + identificacion + ", raza=" + raza + ", color=" + color + "]";
	}
}
