package es.altair.datos;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import es.altair.bean.Usuario;
import es.altair.dao.UsuarioDAO;

/**
 * Servlet implementation class ValidarUsuario
 */
public class ValidarUsuario extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public ValidarUsuario() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doPost(request, response);
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		String login = request.getParameter("userName");
		String password = request.getParameter("userPassword");

		Usuario usu = UsuarioDAO.comprobarUsuario(login, password);
		
		if (usu != null) {
			// Guardo al usuario en Sesión
			HttpSession sesion = request.getSession();
			sesion.setAttribute("usuLogeado", usu);
			// Fin Sesión
			

			switch (usu.getTipo()) {
			case 0: // Normal
				response.sendRedirect("pages/principalUsuario.jsp");
				break;
			case 1: // Administrador
				response.sendRedirect("pages/principalAdmin.jsp");
				break;
			}
		} else {
			// Error
			response.sendRedirect("index.jsp?error=Usuarioy/oPasswordIncorrecto");
		}
	}

}
