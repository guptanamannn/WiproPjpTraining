package com.wipro.cookie;
import java.io.*;
import java.util.*;
import javax.servlet.*;
import javax.servlet.http.*;
public class E1 extends HttpServlet{
	public void doPost(HttpServletRequest req, HttpServletResponse res)throws IOException, ServletException{
		res.setContentType("text/html");
		PrintWriter og = res.getWriter();
		
		String name = req.getParameter("userName");
		Cookie cookie = new Cookie(name,name);
		res.addCookie(cookie);
		Cookie cookies[] = req.getCookies();
		String resu="";
		if(cookies.length>=1) {
			for(Cookie c:cookies) {
				if(c.getName().equals(name)) {
					resu = name;
					break;
				}
			}
		}
		if(resu.length()!=0) {
			og.println("Welcome Back "+resu);
		}
		else {
			og.println("Welcome, you are visting for the first time.");
		}
		
	}
}
