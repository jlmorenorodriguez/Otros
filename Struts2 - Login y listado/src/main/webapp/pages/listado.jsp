<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<%@ taglib prefix="s" uri="/struts-tags"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
<link rel="icon" href="../images/favicon.ico" type="image/png" />
<link rel="shortcut icon" href="../images/favicon.ico" />
<link href="../css/bootstrap.min.css" rel="stylesheet">
<link href="../css/estilos.css" rel="stylesheet">
</head>
<body>
	<div class="row col-md-6 col-md-offset-2 custyle">
		<table class="table table-striped custab">
			<thead>
				<a href="#" class="btn btn-primary btn-xs pull-right"><b>+</b>Añadir animal</a>
				<tr>
					<th>ID</th>
					<th>Nombre</th>
					<th>Nacimiento</th>
					<th>Identificacion</th>
					<th>Raza</th>
					<th>Color</th>

					<th class="text-center">Action</th>
				</tr>
			</thead>
			<s:iterator value="animales">
				<tr>

					<td><s:property value="id" /></td>
					<td><s:property value="nombre" /></td>
					<td><s:property value="nacimiento" /></td>
					<td><s:property value="identificacion" /></td>
					<td><s:property value="raza" /></td>
					<td><s:property value="color" /></td>

					<td class="text-center"><a class='btn btn-info btn-xs'
						href="#"><span class="glyphicon glyphicon-edit"></span> Editar</a>
						<a href="#" class="btn btn-danger btn-xs"><span
							class="glyphicon glyphicon-remove"></span> Borrar</a></td>
				</tr>
			</s:iterator>
		</table>
	</div>
</body>
</html>