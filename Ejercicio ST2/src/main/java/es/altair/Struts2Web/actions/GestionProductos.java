package es.altair.Struts2Web.actions;

import java.util.ArrayList;

import com.opensymphony.xwork2.ActionSupport;
import com.opensymphony.xwork2.ModelDriven;

import es.altair.Struts2Web.bean.Producto;
import es.altair.Struts2Web.dao.ProductoDAO;
import es.altair.Struts2Web.dao.ProductoImpl;

public class GestionProductos extends ActionSupport implements ModelDriven<Producto>{

	private ArrayList<Producto> productos = new ArrayList<Producto>();
	
	private Producto producto = new Producto();
	
	private ProductoDAO prodao = new ProductoImpl();
	
	public String listar() {
		productos = prodao.listarProductos();
		return ActionSupport.SUCCESS;
	}
	
	public String anadir() {
		return ActionSupport.SUCCESS;
	}
	
	public String anadirDef() {
		prodao.anadirProducto(producto);
		return ActionSupport.SUCCESS;
	}
	
	public String editarDef() {
		prodao.actualizarProducto(producto);
		return ActionSupport.SUCCESS;
	}
	
	public ArrayList<Producto> getProductos() {
		return productos;
	}
	
	public void setProductos(ArrayList<Producto> productos) {
		this.productos = productos;
	}
	
	public Producto getProducto() {
		return producto;
	}
	
	public void setProducto(Producto producto) {
		this.producto = producto;
	}

	public Producto getModel() {
		return producto;
	}
}
