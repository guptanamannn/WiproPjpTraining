package com.wipro.cookie;
import java.io.*;
import java.util.*;
import javax.servlet.*;
import javax.servlet.http.*;
public class E2 extends HttpServlet{
	public void doPost(HttpServletRequest req, HttpServletResponse res)throws IOException, ServletException{
		res.setContentType("text/html");
		PrintWriter og = res.getWriter();
		String name = req.getParameter("userName");
		Cookie cookie = new Cookie(name,name);
		res.addCookie(cookie);
		Cookie cookies[] = req.getCookies();
		if(cookies.length>=1) {
			og.println("<table>");
			for(Cookie c:cookies) {
				String n = c.getName();
				String v = c.getValue();
				og.println("<tr><td>n</td><td>v</td></tr>");
			}
			og.println("</table>");
		}else {
			og.println("No Cookies.");
		}
	}
}
