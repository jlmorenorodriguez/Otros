<%@page import="es.altair.bean.Instrumento"%>
<%@page import="es.altair.dao.InstrumentoDAO"%>
<%@page import="es.altair.bean.Usuario"%>
<html>
<meta charset="ISO-8859-1">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<title>Editar Instrumento</title>

<link href="../css/bootstrap.min.css" rel="stylesheet">
<link href="../css/estilos.css" rel="stylesheet">
<link rel="shortcut icon" href="../images/favicon.ico">
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
	<div class="container">
		<%
			if (session.getAttribute("usuLogeado") == null || session.isNew()) {
				response.sendRedirect("../index.jsp");
			} else {
		%>
		<div class="row">
			<ul class="breadcrumb">
				<li class="completed"><a href="../index.jsp">Página
						Principal</a></li>
				<li class="completed"><a href="principalAdmin.jsp">Principal
						Administrador</a></li>
				<li class="active"><a href="#">Editar Instrumento</a></li>
				<li class="completed"><a href="../CerrarSesion">Cerrar
						Sesion</a></li>
			</ul>
		</div>

		<%
			/* Libro lib = LibroDAO.obtenerLibroPorId(Integer.parseInt(request.getParameter("idLibro"))); */
				Instrumento ins = InstrumentoDAO.obtenerInstrumentoPorUUID(request.getParameter("encrypt"));

		%>
				<div class="container">
				    <div class="row ">
				    	<div class="col-md-4 col-md-offset-4">
				    		<div class="panel panel-default">
							  	<div class="panel-heading">
							    	<h3 class="panel-title">Editar instrumento</h3>
							 	</div>
							  	<div class="panel-body">
							    	 <form action="../EditarInstrumento" method="post" role="form"
											enctype="multipart/form-data">
											<input type="hidden" name="encrypt" id="encrypt" value="<%=ins.getUuid()%>">
											<input type="text" class="form-control" id="nombre" name="nombre" placeholder="Nombre" required value="<%=ins.getNombre()%>"> 
											<input type="number" class="form-control" id="precio" name="precio" placeholder="Precio" required value="<%=ins.getPrecio()%>"> 
											<input type="text" class="form-control" id="marca" name="marca" placeholder="Marca" required value="<%=ins.getMarca()%>"> 
											<input type="text" class="form-control" id="modelo" name="modelo" placeholder="Modelo" required value="<%=ins.getModelo()%>"> 
											<input type="text" class="form-control" id="referencia" name="referencia" placeholder="Referencia" required value="<%=ins.getReferencia()%>"> 
											<img   alt="imagen" class="img-responsive img-rounded" src="image.jsp?imag=<%=ins.getIdInstrumento()%>" />
											<input type="file" class="form-control" id="imagen" name="imagen" placeholder="Imagen">											
											<input type="submit" name="login" class="btn btn-primary pull-right login loginmodal-submit" value="Editar">
										</form>
			 
							    </div>
							</div>
						</div>
					</div>
				</div> 
			 
		<%
			}
		%>
	</div>

	<script src="https://code.jquery.com/jquery.js"></script>
	<script src="../js/bootstrap.min.js"></script>
	<script src="http://mymaplist.com/js/vendor/TweenLite.min.js"></script>
</body>
</html>
