package es.altair.datos;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import es.altair.bean.Usuario;
import es.altair.dao.UsuarioDAO;

/**
 * Servlet implementation class AnadirUsuarios
 */
public class AnadirUsuarios extends HttpServlet {
	private static final long serialVersionUID = 1L;

	/**
	 * @see HttpServlet#HttpServlet()
	 */
	public AnadirUsuarios() {
		super();
		// TODO Auto-generated constructor stub
	}

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		// TODO Auto-generated method stub
		doPost(request, response);
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		// TODO Auto-generated method stub

		String nombre = request.getParameter("nombreRegistro");
		System.out.println(nombre);
		String login = request.getParameter("loginRegistro");
		String password = request.getParameter("passRegistro");
		Usuario usu = UsuarioDAO.comprobarUsuario(login);

		if (usu == null) {
			Usuario u = new Usuario(login, password, nombre, 0);

			System.out.println(u);
			UsuarioDAO.anadirUsuario(u);
			response.sendRedirect("index.jsp");
		} else {
			response.sendRedirect("index.jsp?error=HayUnUsuarioCreadoConElMismoLogin");
		}

	}

}
