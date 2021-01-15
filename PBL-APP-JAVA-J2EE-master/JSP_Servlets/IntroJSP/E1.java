package com.wipro.jsp_servlet;
import java.io.*;
import java.util.*;
import javax.servlet.http.*;
import javax.servlet.*;
public class E1 extends HttpServlet{
	public void doPost(HttpServletRequest req,HttpServletResponse res)throws IOException, ServletException {
		ArrayList<Integer> list = new ArrayList<>();
		int n = Integer.parseInt(req.getParameter("name"));
		int flag;
		for(int i =2;i<n;i++) {
			flag=0;
			for(int j =2;j<=i/2;j++) {
				if(i%j==0) {
					flag=1;
					break;
				}
			}
			if(flag==0) {
				list.add(i);
			}
		}
		RequestDispatcher requestDispatcher = req.getRequestDispatcher("BSP_E1.jsp");
		req.setAttribute("primeList",list);
		req.setAttribute("num", n);
		requestDispatcher.forward(req,res);
	}
}
