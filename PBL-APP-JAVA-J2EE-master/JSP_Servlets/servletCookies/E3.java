package com.wipro.cookie;
import java.io.*;
import java.util.*;
import javax.servlet.*;
import javax.servlet.http.*;
public class E3 extends HttpServlet{
	public void doPost(HttpServletRequest req, HttpServletResponse res)throws IOException, ServletException{
		res.setContentType("text/html");
		PrintWriter og = res.getWriter();
		String name = req.getParameter("userName");
		HttpSession session = req.getSession(true);
		int v =0;
		String vc = "";
		String n = name;
		if(session.isNew()) {
			v=1;
			og.println(" Welcome, you are visting for the first time.");
			session.setAttribute(name, String.valueOf(v));
		}else {
			Enumeration<String> ob = session.getAttributeNames();
			while(ob.hasMoreElements()) {
				if(name.equals(ob.nextElement())) {
					v = Integer.parseInt((String)session.getAttribute(name));
					v+=1;
					session.setAttribute(name, String.valueOf(v));
					og.println("User: "+name+" Visted "+v+" times.");
					vc="filled";
					break;
				}
			}
			if(vc.length()==0) {
				og.println("Welcome, you are visting for the first time.");
				session.setAttribute(name, String.valueOf(v));
			}
		}
	}
}
