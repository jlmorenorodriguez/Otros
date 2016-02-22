package es.altair.Struts2Web.bean;

import java.io.Serializable;
import java.util.Set;

import javax.persistence.CascadeType;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.OneToMany;
import javax.persistence.Table;

@Entity
@Table(name = "usuarios")
public class Usuario implements Serializable {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;

	@Id
	private int idUsuario;
	private String nombre;
	private String user;
	private String pwd;
	private String emailFrom;
	private String passFrom;
	private String emailTo;

	@OneToMany(mappedBy = "usuario", cascade = CascadeType.ALL)
	private Set<Cliente> clientes;

	@OneToMany(mappedBy = "usuario", cascade = CascadeType.ALL)
	private Set<Pedido> pedidos;

	public Usuario() {
		// TODO Auto-generated constructor stub
	}

	public Usuario(int idUsuario, String nombre, String user, String pwd) {
		super();
		this.idUsuario = idUsuario;
		this.nombre = nombre;
		this.user = user;
		this.pwd = pwd;
	}

	public Usuario(int idUsuario, String nombre, String user, String pwd, String emailFrom, String passFrom,
			String emailTo) {
		super();
		this.idUsuario = idUsuario;
		this.nombre = nombre;
		this.user = user;
		this.pwd = pwd;
		this.emailFrom = emailFrom;
		this.passFrom = passFrom;
		this.emailTo = emailTo;
	}

	public int getIdUsuario() {
		return idUsuario;
	}

	public void setIdUsuario(int idUsuario) {
		this.idUsuario = idUsuario;
	}

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public String getUser() {
		return user;
	}

	public void setUser(String user) {
		this.user = user;
	}

	public String getPwd() {
		return pwd;
	}

	public void setPwd(String pwd) {
		this.pwd = pwd;
	}

	public String getEmailFrom() {
		return emailFrom;
	}

	public void setEmailFrom(String emailFrom) {
		this.emailFrom = emailFrom;
	}

	public String getPassFrom() {
		return passFrom;
	}

	public void setPassFrom(String passFrom) {
		this.passFrom = passFrom;
	}

	public String getEmailTo() {
		return emailTo;
	}

	public void setEmailTo(String emailTo) {
		this.emailTo = emailTo;
	}

	public Set<Cliente> getClientes() {
		return clientes;
	}

	public void setClientes(Set<Cliente> clientes) {
		this.clientes = clientes;
	}

	public Set<Pedido> getPedidos() {
		return pedidos;
	}

	public void setPedidos(Set<Pedido> pedidos) {
		this.pedidos = pedidos;
	}

	@Override
	public String toString() {
		return "Usuario [idUsuario=" + idUsuario + ", nombre=" + nombre + ", user=" + user + ", pwd=" + pwd
				+ ", emailFrom=" + emailFrom + ", passFrom=" + passFrom + ", emailTo=" + emailTo + "]";
	}

}
