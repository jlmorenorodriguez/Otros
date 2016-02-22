package es.altair.bean;

import java.io.Serializable;
import java.util.Set;

import javax.persistence.CascadeType;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.OneToMany;
import javax.persistence.Table;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement
@Entity
@Table(name="usuarios")
public class Usuario implements Serializable {

	

	@Id
	private int idUsuario;
	private String login;
	private String password;
	private String nombre;
	private int tipo;
	
	@OneToMany(mappedBy="usuario", cascade=CascadeType.ALL)
	private Set<Instrumento> instrumentos;
	
	public Usuario() {
		// TODO Auto-generated constructor stub
	}
	
	
	public Usuario(int idUsuario, String login, String password, String nombre, int tipo) {
		super();
		this.idUsuario = idUsuario;
		this.login = login;
		this.password = password;
		this.nombre = nombre;
		this.tipo = tipo;
	}


	public Usuario(String login, String password, String nombre) {
		super();
		this.login = login;
		this.password = password;
		this.nombre = nombre;
	}


	public Usuario(String login, String password, String nombre, int tipo) {
		super();
		this.login = login;
		this.password = password;
		this.nombre = nombre;
		this.tipo = tipo;
	}


	public Usuario(int idUsuario, String login, String password) {
		super();
		this.idUsuario = idUsuario;
		this.login = login;
		this.password = password;
	}
	



	public int getIdUsuario() {
		return idUsuario;
	}

	public void setIdUsuario(int idUsuario) {
		this.idUsuario = idUsuario;
	}

	public String getLogin() {
		return login;
	}

	public void setLogin(String login) {
		this.login = login;
	}

	public String getPassword() {
		return password;
	}

	public void setPassword(String password) {
		this.password = password;
	}
	
	

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public int getTipo() {
		return tipo;
	}

	public void setTipo(int tipo) {
		this.tipo = tipo;
	}




	@Override
	public String toString() {
		return "Usuario [idUsuario=" + idUsuario + ", login=" + login + ", password=" + password + ", nombre=" + nombre
				+ ", tipo=" + tipo +"]";
	}




	
	
	
	
}
