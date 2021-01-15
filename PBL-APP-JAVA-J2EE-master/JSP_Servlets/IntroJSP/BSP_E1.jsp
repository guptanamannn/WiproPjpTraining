<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Insert title here</title>
</head>
<body>
<%@ page import="java.util.*" %>
<h2>Printing Prime Numbers < 
<% int n = (Integer)request.getAttribute("num");
out.println(n);
%></h2>
<%
ArrayList<Integer> list = new ArrayList<>();
list = (ArrayList<Integer>)request.getAttribute("primeList");
for(int i:list){
	out.println(i+"<br>");
}
%>
</body>
</html>