package es.altair.Struts2Web.actions;

import com.opensymphony.xwork2.ActionSupport;

import es.altair.Struts2Web.bean.Producto;
import es.altair.Struts2Web.dao.ProductoDAO;
import es.altair.Struts2Web.dao.ProductoImpl;

public class GestionProducto extends ActionSupport {

	private Integer idProducto;

	private Producto producto = new Producto();
	
	private ProductoDAO prodao = new ProductoImpl();
	
	public String editar() {
		producto = prodao.obtenerProductoPorId(idProducto);
		return ActionSupport.SUCCESS;
	}
	
	public String borrar() {
		prodao.borrarProductoPorId(idProducto);
		return ActionSupport.SUCCESS;
	}
	
	public Integer getIdProducto() {
		return idProducto;
	}
	
	public void setIdProducto(Integer idProducto) {
		this.idProducto = idProducto;
	}
	
	public Producto getProducto() {
		return producto;
	}
	
	public void setProducto(Producto producto) {
		this.producto = producto;
	}

}
