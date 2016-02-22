package es.altair.Struts2Web.bean;

import java.io.Serializable;

import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name="productos")
public class Producto implements Serializable {

	@Id
	private int idProducto;
	private String familia;
	private String nombre;
	private String codigosap;
	private String ltkg;
	private String caja;
	private String tarifa;
	private String unidades;

	public Producto() {
		// TODO Auto-generated constructor stub
	}

	public Producto(int idProducto, String familia, String nombre, String codigosap, String ltkg, String caja,
			String tarifa, String unidades) {
		super();
		this.idProducto = idProducto;
		this.familia = familia;
		this.nombre = nombre;
		this.codigosap = codigosap;
		this.ltkg = ltkg;
		this.caja = caja;
		this.tarifa = tarifa;
		this.unidades = unidades;
	}

	public Producto(String familia, String nombre, String codigosap, String ltkg, String caja, String tarifa,
			String unidades) {
		super();
		this.familia = familia;
		this.nombre = nombre;
		this.codigosap = codigosap;
		this.ltkg = ltkg;
		this.caja = caja;
		this.tarifa = tarifa;
		this.unidades = unidades;
	}

	public int getIdProducto() {
		return idProducto;
	}

	public void setIdProducto(int idProducto) {
		this.idProducto = idProducto;
	}

	public String getFamilia() {
		return familia;
	}

	public void setFamilia(String familia) {
		this.familia = familia;
	}

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public String getCodigosap() {
		return codigosap;
	}

	public void setCodigosap(String codigosap) {
		this.codigosap = codigosap;
	}

	public String getLtkg() {
		return ltkg;
	}

	public void setLtkg(String ltkg) {
		this.ltkg = ltkg;
	}

	public String getCaja() {
		return caja;
	}

	public void setCaja(String caja) {
		this.caja = caja;
	}

	public String getTarifa() {
		return tarifa;
	}

	public void setTarifa(String tarifa) {
		this.tarifa = tarifa;
	}

	public String getUnidades() {
		return unidades;
	}

	public void setUnidades(String unidades) {
		this.unidades = unidades;
	}
}
