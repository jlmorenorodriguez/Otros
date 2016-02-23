package es.altair.ExamenTerceraStruts.bean;

import java.util.HashSet;
import java.util.Set;

import javax.persistence.CascadeType;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.OneToMany;
import javax.persistence.Table;

@Entity
@Table(name="cliente")
public class Cliente implements java.io.Serializable {

	@Id
	private Integer idcliente;
	
	private String codigo;
	
	private String nombre;
	
	private String dni;

	private String direccion;

	private String telefono;

	private String movil;

	@OneToMany(mappedBy="cliente", cascade=CascadeType.ALL)
	private Set<Animal> animales = new HashSet<Animal>();

	public Cliente() {
	}

	public Cliente(String codigo, String nombre, String dni, String direccion,
			String telefono, String movil) {
		this.codigo = codigo;
		this.nombre = nombre;
		this.dni = dni;
		this.direccion = direccion;
		this.telefono = telefono;
		this.movil = movil;
	}

	public Integer getIdcliente() {
		return this.idcliente;
	}

	public void setIdcliente(Integer idcliente) {
		this.idcliente = idcliente;
	}
	
	public String getCodigo() {
		return codigo;
	}
	
	public void setCodigo(String codigo) {
		this.codigo = codigo;
	}

	public String getNombre() {
		return this.nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public String getDni() {
		return this.dni;
	}

	public void setDni(String dni) {
		this.dni = dni;
	}

	public String getDireccion() {
		return this.direccion;
	}

	public void setDireccion(String direccion) {
		this.direccion = direccion;
	}

	public String getTelefono() {
		return this.telefono;
	}

	public void setTelefono(String telefono) {
		this.telefono = telefono;
	}

	public String getMovil() {
		return this.movil;
	}

	public void setMovil(String movil) {
		this.movil = movil;
	}

	public Set<Animal> getAnimales() {
		return this.animales;
	}

	public void setAnimales(Set<Animal> animales) {
		this.animales = animales;
	}

	@Override
	public String toString() {
		return "Cliente [idcliente=" + idcliente + ", codigo=" + codigo + ", nombre=" + nombre + ", dni=" + dni
				+ ", direccion=" + direccion + ", telefono=" + telefono + ", movil=" + movil + "]";
	}

}
