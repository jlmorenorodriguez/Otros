<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<%@ taglib prefix="s" uri="/struts-tags"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Editar Producto</title>
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<link rel="icon" href="images/favicon.ico" type="image/png" />
<link rel="shortcut icon" href="images/favicon.ico" />
<link href="css/bootstrap.min.css" rel="stylesheet">
<link href="css/estilos.css" rel="stylesheet">
</head>
<body>
	<div class="container">
		<div class="row">
			<h2>Editar Producto</h2>
			<s:form action="editarProductoDef" method="post" role="form">
				<s:push value="producto">
					<s:hidden name="idProducto"/>
					<s:label class="control-label" value="Familia"></s:label>
					<s:textfield name="familia" class="form-control" required=""
						autofocus="" placeholder="" />
					<s:label class="control-label" value="Nombre"></s:label>
					<s:textfield name="nombre" class="form-control" required=""
						placeholder="" />
					<s:label class="control-label" value="Código SAP"></s:label>
					<s:textfield name="codigosap" class="form-control" required=""
						placeholder="" />
					<s:label class="control-label" value="ltkg"></s:label>
					<s:textfield name="ltkg" class="form-control" required=""
						placeholder="" />
					<s:label class="control-label" value="Caja"></s:label>
					<s:textfield name="caja" class="form-control" required=""
						placeholder="" />
					<s:label class="control-label" value="Tarifa"></s:label>
					<s:textfield name="tarifa" class="form-control" required=""
						placeholder="" />
					<s:label class="control-label" value="Unidades"></s:label>
					<s:textfield name="unidades" class="form-control" required=""
						placeholder="" />

					<s:submit class="btn btn-primary" value="Enviar" />

				</s:push>
			</s:form>
		</div>
	</div>

	<!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
	<script src="https://code.jquery.com/jquery.js"></script>
	<!-- Include all compiled plugins (below), or include individual files as needed -->
	<script src="js/bootstrap.min.js"></script>
</body>
</html>