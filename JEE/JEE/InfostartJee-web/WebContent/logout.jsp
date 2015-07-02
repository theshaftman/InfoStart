<%@ page import="eu.infostart.jee.beans.User" language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>

<% 
session.invalidate();
response.sendRedirect(request.getContextPath() + "/login.jsp");
%>