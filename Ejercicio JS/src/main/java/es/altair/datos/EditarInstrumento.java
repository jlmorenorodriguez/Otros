package es.altair.datos;


import java.awt.Image;
import java.awt.image.BufferedImage;
import java.io.ByteArrayInputStream;
import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.io.InputStream;

import javax.imageio.ImageIO;
import javax.servlet.ServletException;
import javax.servlet.annotation.MultipartConfig;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import javax.servlet.http.Part;

import es.altair.bean.*;
import es.altair.dao.InstrumentoDAO;

/**
 * Servlet implementation class EditarInstrumento
 */
@MultipartConfig
public class EditarInstrumento extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public EditarInstrumento() {
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
		
		System.out.println("-------EDITAR--------");
		String uuid = request.getParameter("encrypt");
		String nombre = request.getParameter("nombre");
		String precio = request.getParameter("precio");
		String marca = request.getParameter("marca");
		String modelo = request.getParameter("modelo");
		String referencia = request.getParameter("referencia");
		Part filePart = request.getPart("imagen");
		
		System.out.println(uuid);
		System.out.println(nombre);
		System.out.println(precio);

		InputStream inputS = null;
		ByteArrayOutputStream os = null;
		if (!getFileName(filePart).equals("")) {
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

		// Sacamos al usuario de la sesi�n
		HttpSession sesion = request.getSession();

		//System.out.println(nombre +" "+precio+" "+ marca);
		
		InstrumentoDAO.actualizarInstrumento(nombre, Double.parseDouble(precio), marca, modelo, referencia, os, uuid);
		
		
		response.sendRedirect("pages/principalAdmin.jsp");
	}

	public static String getFileName(final Part part) {
		for (String content : part.getHeader("content-disposition").split(";")) {
			if (content.trim().startsWith("filename")) {
				return content.substring(content.indexOf('=') + 1).trim().replace("\"", "");
			}
		}
		return null;
	}
}
