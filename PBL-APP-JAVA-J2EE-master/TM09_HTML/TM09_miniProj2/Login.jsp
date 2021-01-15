<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
	<style type="text/css">
		div{
			width: 50%;

			

			margin: 0 auto;

			

			text-align: center;
		}
		input{
			margin-top:10px; 
		}
		table{
			margin:0 auto;
		}
		a{
			text-align:center;
			text-decoration:underline;
			color:blue;
		}
		#new{
		margin-top:20px;
		}
	</style>
	</head>
	<body>
	<%
		session.invalidate();
	%>
		<div>
		<h3>
			Login Page
		</h3>
		<p><% if(request.getAttribute("error")!=null){
			out.println(request.getAttribute("error"));
		}else{
			out.println("");
		} %></p><br>
		<form action="main" method="post" name="myForm" onsubmit="return validf()">
			<table><tr><td>
			Enter User Name:</td><td><input type="text" name="userName"></td><td><span id="errname"></span></td></tr><tr><td>
			Enter Pass Word:</td><td><input type="password" name="passw"></td><td><span id="errpass"></span></td></tr></table>
			<input type="hidden" name="jsppages" value="login">
			<input type="submit" value="Submit">
		</form>
		<div id="new">
		<a href="Registration">New User</a>
		</div>
	</div>
	</body>
	<script type="text/javascript">
		function validf(){
			<% request.setAttribute("error",null);%>
			var pp = document.forms["myForm"]["passw"].value;
			document.getElementById("errpass").innerHTML = "";
			var reg= /^(?=.*[0-9])(?=.*[A=Z]).{6,}$/;
			if(!reg.test(pp)){
				document.getElementById("errpass").innerHTML = "Password is not Valid";
				return false;
			}
			
			return true;
			
		}
	</script>
</html>