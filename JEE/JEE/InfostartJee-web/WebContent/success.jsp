<%@ page import="eu.infostart.jee.beans.User" language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>First Java EE Project</title>
</head>
<body>
	<%
	User loggedUser = (User) session.getAttribute("loggedUser");
	
	if (loggedUser != null) {
		out.println("Hello " + loggedUser.getUsername());
		out.println("<br /><br /><a href='logout.jsp'>Logout</a>");
	}
	%>
</body>
</html>