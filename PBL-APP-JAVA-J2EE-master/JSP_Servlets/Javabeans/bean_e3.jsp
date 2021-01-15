<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Insert title here</title>
</head>
<body>
<jsp:useBean id="emp" class="com.wipro.jsp_bean.emp" />
<jsp:setProperty name="emp" property="*"/>
Emp Name: <jsp:getProperty name="emp" property="name" /> <br>
Emp Id: <jsp:getProperty name="emp" property="id" /><br>
Emp Destination: <jsp:getProperty name="emp" property="destination" /> <br>
<form action="show_table" method="post">
<input type="hidden" name="name" value='<%= request.getParameter("name")%>'>
<input type="hidden" name="id" value='<%= request.getParameter("id")%>'>
<input type="hidden" name="destination" value='<%= request.getParameter("destination")%>'>
<input type="submit" value="Add to Table">
</form>
</body>
</html>