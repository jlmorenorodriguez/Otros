<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<%@ taglib prefix="s" uri="/struts-tags"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Pedidos</title>
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<link rel="icon" href="images/favicon.ico" type="image/png" />
<link rel="shortcut icon" href="images/favicon.ico" />
<link href="css/bootstrap.min.css" rel="stylesheet">
<link href="css/estilos.css" rel="stylesheet">
</head>
<body>
	<div class="container">
		<div class="row center-block">
			<div class="span12">
				<form class="form-horizontal" action='menu' method="POST">
					<fieldset>
						<div id="legend">
							<legend class="">Login</legend>
						</div>
						<div class="control-group">
							<!-- Username -->
							<label class="control-label" for="username">Usuario</label>
							<div class="controls">
								<s:textfield name="user" placeholder="Usuario"
									autofocus="" class="input-xlarge" />
							</div>
						</div>
						<div class="control-group">
							<!-- Password-->
							<label class="control-label" for="password">Password</label>
							<div class="controls">
								<s:password name="pwd" placeholder="Password"
									autofocus="" class="input-xlarge" />
							</div>
						</div>
						<div class="control-group">
							<!-- Button -->
							<div class="controls">
								<s:submit value="Login" class="btn btn-success"/>
							</div>
						</div>
					</fieldset>
				</form>
				<s:if test="hasActionErrors()">
					<div class="alert alert-danger">
						<a class="close" data-dismiss="alert" href="#">x</a>
						<s:actionerror/>
					</div>
				</s:if>
			</div>
		</div>
	</div>

	<!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
	<script src="https://code.jquery.com/jquery.js"></script>
	<!-- Include all compiled plugins (below), or include individual files as needed -->
	<script src="js/bootstrap.min.js"></script>
</body>
</html>