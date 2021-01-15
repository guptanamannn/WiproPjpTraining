package com.wipro.jsp_servlet;

import java.io.IOException;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class E2
 */
@WebServlet("/E2")
public class E2 extends HttpServlet {
	public int fact(int n) {
		if(n==0||n==1) {
			return 1;
		}
		return n*fact(n-1);
	}
	public void doPost(HttpServletRequest req, HttpServletResponse res) throws ServletException, IOException {
		int n = Integer.parseInt(req.getParameter("name"));
		int r = fact(n);
		RequestDispatcher requestDispatcher = req.getRequestDispatcher("BSP_E3.jsp");
		req.setAttribute("name", n);
		req.setAttribute("fact", r);
		requestDispatcher.forward(req,res);
	}

}
