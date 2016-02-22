package es.altair.Struts2Web.bean;

import java.util.Set;

import javax.persistence.CascadeType;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.OneToMany;
import javax.persistence.Table;

@Entity
@Table(name = "clientes")
public class Cliente implements java.io.Serializable {

	@Id
	private int idCliente;
	private String codigo;
	private String nombre;
	private String direccion;
	private String poblacion;
	private String jerarquia;

	@ManyToOne
	@JoinColumn(name = "idUsuario")
	private Usuario usuario;

	@OneToMany(mappedBy = "cliente", cascade = CascadeType.ALL)
	private Set<Pedido> pedidos;

	public Cliente() {
		// TODO Auto-generated constructor stub
	}

	public Cliente(int idCliente, String codigo, String nombre, String direccion, String poblacion, String jerarquia) {
		super();
		this.idCliente = idCliente;
		this.codigo = codigo;
		this.nombre = nombre;
		this.direccion = direccion;
		this.poblacion = poblacion;
		this.jerarquia = jerarquia;
	}

	public Cliente(String codigo, String nombre, String direccion, String poblacion, String jerarquia) {
		super();
		this.codigo = codigo;
		this.nombre = nombre;
		this.direccion = direccion;
		this.poblacion = poblacion;
		this.jerarquia = jerarquia;
	}

	public int getIdCliente() {
		return idCliente;
	}

	public void setIdCliente(int idCliente) {
		this.idCliente = idCliente;
	}

	public String getCodigo() {
		return codigo;
	}

	public void setCodigo(String codigo) {
		this.codigo = codigo;
	}

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public String getDireccion() {
		return direccion;
	}

	public void setDireccion(String direccion) {
		this.direccion = direccion;
	}

	public String getPoblacion() {
		return poblacion;
	}

	public void setPoblacion(String poblacion) {
		this.poblacion = poblacion;
	}

	public String getJerarquia() {
		return jerarquia;
	}

	public void setJerarquia(String jerarquia) {
		this.jerarquia = jerarquia;
	}

	public Usuario getUsuario() {
		return usuario;
	}

	public void setUsuario(Usuario usuario) {
		this.usuario = usuario;
	}

	public Set<Pedido> getPedidos() {
		return pedidos;
	}

	public void setPedidos(Set<Pedido> pedidos) {
		this.pedidos = pedidos;
	}

	@Override
	public String toString() {
		return "Cliente [idCliente=" + idCliente + ", codigo=" + codigo + ", nombre=" + nombre + ", direccion="
				+ direccion + ", poblacion=" + poblacion + ", jerarquia=" + jerarquia + ", usuario=" + usuario + "]";
	}

}
