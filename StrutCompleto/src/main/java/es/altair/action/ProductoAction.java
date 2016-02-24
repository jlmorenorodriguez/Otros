package es.altair.action;

import java.util.ArrayList;

import org.apache.struts2.dispatcher.SessionMap;

import com.opensymphony.xwork2.ActionSupport;
import com.opensymphony.xwork2.ModelDriven;
import es.altair.bean.Producto;
import es.altair.bean.Usuario;
import es.altair.dao.ProductoDAO;
import es.altair.dao.UsuarioDAO;

public class ProductoAction extends ActionSupport implements ModelDriven<Producto>{

	
	private static final long serialVersionUID = 1L;
	private ProductoDAO productoDAO;
	private int idProducto;
	private Producto producto;
	private Usuario usuario;
	public ArrayList<Producto> productoLista;

	public Producto getModel() {
		
		return producto;
	}
	
	public ArrayList<Producto> getProductoLista() {
		return productoLista;
	}


	public Producto getProducto() {
		return producto;
	}


	public void setProducto(Producto producto) {
		this.producto = producto;
	}
	
	
	public ProductoAction(){				
		productoDAO = new ProductoDAO();		
	}

	
	public int getIdProducto() {
		return idProducto;
	}

	public void setIdProducto(int idProducto) {
		this.idProducto = idProducto;
	}

	public String listar(){
				
		productoLista = productoDAO.listar();
		
		return ActionSupport.SUCCESS;
	}
	
	
	public String borrar(){
		
		productoDAO.borrar(idProducto);
		productoLista = productoDAO.listar();
		return ActionSupport.SUCCESS;
	}
	
	public String add(){		
		
		productoDAO.add(producto);
		productoLista = productoDAO.listar();
		
		return ActionSupport.SUCCESS;
	}
	
	public String edit(){		
				
		producto = productoDAO.obtenerProducto(idProducto);
		productoLista = productoDAO.listar();		
		return ActionSupport.SUCCESS;
	}

}
