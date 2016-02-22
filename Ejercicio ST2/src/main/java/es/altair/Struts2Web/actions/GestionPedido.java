package es.altair.Struts2Web.actions;

import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.net.MalformedURLException;
import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.Map;

import javax.servlet.http.HttpServletRequest;

import org.apache.struts2.dispatcher.SessionMap;
import org.apache.struts2.interceptor.ServletRequestAware;
import org.apache.struts2.interceptor.SessionAware;

import com.itextpdf.text.BaseColor;
import com.itextpdf.text.Chunk;
import com.itextpdf.text.Document;
import com.itextpdf.text.DocumentException;
import com.itextpdf.text.Font;
import com.itextpdf.text.Image;
import com.itextpdf.text.PageSize;
import com.itextpdf.text.Paragraph;
import com.itextpdf.text.Phrase;
import com.itextpdf.text.pdf.PdfPCell;
import com.itextpdf.text.pdf.PdfPTable;
import com.itextpdf.text.pdf.PdfWriter;
import com.opensymphony.xwork2.ActionSupport;

import es.altair.Struts2Web.bean.Cliente;
import es.altair.Struts2Web.bean.Pedido;
import es.altair.Struts2Web.bean.Producto;
import es.altair.Struts2Web.bean.Usuario;
import es.altair.Struts2Web.dao.ClienteDAO;
import es.altair.Struts2Web.dao.ClienteImpl;
import es.altair.Struts2Web.dao.PedidoDAO;
import es.altair.Struts2Web.dao.PedidoImpl;
import es.altair.Struts2Web.dao.ProductoDAO;
import es.altair.Struts2Web.dao.ProductoImpl;

public class GestionPedido extends ActionSupport implements SessionAware, ServletRequestAware {

	private HttpServletRequest req;

	private Integer idCliente;

	private SessionMap<String, Object> session;

	private ArrayList<Cliente> clientes = new ArrayList<Cliente>();

	private ArrayList<Producto> productos = new ArrayList<Producto>();

	private String[] selectedId;

	private ClienteDAO clidao = new ClienteImpl();
	private ProductoDAO prodao = new ProductoImpl();
	private PedidoDAO pedao = new PedidoImpl();

	public String listarClientes() {
		clientes = clidao.listarClientes(((Usuario) session.get("usulogeado")));
		return ActionSupport.SUCCESS;
	}

	public String selecCliente() {
		System.out.println("IDCLiente: " + idCliente);

		Cliente c = clidao.obtenerClientePorId(idCliente);
		session.put("cliente", c);

		productos = prodao.listarProductos();
		return ActionSupport.SUCCESS;
	}

	public String selecProductos() {
		for (int i = 0; i < selectedId.length; i++) {
			System.out.println(i + ": " + selectedId[i]);
		}
		// Generar el PDF
		ByteArrayOutputStream pdf = generarPDF();
		// Guardar Pedido Base de Datos
		LocalDateTime ld = LocalDateTime.now();
		String nombreFichero = ((Cliente) session.get("cliente")).getCodigo() + "_" + ld.getDayOfMonth() + "_"
				+ ld.getMonthValue() + "_" + ld.getYear() + "_" + ld.getHour() + "_" + ld.getMinute() + "_"
				+ ld.getSecond() + ".pdf";

		Pedido p = new Pedido(((Usuario) session.get("usulogeado")), ((Cliente) session.get("cliente")),
				nombreFichero, pdf.toByteArray());
		pedao.anadirPedido(p);
		return "success";
	}

	private ByteArrayOutputStream generarPDF() {
		ByteArrayOutputStream baos = new ByteArrayOutputStream();
		Document document = new Document(PageSize.A4);
		try {
			PdfWriter.getInstance(document, baos);

			document.open();

			Font boldfont14 = new Font(Font.FontFamily.TIMES_ROMAN, 14, Font.BOLD);
			Font font14 = new Font(Font.FontFamily.TIMES_ROMAN, 14);
			Font boldfont12 = new Font(Font.FontFamily.TIMES_ROMAN, 12, Font.BOLD);
			Font font12 = new Font(Font.FontFamily.TIMES_ROMAN, 12);

			Image image = Image
					.getInstance(req.getSession().getServletContext().getRealPath("/images") + "\\altair.png");
			image.scaleAbsolute(50f, 50f);
			document.add(image);

			Paragraph vendedor = new Paragraph("VENDEDOR: " + ((Usuario) session.get("usulogeado")).getNombre());
			document.add(vendedor);
			
			document.add(Chunk.NEWLINE);

			PdfPTable tablaCliente = new PdfPTable(4);
			tablaCliente.setWidthPercentage(100);

			PdfPCell cab1 = new PdfPCell();
			cab1.setBackgroundColor(BaseColor.GRAY);
			cab1.addElement(new Phrase("CÓDIGO", boldfont14));
			tablaCliente.addCell(cab1);

			PdfPCell cab2 = new PdfPCell();
			cab2.setBackgroundColor(BaseColor.GRAY);
			cab2.addElement(new Phrase("NOMBRE", boldfont14));
			tablaCliente.addCell(cab2);

			PdfPCell cab3 = new PdfPCell();
			cab3.setBackgroundColor(BaseColor.GRAY);
			cab3.addElement(new Phrase("DIRECCIÓN", boldfont14));
			tablaCliente.addCell(cab3);

			PdfPCell cab4 = new PdfPCell();
			cab4.setBackgroundColor(BaseColor.GRAY);
			cab4.addElement(new Phrase("POBLACIÓN", boldfont14));
			tablaCliente.addCell(cab4);

			PdfPCell cab5 = new PdfPCell();
			cab5.addElement(new Phrase(((Cliente) session.get("cliente")).getCodigo(), boldfont12));
			tablaCliente.addCell(cab5);

			PdfPCell cab6 = new PdfPCell();
			cab6.addElement(new Phrase(((Cliente) session.get("cliente")).getNombre(), boldfont12));
			tablaCliente.addCell(cab6);

			PdfPCell cab7 = new PdfPCell();
			cab7.addElement(new Phrase(((Cliente) session.get("cliente")).getDireccion(), boldfont12));
			tablaCliente.addCell(cab7);

			PdfPCell cab8 = new PdfPCell();
			cab8.addElement(new Phrase(((Cliente) session.get("cliente")).getPoblacion(), boldfont12));
			tablaCliente.addCell(cab8);

			document.add(tablaCliente);

			document.add(Chunk.NEWLINE);

			document.close();

			baos.close();
		} catch (DocumentException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (MalformedURLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

		return baos;
	}

	public ArrayList<Cliente> getClientes() {
		return clientes;
	}

	public void setClientes(ArrayList<Cliente> clientes) {
		this.clientes = clientes;
	}

	public void setSession(Map<String, Object> session) {
		this.session = (SessionMap<String, Object>) session;
	}

	public ArrayList<Producto> getProductos() {
		return productos;
	}

	public void setProductos(ArrayList<Producto> productos) {
		this.productos = productos;
	}

	public String[] getSelectedId() {
		return selectedId;
	}

	public void setSelectedId(String[] selectedId) {
		this.selectedId = selectedId;
	}

	public Integer getIdCliente() {
		return idCliente;
	}

	public void setIdCliente(Integer idCliente) {
		this.idCliente = idCliente;
	}

	public void setServletRequest(HttpServletRequest request) {
		this.req = request;
	}
}