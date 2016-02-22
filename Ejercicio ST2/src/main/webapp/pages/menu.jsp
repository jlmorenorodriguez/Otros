<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<%@ taglib prefix="s" uri="/struts-tags"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Menu</title>
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<link rel="icon" href="images/favicon.ico" type="image/png" />
<link rel="shortcut icon" href="images/favicon.ico" />
<link href="css/bootstrap.min.css" rel="stylesheet">
<link href="css/estilos.css" rel="stylesheet">
</head>
<body>
	<div class="container">
		<div class="row">
			Bienvenido,
			<s:property value="#session['usulogeado'].nombre" />
			<a href="cerrarSesion" class="btn btn-info btn-xs">Cerrar Sesión</a>
			<hr class="hr-primary">
		</div>
		<br>
		<div class="row">
			<div class="col-lg-12">
				<p>
					<a href="VerProductos" class="btn btn-primary">VER PRODUCTOS</a>
				</p>
				<p>
					<a href="VerClientes" class="btn btn-primary">REALIZAR PEDIDO</a>
				</p>
				<p>
					<a href="VerPedidos" class="btn btn-primary">VER PEDIDOS</a>
				</p>
			</div>
		</div>
	</div>
	<h4></h4>

	<!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
	<script src="https://code.jquery.com/jquery.js"></script>
	<!-- Include all compiled plugins (below), or include individual files as needed -->
	<script src="js/bootstrap.min.js"></script>
</body>
</html>