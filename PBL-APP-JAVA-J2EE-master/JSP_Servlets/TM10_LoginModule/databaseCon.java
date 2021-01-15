import java.io.*;
import java.sql.*;
import javax.servlet.http.*;
import javax.servlet.*;
import java.util.*;

public class databaseCon extends HttpServlet{
	public void doPost(HttpServletRequest req,HttpServletResponse res) throws IOException,ServletException{
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
        String jsppages = (String)req.getParameter("jsppages");
        if(jsppages.equals("login")) {
        	String sql = "select * from logind where userNamee=?";
        	try {
        		PreparedStatement preparedStmt = conn.prepareStatement(sql);
                preparedStmt.setString(1, (String)req.getParameter("userName"));
                ResultSet rs = preparedStmt.executeQuery();
                if(rs.next()==false) {
                	RequestDispatcher reqd = req.getRequestDispatcher("login.jsp");
                	req.setAttribute("error","Wrong username/password");
            		reqd.forward(req,res);
                }else {
                	RequestDispatcher reqd = req.getRequestDispatcher("home.html");
            		reqd.forward(req,res);
                }
        	}
        	catch (SQLException e3) {
                e3.printStackTrace();
                System.out.println("Error");
            }
        }
        else if(jsppages.equals("changepass")) {
        	String sql = "update logind set passWordd = ? where userNamee=?";
        	try {
        		PreparedStatement preparedStmt = conn.prepareStatement(sql);
                preparedStmt.setString(1, (String)req.getParameter("OldNewpass"));
                preparedStmt.setString(2, (String)req.getParameter("OlduserName"));
                preparedStmt.executeUpdate();
                req.setAttribute("error","Password changed Successfully!!!");
                RequestDispatcher reqd = req.getRequestDispatcher("login.jsp");
        		reqd.forward(req,res);
                
        	}
        	catch (SQLException e3) {
                e3.printStackTrace();
                System.out.println("Error");
            }
        }
        else {
        	String sql = "insert into logind values(?,?)";
        	String sql1 = "select * from logind where userNamee=?";
        	try {
        		PreparedStatement preparedStmt = conn.prepareStatement(sql1);
                preparedStmt.setString(1, (String)req.getParameter("NewuserName"));
                ResultSet rs = preparedStmt.executeQuery();
        		if(rs.next()==false) {
        			preparedStmt = conn.prepareStatement(sql);
                    preparedStmt.setString(1, (String)req.getParameter("NewuserName"));
                    preparedStmt.setString(2, (String)req.getParameter("NewUserpass"));
                    preparedStmt.executeUpdate();
                    RequestDispatcher reqd = req.getRequestDispatcher("login.jsp");
                    req.setAttribute("error","Registration Completed!!!");
                    reqd.forward(req,res);
        		}
        		else {
        			RequestDispatcher reqd = req.getRequestDispatcher("newUser.jsp");
                    req.setAttribute("error","User Name Already Used");
                    reqd.forward(req,res);
        		}
                
        	}
        	catch (SQLException e3) {
                e3.printStackTrace();
                System.out.println("Error");
            }
        }
        
	}
	public void doGet(HttpServletRequest req,HttpServletResponse res) throws IOException,ServletException{
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
        String jsppages = (String)req.getParameter("jsppages");
        if(jsppages.equals("login")) {
        	String sql = "select * from logind where userNamee=?";
        	try {
        		PreparedStatement preparedStmt = conn.prepareStatement(sql);
                preparedStmt.setString(1, (String)req.getParameter("userName"));
                ResultSet rs = preparedStmt.executeQuery();
                if(rs.next()==false) {
                	RequestDispatcher reqd = req.getRequestDispatcher("login.jsp");
                	req.setAttribute("error","Wrong username/password");
            		reqd.forward(req,res);
                }else {
                	RequestDispatcher reqd = req.getRequestDispatcher("home.html");
            		reqd.forward(req,res);
                }
        	}
        	catch (SQLException e3) {
                e3.printStackTrace();
                System.out.println("Error");
            }
        }
        else if(jsppages.equals("changepass")) {
        	String sql = "update logind set passWordd = ? where userNamee=?";
        	try {
        		PreparedStatement preparedStmt = conn.prepareStatement(sql);
                preparedStmt.setString(1, (String)req.getParameter("OldNewpass"));
                preparedStmt.setString(2, (String)req.getParameter("OlduserName"));
                preparedStmt.executeUpdate();
                req.setAttribute("error","Password changed Successfully!!!");
                RequestDispatcher reqd = req.getRequestDispatcher("login.jsp");
        		reqd.forward(req,res);
                
        	}
        	catch (SQLException e3) {
                e3.printStackTrace();
                System.out.println("Error");
            }
        }
        else {
        	String sql = "insert into logind values(?,?)";
        	String sql1 = "select * from logind where userNamee=?";
        	try {
        		PreparedStatement preparedStmt = conn.prepareStatement(sql1);
                preparedStmt.setString(1, (String)req.getParameter("NewuserName"));
                ResultSet rs = preparedStmt.executeQuery();
        		if(rs.next()==false) {
        			preparedStmt = conn.prepareStatement(sql);
                    preparedStmt.setString(1, (String)req.getParameter("NewuserName"));
                    preparedStmt.setString(2, (String)req.getParameter("NewUserpass"));
                    preparedStmt.executeUpdate();
                    RequestDispatcher reqd = req.getRequestDispatcher("login.jsp");
                    req.setAttribute("error","Registration Completed!!!");
                    reqd.forward(req,res);
        		}
        		else {
        			RequestDispatcher reqd = req.getRequestDispatcher("newUser.jsp");
                    req.setAttribute("error","User Name Already Used");
                    reqd.forward(req,res);
        		}
                
        	}
        	catch (SQLException e3) {
                e3.printStackTrace();
                System.out.println("Error");
            }
        }
	}
}
