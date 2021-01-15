<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Insert title here</title>
<style type="text/css">
	tr{
		background-color: yellow;
	}
	table{
		border-collapse: collapse;
		margin :0 auto;
		margin-bottom: 20px;
	}
	table,th,td{
		border: 4px ridge yellow;
	}
</style>
</head>
<body>
<div style='background-color: yellow;    font-family: times new roman;
    margin: auto;
    width: 40%;
    text-align: center;
    padding: 10px;
}
'>
	<h1>Bid Submitted</h1>
	<p>Your bid is now active. If your bid is successful you will be notifed within 24 hours of the close of bidding.</p>
	<div style='text-align: center'>
		
			<table>
				<tr style="background-color: black;color:white;">
					<th>
						<%= request.getParameter("idname") %>
					</th>
				</tr>
				<tr>
					<td>Item ID: <%= request.getParameter("id") %> 
					</td>
				</tr>
				<tr>
					<td>Name: <%= request.getParameter("name") %>
					</td>
				</tr>
				<tr>
					<td>Email address: <%= request.getParameter("email") %>
					</td>
				</tr>
				<tr>
					<td>Bid Price: <%= request.getParameter("amount") %>
					</td>
				</tr>
				<tr>
					<td>Auto-increment price: <%= request.getParameter("bid") %>
					</td>
				</tr>
			</table>
	</div>
</div>
</body>
</html>