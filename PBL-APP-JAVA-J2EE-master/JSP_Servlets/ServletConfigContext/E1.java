package com.wipro.scsc;
import java.io.*;
import java.util.*;
import javax.servlet.http.*;
import javax.servlet.*;

public class E1 extends HttpServlet{
	String homeName;
	String email;
	ServletConfig config;
	ServletContext context;
	public void init() {
		config = getServletConfig();
		context = getServletContext();
		email = context.getInitParameter("email");
		homeName = config.getInitParameter("homeName");
	}
	public void doPost(HttpServletRequest req,HttpServletResponse res)throws IOException,ServletException{
		res.setContentType("text/html");
		PrintWriter og = res.getWriter();
		og.println("<h2>Result</h2>");
		og.println("<b>Servlet Config : </b>"+homeName+"<br>");
		og.println("<b>Servlet Context : </b>"+email+"<br>");
		og.println("<hr>Hello! "+req.getParameter("name"));
	}
}