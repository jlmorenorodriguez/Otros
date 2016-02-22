package es.altair.Struts2Web.dao;

import java.util.ArrayList;

import es.altair.Struts2Web.bean.Pedido;
import es.altair.Struts2Web.bean.Usuario;

public interface PedidoDAO {

	public void anadirPedido(Pedido p);

	public ArrayList<Pedido> listarPedidos(Usuario usuario);

	public Pedido obtenerPedidoPorId(Integer idPedido);
}
