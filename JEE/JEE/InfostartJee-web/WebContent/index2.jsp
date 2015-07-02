<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>First Java EE Project</title>
</head>
<body>
	<h1>
	<% 
	out.println("Hello World!");
	out.println(request.getContextPath());
	%>
	</h1>
	
	<p>
		<a href="random.jsp">Random</a>
		<a href="/InfostartJee-web/random.jsp">Random 2</a>
		<a href="<% out.println(request.getContextPath()); %>/random.jsp">Random 3</a>
		<a href="<%=request.getContextPath()%>/random.jsp">Random 4</a> <br />
		<a href="<%=request.getContextPath()%>/login.jsp">LogIn</a>
	</p>
</body>
</html>