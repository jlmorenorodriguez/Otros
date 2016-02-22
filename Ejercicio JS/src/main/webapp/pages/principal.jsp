<%@page import="es.altair.bean.Usuario"%>
<html>
<meta charset="ISO-8859-1">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<title>Principal Usuario</title>
<link href="../css/bootstrap.min.css" rel="stylesheet">
<link href="../css/estilos.css" rel="stylesheet">
<link rel="shortcut icon" href="../images/favicon.ico">
<body>
	<%
		if (session.getAttribute("usuLogeado") == null || session.isNew()) {
			response.sendRedirect("../index.jsp");
		} else {
	%>
	<div class="container">
		<div class="row">
			<ul class="breadcrumb">
				<li class="completed"><a href="../index.jsp">Página Principal</a></li>
				<li class="active"><a href="#">Principal Usuario</a></li>
			</ul>
		</div>
		<div class="row">
			<div class="col-lg-3">
				Bienvenido,
				<%=((Usuario) session.getAttribute("usuLogeado")).getLogin()%>
			</div>
			
		</div>

	</div>

	<script src="https://code.jquery.com/jquery.js"></script>
	<script src="../js/bootstrap.min.js"></script>

	<%
		}
	%>
</body>
</html>