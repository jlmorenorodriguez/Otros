package es.altair.service;

import javax.ws.rs.Consumes;
import javax.ws.rs.POST;
import javax.ws.rs.Path;
import javax.ws.rs.Produces;
import javax.ws.rs.core.MediaType;

import org.codehaus.jettison.json.JSONException;
import org.codehaus.jettison.json.JSONObject;

import es.altair.bean.Usuario;
import es.altair.dao.UsuarioDAO;

@Path("/LoginService")
public class LoginService {
	
	@POST
	@Path("/login")
	@Consumes(MediaType.APPLICATION_JSON)
	@Produces(MediaType.APPLICATION_JSON)
	public String login(String json) {
		System.out.println("Entrando en Login...");
		
		String login, password;
		
		JSONObject resultado = new JSONObject();
		try {
			JSONObject jsonobject = new JSONObject(json);
			login = jsonobject.getString("login");
			password = jsonobject.getString("password");
			
			// Validar el login y el password
			Usuario usu = UsuarioDAO.comprobarUsuario(login, password);
			if (usu!=null) {
				// 1ª Forma				
				resultado.put("acceso", "1"); // Correcto
				resultado.put("idUsuario", usu.getIdUsuario());
				resultado.put("login", usu.getLogin());
				resultado.put("password", usu.getPassword());
				resultado.put("nombre", usu.getNombre());
				resultado.put("tipo", usu.getTipo());
				
				// 2ª Forma
				// Hacer un return del usuario, recuperarlo como objeto json y comprobar si viene vación en Android
			} else {
				resultado.put("acceso", "0"); // Incorrecto
			}
		} catch (JSONException e) {
			e.printStackTrace();
		}
		
		return resultado.toString();
	}
	
	

}
