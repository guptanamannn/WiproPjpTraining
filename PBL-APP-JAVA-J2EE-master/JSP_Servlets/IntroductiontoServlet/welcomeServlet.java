package com.wipro.welcome;
import java.io.*;
import javax.servlet.http.*;
import javax.servlet.*;
public class welcomeServlet extends HttpServlet{
	public void service(HttpServletRequest req,HttpServletResponse res) throws IOException {
		res.setContentType("text/html");
		PrintWriter pw = res.getWriter();
		pw.println("<html>");
		pw.println("<title>Welcome</title>");
		pw.println("<h1>");
		pw.println("My First Servlet Program");
		pw.println("</h1>");
		pw.println("</body>");
		pw.println("</html>");
		pw.close();
	}
}
