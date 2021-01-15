<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Insert title here</title>
<style type="text/css">
a{
text-decoration:"underline";
color:"blue";
}
div{
text-align:center;}
</style>
</head>
<body>
<%
if(session.getAttribute("uname")==null){
	response.sendRedirect("Login.jsp");
}
%>
</form>
<div>
Home Page
</div>
Welcome to <%= session.getAttribute("uname") %>
<a href="changePass">Change Password</a>
</body>
</html>