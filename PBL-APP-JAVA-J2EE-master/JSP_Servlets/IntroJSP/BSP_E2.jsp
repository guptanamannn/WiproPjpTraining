<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
    <head><title>JSPApp</title></head>
    <body>
                <h3>Current Date and Time is :</h3>
                <% java.util.Date d = new java.util.Date();
                out.println(d.toString()); %>
            
    </body>
</html>