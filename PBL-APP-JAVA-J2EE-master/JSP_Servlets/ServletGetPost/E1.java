package com.wipro.sgpg;
import java.io.*;
import java.util.*;
import javax.servlet.*;
import javax.servlet.http.*;
public class E1 extends HttpServlet{
	public void doPost(HttpServletRequest req,HttpServletResponse res)throws IOException,ServletException {
		res.setContentType("text/html");
		PrintWriter og = res.getWriter();
		og.println("<h2>All Headers with Values</h2>");
		Enumeration<String> e = req.getParameterNames();
		while(e.hasMoreElements()) {
			String n = (String)e.nextElement();
			String v = req.getParameter(n);
			og.println("<b>"+n+"</b> : "+v+"<br>");
		}
	}
	public void doGet(HttpServletRequest req,HttpServletResponse res)throws IOException,ServletException {
		res.setContentType("text/html");
		PrintWriter og = res.getWriter();
		og.println("<h2>All Headers with Values</h2>");
		Enumeration<String> e = req.getParameterNames();
		while(e.hasMoreElements()) {
			String n = (String)e.nextElement();
			String v = req.getParameter(n);
			og.println("<b>"+n+"</b> : "+v+"<br>");
		}
	}
}
