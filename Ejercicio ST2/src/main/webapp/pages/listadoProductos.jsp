<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<%@ taglib prefix="s" uri="/struts-tags"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Listado Productos</title>
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
				<s:form action="seleccionProductos" method="post">
					<table class="table table-striped table-condensed">
						<thead>
							<tr>
								<th></th>
								<th>Familia</th>
								<th>Nombre</th>
								<th>CodigoSAP</th>
								<th>ltkg</th>
								<th>Caja</th>
								<th>Tarifa</th>
								<th>Unidades</th>
							</tr>
						</thead>
						<tbody>
							<s:iterator value="productos">
								<tr>
									<td><s:checkbox name="selectedId"
											fieldValue="%{idProducto}" theme="simple" /></td>
									<td><s:property value="familia" /></td>
									<td><s:property value="nombre" /></td>
									<td><s:property value="codigosap" /></td>
									<td><s:property value="ltkg" /></td>
									<td><s:property value="caja" /></td>
									<td><s:property value="tarifa" /></td>
									<td><s:property value="unidades" /></td>
								</tr>
							</s:iterator>
						</tbody>
					</table>
					<s:submit value="GENERAR PEDIDO" class="btn btn-primary"/>
				</s:form>
			</div>
		</div>
	</div>

	<!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
	<script src="https://code.jquery.com/jquery.js"></script>
	<!-- Include all compiled plugins (below), or include individual files as needed -->
	<script src="js/bootstrap.min.js"></script>
</body>
</html>