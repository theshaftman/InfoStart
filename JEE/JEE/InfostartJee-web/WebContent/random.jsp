<%@ page import="java.util.Random" language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>First Java EE Project</title>
</head>
<body>
	<h1>
	<% 
	Random randomGenerator = new Random();
	
	int number = randomGenerator.nextInt();
	out.println(number);
	//out.println(request.getAttribute("username"));
	%></h1>
</body>
</html>