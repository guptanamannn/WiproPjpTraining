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
if(session.getAttribute("uname")==null){
	response.sendRedirect("Login.jsp");
}
%>
		<div>
		<h3>
			Change Password
		</h3>
		<form method="post" name="myForm" onsubmit="return validf()" action="main">
			<table>
			<tr>
			<td>
			Old PassWord:</td>
			<td>
			<input type="password" name="oldPass"></td>
			<td>
			<span id="oldpass"></span></td>
			</tr>
			<tr>
			<td>
			New PassWord:</td><td><input type="password" name="newPass"></td><td><span id="newpass"></span></td></tr></table>
			Retype PassWord:</td><td><input type="password" name="retPass"></td><td><span id="retpass"></span></td></tr></table>
			<input type="hidden" name="jsppages" value="changepass">
			<input type="hidden" name="name" value='<%= session.getAttribute("uname")%>'>
			<input type="submit" value="Submit">
		</form>
	</div>
	<script type="text/javascript">
		function validf(){
			var pp1 = document.forms["myForm"]["oldPass"].value;
			document.getElementById("oldpass").innerHTML = "";
			var reg1= /^(?=.*[0-9])(?=.*[A=Z]).{6,}$/;
			if(!reg1.test(pp1)){
				document.getElementById("oldpass").innerHTML = "Password is not Valid";
				return false;
			}
			var pp2 = document.forms["myForm"]["newPass"].value;
			document.getElementById("newpass").innerHTML = "";
			var reg2= /^(?=.*[0-9])(?=.*[A=Z]).{6,}$/;
			if(!reg2.test(pp2)){
				document.getElementById("newpass").innerHTML = "Password is not Valid";
				return false;
			}
			var pp3 = document.forms["myForm"]["retPass"].value;
			document.getElementById("retpass").innerHTML = "";
			var reg= /^(?=.*[0-9])(?=.*[A=Z]).{6,}$/;
			if(!reg.test(pp3)){
				document.getElementById("retpass").innerHTML = "Password is not Valid";
				return false;
			}
			if(pp3!=pp2){
				document.getElementById("retpass").innerHTML = "Password doesn't match";
				return false;
			}
			
			return true;
		}
	</script>
	</body>
</html>