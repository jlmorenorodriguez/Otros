package es.altair.datos;


import java.awt.Image;
import java.awt.image.BufferedImage;
import java.io.ByteArrayInputStream;
import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.util.UUID;

import javax.imageio.ImageIO;
import javax.servlet.ServletException;
import javax.servlet.annotation.MultipartConfig;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import javax.servlet.http.Part;

import es.altair.bean.Instrumento;
import es.altair.bean.Usuario;
import es.altair.dao.InstrumentoDAO;

/**
 * Servlet implementation class AnadirInstrumento
 */
@MultipartConfig
public class AnadirInstrumento extends HttpServlet {
	private static final long serialVersionUID = 1L;

	/**
	 * @see HttpServlet#HttpServlet()
	 */
	public AnadirInstrumento() {
		super();
		// TODO Auto-generated constructor stub
	}

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		doPost(request, response);
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		
		String nombre = request.getParameter("nombre");
		System.out.println("nombre instrumento :" +nombre);
		String precio = request.getParameter("precio");
		String marca = request.getParameter("marca");
		String modelo = request.getParameter("modelo");
		String referencia = request.getParameter("referencia");

		// Tratamiento de la Imagen
		InputStream inputS = null;
		Part filePart = request.getPart("imagen");
		ByteArrayOutputStream os = null;
		if (filePart != null) {
			inputS = filePart.getInputStream();

			// Escalado
			BufferedImage imageBuffer = ImageIO.read(inputS);
			Image tmp = imageBuffer.getScaledInstance(640, 640, BufferedImage.SCALE_FAST);
			BufferedImage buffered = new BufferedImage(640, 640, BufferedImage.TYPE_INT_RGB);
			buffered.getGraphics().drawImage(tmp, 0, 0, null);

			os = new ByteArrayOutputStream();
			ImageIO.write(buffered, "jpg", os);
			inputS = new ByteArrayInputStream(os.toByteArray());
		}

		String uuid = UUID.randomUUID().toString();

		// Sacamos al usuario de la sesión
		HttpSession sesion = request.getSession();

		Instrumento i = new Instrumento(nombre, Double.parseDouble(precio), marca, modelo, referencia, os.toByteArray(), uuid, ((Usuario) sesion.getAttribute("usuLogeado")));
		
		InstrumentoDAO.anadirInstrumento(i);

		response.sendRedirect("pages/principalUsuario.jsp");
	}

}