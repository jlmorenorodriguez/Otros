package es.altair.bean;

import java.io.Serializable;

import javax.persistence.Entity;

import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;
import javax.xml.bind.annotation.XmlRootElement;


@XmlRootElement
@Entity
@Table(name="instrumento")
public class Instrumento implements Serializable {

	@Id
	private int idInstrumento;
	private String nombre;
	private double precio;
	private String marca;
	private String modelo;
	private String referencia;
	private byte[] imagen;

	private String uuid;

	@ManyToOne
	@JoinColumn(name = "idUsuario")
	private Usuario usuario;
	
	public Instrumento() {
		// TODO Auto-generated constructor stub
	}

	public Instrumento(int idInstrumento, String nombre, double precio, String marca, String modelo, String referencia,
			byte[] imagen, Usuario usuario) {
		super();
		this.idInstrumento = idInstrumento;
		this.nombre = nombre;
		this.precio = precio;
		this.marca = marca;
		this.modelo = modelo;
		this.referencia = referencia;
		this.imagen = imagen;
		this.usuario = usuario;
	}

	
	
	public Instrumento(int idInstrumento, String nombre, double precio, String marca, String modelo, String referencia,
			byte[] imagen, String uuid, Usuario usuario) {
		super();
		this.idInstrumento = idInstrumento;
		this.nombre = nombre;
		this.precio = precio;
		this.marca = marca;
		this.modelo = modelo;
		this.referencia = referencia;
		this.imagen = imagen;
		this.uuid = uuid;
		this.usuario = usuario;
	}

	public Instrumento(int idInstrumento, String nombre, double precio, Usuario usuario) {
		super();
		this.idInstrumento = idInstrumento;
		this.nombre = nombre;
		this.precio = precio;
		this.usuario = usuario;
	}

	

	public Instrumento(String nombre, double precio, String marca, String modelo, String referencia, byte[] imagen,
			String uuid, Usuario usuario) {
		super();
		this.nombre = nombre;
		this.precio = precio;
		this.marca = marca;
		this.modelo = modelo;
		this.referencia = referencia;
		this.imagen = imagen;
		this.uuid = uuid;
		this.usuario = usuario;
	}

	public int getIdInstrumento() {
		return idInstrumento;
	}

	public void setIdInstrumento(int idInstrumento) {
		this.idInstrumento = idInstrumento;
	}

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public double getPrecio() {
		return precio;
	}

	public void setPrecio(double precio) {
		this.precio = precio;
	}

	public Usuario getUsuario() {
		return usuario;
	}

	public void setUsuario(Usuario usuario) {
		this.usuario = usuario;
	}

	public String getMarca() {
		return marca;
	}

	public void setMarca(String marca) {
		this.marca = marca;
	}

	public String getModelo() {
		return modelo;
	}

	public void setModelo(String modelo) {
		this.modelo = modelo;
	}

	public String getReferencia() {
		return referencia;
	}

	public void setReferencia(String referencia) {
		this.referencia = referencia;
	}

	public byte[] getImagen() {
		return imagen;
	}

	public void setImagen(byte[] imagen) {
		this.imagen = imagen;
	}

	public String getUuid() {
		return uuid;
	}

	public void setUuid(String uuid) {
		this.uuid = uuid;
	}

	@Override
	public String toString() {
		return "Instrumento [idInstrumento=" + idInstrumento + ", nombre=" + nombre + ", precio=" + precio
				+ ", usuario=" + usuario + "]";
	}
	
	
}
