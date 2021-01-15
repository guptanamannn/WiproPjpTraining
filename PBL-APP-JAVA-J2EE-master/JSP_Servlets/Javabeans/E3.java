package com.wipro.jsp_bean;
import java.util.*;
import java.io.*;
import javax.servlet.http.*;
import javax.servlet.*;
import java.sql.*;
public class E3 extends HttpServlet{
	public void doPost(HttpServletRequest req,HttpServletResponse res)throws IOException,ServletException {
		PrintWriter out = res.getWriter();
		res.setContentType("text/html");
		out.println("<h2>Emp Table</h2>");
		Connection conn = null;
        Statement stmt = null;
        CallableStatement cstmt = null;
        try {
            Class.forName("oracle.jdbc.driver.OracleDriver");
            conn = DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521/orclpdb", "hr", "hr");
            System.out.println("Connected");
        }
        catch (ClassNotFoundException e) {
            e.printStackTrace();
            System.out.println("Driver Error");
        }
        catch (SQLException e2) {
            e2.printStackTrace();
        }
        String name = (String)req.getParameter("name");
        String id = (String)req.getParameter("id");
        String destination = (String)req.getParameter("destination");
        String sql = "INSERT INTO EMP values(?,?,?)";
        String sql2 = "SELECT * FROM EMP";
        try {
        	PreparedStatement preparedStmt = conn.prepareStatement(sql);
            preparedStmt.setInt(1, Integer.parseInt(id));
            preparedStmt.setString(2, name);
            preparedStmt.setString(3, destination);
            preparedStmt.execute();
            ResultSet rs = preparedStmt.executeQuery(sql2);
            out.println("<table><tr><th>Name</th><th>Id</th><th>Destination</th></tr>");
            while(rs.next()) {
            	String n = rs.getString("name1");
                int i = rs.getInt("id1");
                String d = rs.getString("destination");
            	out.println("<tr>");
            	out.println("<td>");
            	out.println(n);
            	out.println("</td>");
            	out.println("<td>");
            	out.println(i);
            	out.println("</td>");
            	out.println("<td>");
            	out.println(d);
            	out.println("</td>");
            	out.println("</tr>");
            }
            out.println("</table><br><br><form action='bean_e3.html'><input type='submit' value='Add Again'></form>");
        }
        catch (SQLException e3) {
            e3.printStackTrace();
            System.out.println("Error");
        }
	}
}
