package es.altair.Struts2Web.dao;

import java.util.ArrayList;

import es.altair.Struts2Web.bean.Producto;

public interface ProductoDAO {

	public ArrayList<Producto> listarProductos();
	public void anadirProducto(Producto p);
	public Producto obtenerProductoPorId(Integer idProducto);
	public void actualizarProducto(Producto producto);
	public void borrarProductoPorId(Integer idProducto);
}
