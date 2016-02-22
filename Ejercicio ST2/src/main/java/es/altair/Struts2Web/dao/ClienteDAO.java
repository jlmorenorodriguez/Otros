package es.altair.Struts2Web.dao;

import java.util.ArrayList;

import es.altair.Struts2Web.bean.Cliente;
import es.altair.Struts2Web.bean.Usuario;

public interface ClienteDAO {
	public ArrayList<Cliente> listarClientes(Usuario usuario);

	public Cliente obtenerClientePorId(Integer idCliente);
}
