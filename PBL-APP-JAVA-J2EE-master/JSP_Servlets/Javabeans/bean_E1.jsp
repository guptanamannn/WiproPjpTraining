<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Insert title here</title>
</head>
<body>
<jsp:useBean id="emp" class="com.wipro.jsp_bean.employ" />
<jsp:setProperty name="emp" property="*"/>
Emp Name: <jsp:getProperty name="emp" property="name" /> <br>
Emp Id: <jsp:getProperty name="emp" property="id" /> 
</body>
</html>