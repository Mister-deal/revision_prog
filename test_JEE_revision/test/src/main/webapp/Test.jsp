<%--
  Created by IntelliJ IDEA.
  User: max-9
  Date: 11/05/2025
  Time: 17:44
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Test</title>
</head>
<body>
<%@include file="menu.jsp"%>
<h1>
    Test! bienvenue à toi !
</h1>

<pre>
    <%
        String variable = (String) request.getAttribute("variable");
        out.println(variable);
    %>
</pre>
</body>
</html>
