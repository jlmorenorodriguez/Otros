<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<%@ taglib prefix="s" uri="/struts-tags"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Examen</title>
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<link rel="icon" href="images/favicon.ico" type="image/png" />
<link rel="shortcut icon" href="images/favicon.ico" />
<link href="css/bootstrap.min.css" rel="stylesheet">
<link href="css/estilos.css" rel="stylesheet">
</head>
<body>
	<div class="container">
		<div id="fullscreen_bg" class="fullscreen_bg" />

		<div class="container">

			<form class="form-signin" action="Validar" method="post">
				<h1 class="form-signin-heading text-muted">Sign In</h1>
				<s:textfield name="codigo" placeholder="Codigo"></s:textfield>

				<s:submit value="login" class="btn btn-succes"></s:submit>
			</form>
			<s:if test="hasActionErrors()">
			<div class="alert alert-danger">
				<a class="close" data-dimiss="alert" href="#">x</a>
				<s:actionerror/>
			</div>
		</s:if>
		</div>
	</div>


	<!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
	<script src="https://code.jquery.com/jquery.js"></script>
	<!-- Include all compiled plugins (below), or include individual files as needed -->
	<script src="js/bootstrap.min.js"></script>
</body>
</html>