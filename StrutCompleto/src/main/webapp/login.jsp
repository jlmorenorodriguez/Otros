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

<s:form action="login" method="post">
<s:textfield name="usuario.username" placeholder="Usuario"></s:textfield>
<s:textfield name="usuario.password" placeholder="Contraseņa"></s:textfield>
<s:submit value="LOGIN"></s:submit>
</s:form>

</body>
</html>