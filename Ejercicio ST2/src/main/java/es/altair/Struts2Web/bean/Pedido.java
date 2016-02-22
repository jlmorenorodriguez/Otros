package es.altair.Struts2Web.bean;

import java.io.Serializable;
import java.util.Arrays;

import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

@Entity
@Table(name = "pedidos")
public class Pedido implements Serializable {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;

	@Id
	private int idPedido;

	@ManyToOne
	@JoinColumn(name = "idUsuario")
	private Usuario usuario;

	@ManyToOne
	@JoinColumn(name = "idCliente")
	private Cliente cliente;

	private String documento;
	private String fecha;
	private byte[] fichero;

	public Pedido() {
		// TODO Auto-generated constructor stub
	}

	public Pedido(int idPedido, Usuario usuario, Cliente cliente, String documento, String fecha, byte[] fichero) {
		super();
		this.idPedido = idPedido;
		this.usuario = usuario;
		this.cliente = cliente;
		this.documento = documento;
		this.fecha = fecha;
		this.fichero = fichero;
	}
	

	public Pedido(Usuario usuario, Cliente cliente, String documento, byte[] fichero) {
		super();
		this.usuario = usuario;
		this.cliente = cliente;
		this.documento = documento;
		this.fichero = fichero;
	}

	public int getIdPedido() {
		return idPedido;
	}

	public void setIdPedido(int idPedido) {
		this.idPedido = idPedido;
	}

	public Usuario getUsuario() {
		return usuario;
	}

	public void setUsuario(Usuario usuario) {
		this.usuario = usuario;
	}

	public Cliente getCliente() {
		return cliente;
	}

	public void setCliente(Cliente cliente) {
		this.cliente = cliente;
	}

	public String getDocumento() {
		return documento;
	}

	public void setDocumento(String documento) {
		this.documento = documento;
	}

	public String getFecha() {
		return fecha;
	}

	public void setFecha(String fecha) {
		this.fecha = fecha;
	}

	public byte[] getFichero() {
		return fichero;
	}

	public void setFichero(byte[] fichero) {
		this.fichero = fichero;
	}

	@Override
	public String toString() {
		return "Pedido [idPedido=" + idPedido + ", usuario=" + usuario + ", cliente=" + cliente + ", documento="
				+ documento + ", fecha=" + fecha + "]";
	}

}
