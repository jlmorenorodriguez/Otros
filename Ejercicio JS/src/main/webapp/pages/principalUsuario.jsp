<%@page import="es.altair.dao.InstrumentoDAO"%>
<%@page import="es.altair.bean.Instrumento"%>
<%@page import="java.util.ArrayList"%>
<%@page import="es.altair.bean.Usuario"%>
<html>
<meta charset="UTF-8">
<title>Principal Usuario</title>
<style type="text/css">
 @import url(http://fonts.googleapis.com/css?family=Roboto);

/****** LOGIN MODAL ******/
.loginmodal-container {
  padding: 30px;
  max-width: 350px;
  width: 100% !important;
  background-color: #F7F7F7;
  margin: 0 auto;
  border-radius: 2px;
  box-shadow: 0px 2px 2px rgba(0, 0, 0, 0.3);
  overflow: hidden;
  font-family: roboto;
}

.loginmodal-container h1 {
  text-align: center;
  font-size: 1.8em;
  font-family: roboto;
}

.loginmodal-container input[type=submit] {
  width: 100%;
  display: block;
  margin-bottom: 10px;
  position: relative;
}

.loginmodal-container input[type=text], input[type=password] {
  height: 44px;
  font-size: 16px;
  width: 100%;
  margin-bottom: 10px;
  -webkit-appearance: none;
  background: #fff;
  border: 1px solid #d9d9d9;
  border-top: 1px solid #c0c0c0;
  /* border-radius: 2px; */
  padding: 0 8px;
  box-sizing: border-box;
  -moz-box-sizing: border-box;
}

.loginmodal-container input[type=text]:hover, input[type=password]:hover {
  border: 1px solid #b9b9b9;
  border-top: 1px solid #a0a0a0;
  -moz-box-shadow: inset 0 1px 2px rgba(0,0,0,0.1);
  -webkit-box-shadow: inset 0 1px 2px rgba(0,0,0,0.1);
  box-shadow: inset 0 1px 2px rgba(0,0,0,0.1);
}

.loginmodal {
  text-align: center;
  font-size: 14px;
  font-family: 'Arial', sans-serif;
  font-weight: 700;
  height: 36px;
  padding: 0 8px;
/* border-radius: 3px; */
/* -webkit-user-select: none;
  user-select: none; */
}

.loginmodal-submit {
  /* border: 1px solid #3079ed; */
  border: 0px;
  color: #fff;
  text-shadow: 0 1px rgba(0,0,0,0.1); 
  background-color: #4d90fe;
  padding: 17px 0px;
  font-family: roboto;
  font-size: 14px;
  /* background-image: -webkit-gradient(linear, 0 0, 0 100%,   from(#4d90fe), to(#4787ed)); */
}

.loginmodal-submit:hover {
  /* border: 1px solid #2f5bb7; */
  border: 0px;
  text-shadow: 0 1px rgba(0,0,0,0.3);
  background-color: #357ae8;
  /* background-image: -webkit-gradient(linear, 0 0, 0 100%,   from(#4d90fe), to(#357ae8)); */
}

.loginmodal-container a {
  text-decoration: none;
  color: #666;
  font-weight: 400;
  text-align: center;
  display: inline-block;
  opacity: 0.6;
  transition: opacity ease 0.5s;
} 

.login-help{
  font-size: 12px;
}

body{
    background: url(http://mymaplist.com/img/parallax/back.png);
	background-color: #444;
    background: url(http://mymaplist.com/img/parallax/pinlayer2.png),url(http://mymaplist.com/img/parallax/pinlayer1.png),url(http://mymaplist.com/img/parallax/back.png);    
}

.vertical-offset-100{
    padding-top:100px;
}
  </style>
<link href="../css/bootstrap.min.css" rel="stylesheet">
<link href="../css/estilos.css" rel="stylesheet">
<link rel="shortcut icon" href="../images/favicon.ico">
<body>
	<%
		if (session.getAttribute("usuLogeado") == null || session.isNew()) {
			response.sendRedirect("../index.jsp");
		} else {
			
			ArrayList<Instrumento> instrumentos = InstrumentoDAO.listarInstrumentoPorUsuario(((Usuario) session.getAttribute("usuLogeado")).getIdUsuario());
	%>
	<div class="container">
		<div class="row">
			<ul class="breadcrumb">
				<li class="completed"><a href="../index.jsp">Página
						Principal</a></li>
				<li class="active"><a href="#">Principal Usuario</a></li>
				<li class="completed"><a href="../CerrarSesion">Cerrar
						Sesion</a></li>
			</ul>
		</div>
		<div class="row">
			<div class="col-lg-3">
				Bienvenido,
				<%=((Usuario) session.getAttribute("usuLogeado")).getNombre()%>
			</div>
			<br>
			<br>
			<div class="col-lg-12 pull-right">
				<a href="#" data-toggle="modal"
					class="btn btn-lg btn-primary btn-block btn-signin bg-success"
					data-target="#login-modal">Añadir Instrumento</a>
			</div>

			<div class="modal fade" id="login-modal" tabindex="-1" role="dialog"
				aria-labelledby="myModalLabel" aria-hidden="true"
				style="display: none;">
				<div class="modal-dialog">
					<div class="loginmodal-container">
						<h1>Añadir instrumento</h1>
						<br>
						<form action="../AnadirInstrumento" method="post"
							enctype="multipart/form-data">
							<input type="text" class="form-control" id="nombre" name="nombre" placeholder="Nombre" required>
							<input type="number" class="form-control" id="precio" name="precio" placeholder="Precio" required>
							<input type="text" class="form-control" id="marca" name="marca" placeholder="Marca" required>
							<input type="text" class="form-control" id="modelo" name="modelo" placeholder="Modelo" required>
							<input type="text" class="form-control" id="referencia" name="referencia" placeholder="Referencia" required>
							<input type="file" class="form-control" id="imagen" name="imagen" placeholder="Imagen" required>
							<input type="submit" name="login" class="btn btn-primary pull-right login loginmodal-submit" value="Añadir">
						</form>

						
					</div>
				</div>
			</div>
			<div class="panel panel-primary">
			<div class="panel-heading">Lista de Instrumentos</div>
			<div class="panel-body">
			<!-- Lista de instrumentos -->
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
							
							
						</tr>
						<%
						}
					%>

					</tbody>
					</table>
			</div>
					</div>
					</div>
		</div>

	</div>

	<script src="https://code.jquery.com/jquery.js"></script>
	<script src="../js/bootstrap.min.js"></script>
		<script src="http://mymaplist.com/js/vendor/TweenLite.min.js"></script>

	<%
		}
	%>
</body>
</html>