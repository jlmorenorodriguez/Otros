<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<%@ taglib prefix="s" uri="/struts-tags"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Listado Clientes</title>
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<link rel="icon" href="images/favicon.ico" type="image/png" />
<link rel="shortcut icon" href="images/favicon.ico" />
<link href="css/bootstrap.min.css" rel="stylesheet">
<link href="css/estilos.css" rel="stylesheet">
</head>
<body>
	<div class="container">
		<br>
		<div class="row">
			<div class="span5">
				<table class="table table-striped table-condensed">
					<thead>
						<tr>
							<th>Código</th>
							<th>Nombre</th>
							<th>Dirección</th>
							<th>Población</th>
							<th>Jerarquía</th>
						</tr>
					</thead>
					<tbody>
						<s:iterator value="clientes">
							<tr>
								<td><s:property value="codigo" /></td>
								<td>
								<s:url action="seleccionCliente" id="seleccionURL">
										<s:param name="idCliente" value="%{idCliente}"></s:param>
									</s:url> <s:a href="%{seleccionURL}" class="btn btn-info btn-xs">
										<s:property value="nombre" />
									</s:a>
								</td>
								<td><s:property value="direccion" /></td>
								<td><s:property value="poblacion" /></td>
								<td><s:property value="jerarquia" /></td>
							</tr>
						</s:iterator>
					</tbody>
				</table>
			</div>
		</div>
	</div>

	<!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
	<script src="https://code.jquery.com/jquery.js"></script>
	<!-- Include all compiled plugins (below), or include individual files as needed -->
	<script src="js/bootstrap.min.js"></script>
</body>
</html>