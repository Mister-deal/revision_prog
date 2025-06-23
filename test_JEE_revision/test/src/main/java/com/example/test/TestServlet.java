package com.example.test;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;

import java.io.IOException;
import java.io.PrintWriter;

@WebServlet(name = "testServlet", value = "/test-servlet")
public class TestServlet extends HttpServlet {

    public TestServlet() {
        super();
    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        String message = "Bonjour, je me présente à toi ! ";
        request.setAttribute("variable", message);
        this.getServletContext().getRequestDispatcher("/Test.jsp").forward(request, response);
    }

    protected void doPost(HttpServlet request, HttpServletResponse response) throws ServletException, IOException {

    }

    public void destroy() {
    }
}
