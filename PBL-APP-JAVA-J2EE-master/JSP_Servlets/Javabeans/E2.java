package com.wipro.jsp_bean;
import java.util.*;
import java.io.*;
import javax.servlet.http.*;
import javax.servlet.*;
public class E2 extends HttpServlet{
	public void service(HttpServletRequest req,HttpServletResponse res)throws IOException,ServletException {
		int n = Integer.parseInt(req.getParameter("num"));
		req.setAttribute("num", n);
		if(n<10) {
			RequestDispatcher reqD1 = req.getRequestDispatcher("page1.jsp");
			reqD1.forward(req, res);
		}
		else if(n>10 && n<99) {
			RequestDispatcher reqD2 = req.getRequestDispatcher("page2.jsp");
			reqD2.forward(req, res);
		}else {
			RequestDispatcher reqD3 = req.getRequestDispatcher("error.jsp");
			reqD3.forward(req, res);
		}
		
	}
}
