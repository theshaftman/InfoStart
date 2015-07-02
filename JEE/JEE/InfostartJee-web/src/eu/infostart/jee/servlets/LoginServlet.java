package eu.infostart.jee.servlets;

import java.io.IOException;
import java.io.PrintWriter;

import javax.ejb.EJB;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import eu.infostart.ejb.service.UserService;
import eu.infostart.jee.beans.User;
import eu.infostart.jee.db.DBManager;

/**
 * Servlet responsible for authentication
 * @author Web
 *
 */

@WebServlet("/loginServlet")
public class LoginServlet extends HttpServlet {
	
	/**
	 * 
	 */
	private static final long serialVersionUID = 8005027261398603951L;

//	private final String allowedUsername = "test";
//	private final String allowedPassword = "test";
	
	@EJB
	UserService userService;
	
	public void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		
		String username = request.getParameter("username");
		String password = request.getParameter("password");
		
		//PrintWriter out = response.getWriter();
		
		//DBManager dbManager = new DBManager(); //zadelq izli6no pamet
		
		//if (dbManager.checkValidUser(username, password)) {
		if (null != userService.loginUser(username, password)) {
			User loggedUser = new User();
			
			loggedUser.setUsername(username);
			loggedUser.setPassword(password);
			
			HttpSession session = request.getSession();
			session.setAttribute("loggedUser", loggedUser);
			
			response.sendRedirect(request.getContextPath() + "/success.jsp");
		} else {
			response.sendRedirect(request.getContextPath() + "/error.jsp");
		}
		
		//request.setAttribute("username", username);
		//request.setAttribute("password", password);
		
	}
	
	public void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		doPost(request, response);
	}
	
	public void service(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		
		if (request.getMethod().equals("POST")) {
			doPost(request, response);
		} else if (request.getMethod().equals("GET")) {
			doGet(request, response);
		}
		
		System.out.println("Service method");
		
	}
}
