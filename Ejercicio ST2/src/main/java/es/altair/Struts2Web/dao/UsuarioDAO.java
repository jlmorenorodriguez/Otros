package es.altair.Struts2Web.dao;

import es.altair.Struts2Web.bean.Usuario;

public interface UsuarioDAO {
	public Usuario validarUsuario(String user, String pwd);
}
