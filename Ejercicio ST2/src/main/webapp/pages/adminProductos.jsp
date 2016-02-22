<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<%@ taglib prefix="s" uri="/struts-tags"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Admin Productos</title>
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<link rel="icon" href="images/favicon.ico" type="image/png" />
<link rel="shortcut icon" href="images/favicon.ico" />
<link href="css/bootstrap.min.css" rel="stylesheet">
<link href="css/estilos.css" rel="stylesheet">
</head>
<body>
	<div class="container">
		<div class="row">
			<a href="anadirProducto" class="btn btn-primary">AÑADIR PRODUCTO</a>
		</div>
		<br>
		<div class="row">
			<div class="span5">
				<table class="table table-striped table-condensed">
					<thead>
						<tr>
							<th>Familia</th>
							<th>Nombre</th>
							<th>CodigoSAP</th>
							<th>ltkg</th>
							<th>Caja</th>
							<th>Tarifa</th>
							<th>Unidades</th>
							<th></th>
						</tr>
					</thead>
					<tbody>
						<s:iterator value="productos">
							<tr>
								<td><s:property value="familia" /></td>
								<td><s:property value="nombre" /></td>
								<td><s:property value="codigosap" /></td>
								<td><s:property value="ltkg" /></td>
								<td><s:property value="caja" /></td>
								<td><s:property value="tarifa" /></td>
								<td><s:property value="unidades" /></td>
								<td><s:url action="editarProducto" id="editarURL">
										<s:param name="idProducto" value="%{idProducto}"></s:param>
									</s:url> <s:a href="%{editarURL}" class="btn btn-info btn-xs">
										<span class="glyphicon glyphicon-edit"></span>
										Editar
									</s:a>

									<div id="myModal<s:property value="idProducto" />"
										class="modal fade in">
										<div class="modal-dialog">
											<div class="modal-content">

												<div class="modal-header">
													<a class="btn btn-default" data-dismiss="modal"><span
														class="glyphicon glyphicon-remove"></span></a>
													<h4 class="modal-title">Borrar</h4>
												</div>
												<div class="modal-body">
													<h4>Borrado de Producto</h4>
													<p>
														¿Desea borrar el Producto
														<s:property value="nombre" />
														?
													</p>
												</div>
												<div class="modal-footer">
													<div class="btn-group">
														<button class="btn btn-info" data-dismiss="modal">
															<span class="glyphicon glyphicon-remove"></span> Cancelar
														</button>
														<s:url action="borrarProducto" id="borrarURL">
															<s:param name="idProducto" value="%{idProducto}"></s:param>
														</s:url>
														<s:a href="%{borrarURL}" class="btn btn-danger">
															<span class="glyphicon glyphicon-check"></span>
															Borrar
														</s:a>
													</div>
												</div>

											</div>
											<!-- /.modal-content -->
										</div>
										<!-- /.modal-dalog -->
									</div> <!-- /.modal --> <a data-toggle="modal"
									href="#myModal<s:property value="idProducto" />"
									class="btn btn-danger btn-xs"><span
										class="glyphicon glyphicon-remove"></span>Borrar</a></td>
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