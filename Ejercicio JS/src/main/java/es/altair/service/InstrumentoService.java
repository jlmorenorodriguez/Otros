package es.altair.service;

import java.util.ArrayList;
import java.util.List;
import java.util.UUID;

import javax.ws.rs.Consumes;
import javax.ws.rs.DELETE;
import javax.ws.rs.POST;
import javax.ws.rs.PUT;
import javax.ws.rs.Path;
import javax.ws.rs.PathParam;
import javax.ws.rs.Produces;
import javax.ws.rs.core.MediaType;

import org.apache.commons.codec.binary.Base64;
import org.codehaus.jettison.json.JSONException;
import org.codehaus.jettison.json.JSONObject;

import es.altair.bean.Instrumento;
import es.altair.bean.Usuario;
import es.altair.dao.InstrumentoDAO;;

@Path("/InstrumentoService")
public class InstrumentoService {

	@POST
	@Path("/listadoInstrumentos")
	@Consumes(MediaType.APPLICATION_JSON)
	@Produces(MediaType.APPLICATION_JSON)
	public List<Instrumento> listadoAnuncios(String json) {
		System.out.println("Entrando en Listado...");

		int idUsuario = 0;
		
		JSONObject jsonobject;

		try {

			jsonobject = new JSONObject(json);
			idUsuario = jsonobject.getInt("idUsuario");
		} catch (JSONException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

		
		List<Instrumento> instrumentos = new ArrayList<Instrumento>();
		if(idUsuario == 3){
			instrumentos = InstrumentoDAO.listarInstrumento();
		}else{
		instrumentos = InstrumentoDAO.listarInstrumentosPorId(idUsuario);
		}
		return instrumentos;
	}


	@DELETE
	@Path("/borrarInstrumento/{uuid}")
	public void borrarInstrumento(@PathParam("uuid") String uuid) {
		System.out.println("Entrando en Borrar...");

		InstrumentoDAO.borrarInstrumento(uuid);
	}

	@PUT
	@Consumes(MediaType.APPLICATION_JSON)
	@Path("/actualizarInstrumento")
	public void actualizarInstrumentos(String json) {
		System.out.println("Entrando en Actualizar...");

		JSONObject jsonobject;
		try {
			jsonobject = new JSONObject(json);
			 int idInstrumento = jsonobject.optInt("idInstrumento");
             String nombre = jsonobject.optString("nombre");
             Double precio = jsonobject.getDouble("precio");
             String marca = jsonobject.optString("marca");
             String modelo = jsonobject.optString("modelo");
             String referencia = jsonobject.optString("referencia");
             String img = jsonobject.optString("imagen");
             byte[] imagen = Base64.decodeBase64(img);
             String uuid = jsonobject.optString("uuid");
			
			
			System.out.println("Instrumento: " + jsonobject.toString());

			InstrumentoDAO.actualizarInstrumento(nombre, precio, marca,modelo,referencia, imagen, uuid);
		} catch (JSONException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

	}
	
	@PUT
	@Consumes(MediaType.APPLICATION_JSON)
	@Path("/anadirInstrumento")
	public void anadirInstrumento(String json) {
		System.out.println("Entrando en Añadir...");

		JSONObject jsonobject;
		try {
			jsonobject = new JSONObject(json);
			//int idInstrumento = jsonobject.optInt("idInstrumento");
            String nombre = jsonobject.optString("nombre");
            Double precio = jsonobject.getDouble("precio");
            String marca = jsonobject.optString("marca");
            String modelo = jsonobject.optString("modelo");
            String referencia = jsonobject.optString("referencia");
            String img = jsonobject.optString("imagen");
            byte[] imagen = Base64.decodeBase64(img);
			String uuid = UUID.randomUUID().toString();

			int idUsuario = jsonobject.optInt("idUsuario");
			String login = jsonobject.optString("login");
			String password = jsonobject.optString("password");
			String nombreUsu = jsonobject.optString("nombreUsu");
			int tipo = jsonobject.optInt("tipo");
			
			InstrumentoDAO.anadirInstrumento(
					new Instrumento(nombre, precio, marca, modelo,referencia,imagen,uuid, new Usuario(idUsuario, login, password, nombreUsu, tipo)));
		} catch (JSONException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

	}
}