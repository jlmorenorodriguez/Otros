<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    <%@taglib prefix="s" uri="/struts-tags"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
</head>
<body>

<s:form action="add" method="post">
	<s:hidden name="producto.idProducto" />
	<s:textfield name="producto.nombre" placeholder="Nombre"/>
	<s:textfield name="producto.precio" placeholder="Precio"/>
	<s:textfield autofocus="" name="producto.descripcion" placeholder="Descripción"/>
	<s:textfield autofocus="" name="producto.tipo" placeholder="Tipo"/>
	<s:submit value="Añadir/Editar"/>
</s:form>

<br></br>
<br></br>
<br></br>
					<table>
						<thead>
							<tr>
								<th>Id</th>
								<th>Nombre</th>
								<th>Precio</th>
								<th>Descripción</th>
								<th>Tipo</th>
								<th>Eliminar</th>
							</tr>
						</thead>
						<tbody>
							<s:iterator value="productoLista">
								<tr>
									<td><s:property value="idProducto" /></td>
									<td><s:property value="nombre" /></td>
									<td><s:property value="precio" /></td>
									<td><s:property value="descripcion" /></td>
									<td><s:property value="tipo" /></td>
									<td><a href="borrarProducto?idProducto=<s:property value="idProducto"/>">Borrar</a></td>
									<td><s:url id="url" action="edit"><s:param name="idProducto" value="%{idProducto}"></s:param>
									</s:url> <s:a href="%{url}">Editar</s:a>
								</tr>
							</s:iterator>
						</tbody>
					</table>

</body>
</html>