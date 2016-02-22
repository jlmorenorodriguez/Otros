<html>
<meta charset="UTF-8"><title>Web DWC</title>

<link href="css/bootstrap.min.css" rel="stylesheet">
<link href="css/bootstrap.css" rel="stylesheet">
<link href="css/general.css" rel="stylesheet">
<link rel="shortcut icon" href="images/favicon.ico">
<style>
body{
    background: url(http://mymaplist.com/img/parallax/back.png);
	background-color: #444;
    background: url(http://mymaplist.com/img/parallax/pinlayer2.png),url(http://mymaplist.com/img/parallax/pinlayer1.png),url(http://mymaplist.com/img/parallax/back.png);    
}

.vertical-offset-100{
    padding-top:100px;
}


</style>
<body>

	 <div class="container">
        <div class="card card-container">
            <img id="profile-img" class="profile-img-card" src="http://1.bp.blogspot.com/-wsziZyJV3h0/UKVrUeVsK8I/AAAAAAAAAcA/vTDSGITbcm4/s1600/tuba.jpg" />
            <p id="profile-name" class="profile-name-card"></p>
            <form class="form-signin loginmodal-container" action="ValidarUsuario" method="post">
                

                <input type="text" id="userName" name="userName" class="form-control input-sm chat-input" placeholder="Usuario" autofocus="true" required="required" /> 
                </br> 
                <input type="password" id="userPassword" name="userPassword" class="form-control input-sm chat-input" placeholder="Contraseña" required="required" /> 
                </br>
               
                <input type="submit"
								class="btn btn-lg btn-primary btn-block btn-signin" value="Iniciar sesión"><i
								class="fa fa-sign-in"></i>
            </form><!-- /form -->
            <div class="etc-login-form">
				
				<p>¿nuevo usuario? <a href="#" data-target="#login-modal" data-toggle="modal">cree una nueva cuenta</a></p>
				<div class="modal fade" id="login-modal" tabindex="-1" role="dialog"
				aria-labelledby="myModalLabel" aria-hidden="true"
				style="display: none;">
				<div class="modal-dialog">
					<div class="loginmodal-container">
						<h1>Registro usuario</h1>
						<br>
						<form action="AnadirUsuarios" method="get"
							enctype="multipart/form-data">
							<input type="text" class="form-control" id="nombreRegistro" name="nombreRegistro" placeholder="Nombre" required>
							<input type="text" class="form-control" id="loginRegistro" name="loginRegistro" placeholder="Login" required>
							<input type="password" class="form-control" id="passRegistro" name="passRegistro" placeholder="Password" required>
							 <input type="submit"
								class="btn btn-lg btn-primary btn-block btn-signin" value="Registrar"><i
								class="fa fa-sign-in"></i>
						</form>

						
					</div>
				</div>
			</div>
			</div>
        </div><!-- /card-container -->
    </div><!-- /container -->
    	
		<%
			String error = request.getParameter("error");
			if (error != null) {
		%>
		<div class="row">
			<div class="col-md-offset-5 col-md-3">
				<span style="color: White; font-weight: bold;"><%=error %></span>
			</div>
		</div>
		<%
			}
		%>
	</div>

	<script src="https://code.jquery.com/jquery.js"></script>
	<script src="js/bootstrap.min.js"></script>
	<script type="text/javascript" href="css/general.js"></script>
		<script src="http://mymaplist.com/js/vendor/TweenLite.min.js"></script>
	
</body>
</html>
