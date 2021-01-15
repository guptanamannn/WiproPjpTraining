<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
<head>
<meta charset="ISO-8859-1">
<title>Insert title here</title>
<style type="text/css">
.table{
width:20%;
max-width:20%;
}
</style>
</head>

<body>
<h2>Factorial of given number</h2>
<table class="table table-stripped">
<tr>
<th>Number</th>
<th>Factorial</th>
</tr>
<tr>
<td>
<%
int num = (Integer)request.getAttribute("name");
out.println(num);
%>
</td>
<td>
<%
int fact = (Integer)request.getAttribute("fact");
out.println(fact);
%>
</td>
</tr>
</table>
</body>
</html>