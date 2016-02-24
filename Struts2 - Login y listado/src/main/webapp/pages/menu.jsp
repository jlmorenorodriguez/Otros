<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
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
	<div class="container">
		<div class="row">
			<s:property value="#session['clilogueado'].nombre"/>
		</div>
		<div class="row">
			<p>
				<a href="VerAnimales" class="btn btn-primary">Ver Animales</a>
			</p>
		</div>
	</div>
</body>
</html>