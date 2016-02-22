<%@page import="es.altair.dao.InstrumentoDAO"%>
<%@page import="es.altair.bean.Instrumento"%>
<%@page import="java.util.ArrayList"%>
<%@page import="es.altair.bean.Usuario"%>
<html>
<meta charset="UTF-8"><title>Pagina principal Administrador</title>

<link href="../css/bootstrap.min.css" rel="stylesheet">
<link href="../css/estilos.css" rel="stylesheet">
<link rel="shortcut icon" href="../images/favicon.ico">



<script src="http://snipplicious.com/js/jquery.js"></script>
<script src="http://snipplicious.com/js/bootstrap.min.js"></script>
<style>
body{
    background: url(http://mymaplist.com/img/parallax/back.png);
	background-color: #444;
    background: url(http://mymaplist.com/img/parallax/pinlayer2.png),url(http://mymaplist.com/img/parallax/pinlayer1.png),url(http://mymaplist.com/img/parallax/back.png);    
}

.vertical-offset-100{
    padding-top:100px;
}


</style>
<body>
	<%
		if (session.getAttribute("usuLogeado") == null || session.isNew()) {
			response.sendRedirect("../index.jsp");
		} else {
			ArrayList<Instrumento> instrumentos = InstrumentoDAO.listarInstrumento();
	%>
	<div class="container">
		<div class="row">
			<ul class="breadcrumb">
				<li class="completed"><a href="../index.jsp">Pagina
						Principal</a></li>
				<li class="active"><a href="#">Principal Administrador</a></li>
				<li class="completed"><a href="../CerrarSesion">Cerrar
						Sesion</a></li>
			</ul>
		</div>
		<div class="row">
			<div class="col-lg-3">
				Bienvenido,
				<%=((Usuario) session.getAttribute("usuLogeado")).getNombre()%>
			</div>
		</div>
		<div class="panel panel-primary">
			<div class="panel-heading">Lista de Instrumentos</div>
			<div class="panel-body">
				<table class="table table-striped table-hover">
					<thead>
						<tr>
							<th>ID</th>
							<th colspan="2">Nombre</th>
							<th>Precio</th>
							<th>Marca</th>
							<th>Modelo</th>
							<th>Referencia</th>
							<th>Foto</th>
							<th>Usuario</th>
							<th></th>
							<th></th>
						</tr>
					</thead>
					<%
						for (Instrumento i : instrumentos) {
					%>
					<tbody>
						<tr>
							<td><%=i.getIdInstrumento()%></td>
							<td colspan="2"><%=i.getNombre()%></td>
							<td><%=i.getPrecio()%> euros</td>
							<td><%=i.getMarca()%></td>
							<td><%=i.getModelo()%></td>
							<td><%=i.getReferencia()%></td>
							<td><img alt="foto" class="img-thumbnail" width="50"
								height="50" src="image.jsp?imag=<%=i.getIdInstrumento()%>" /></td>
							<td><%=i.getUsuario().getNombre()%></td>
							<td>
							<% System.out.println(i.getUuid()); %>
							
							
							
						
							<a href="editarInstrumento.jsp?encrypt=<%=i.getUuid()%>"
														class='btn btn-info btn-xs'><span
															class="glyphicon glyphicon-edit"></span>Editar</a>
														
							
						


						
												
							<div id="myModal<%=i.getIdInstrumento() %>" class="modal fade-in">
								<div class="modal-dialog">
									<div class="modal-content">

										<div class="modal-header">
											<a class="btn btn-default" data-dismiss="modal"><span
												class="glyphicon glyphicon-remove"></span></a>
											<h4 class="modal-title">Borrado de instrumento</h4>
										</div>
										<div class="modal-body">
											
											<p>Desea borrar el instrumento <%=i.getNombre()%></p>
										</div>
										<div class="modal-footer">
											<div class="btn-group">
												<button class="btn btn-default" data-dismiss="modal">
													<span class="glyphicon glyphicon-remove"></span> Cancelar
												</button>
												
												<a href="../BorrarInstrumento?encrypt=<%=i.getUuid()%>"
													class="btn btn-danger"> <span
													class="glyphicon glyphicon-remove"></span> Borrar
												</a>	
											</div>
										</div>
									</div>
									<!-- /.modal-content -->
								</div>
								<!-- /.modal-dialog -->
							</div>
							<!-- /.modal --> 
							<a data-toggle="modal" href="#myModal<%=i.getIdInstrumento() %>"
							class="btn btn-danger btn-xs"><span
								class="glyphicon glyphicon-remove"></span> Borrar</a>	
										
							
										
							</td>
							
						</tr>
						<%
						}
					%>

					</tbody>
					</table>
					</div>
					</div>
					</div>

					<script src="https://code.jquery.com/jquery.js" type="text/javascript"></script>
					<script src="../js/bootstrap.min.js" type="text/javascript"></script>
	<script src="http://mymaplist.com/js/vendor/TweenLite.min.js"></script>

					<%
						}
					%>
				
</body>
</html>