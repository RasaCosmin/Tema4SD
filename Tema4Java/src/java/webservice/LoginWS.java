/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package webservice;

import dao.UserDao;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import models.User;

/**
 *
 * @author Cosmin
 */
@WebService(serviceName = "LoginWS")
public class LoginWS {

    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "Login")
    public String Login(@WebParam(name = "username") String username, @WebParam(name = "password") String password) {
        UserDao db = new UserDao();
        User u= db.Login(username, password);
        if(u.getUsername()!=null)
        return u.getRole();
        else return "failed";
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "Register")
    public String Register(@WebParam(name = "username") String username, @WebParam(name = "password") String password) {
        UserDao db = new UserDao();
        User u = new User();
        u.setUsername(username);
        u.setPassword(password);
        u.setRole("client");
        try{
            db.Register(u);
        }catch(Exception e){
            e.printStackTrace();
            return "failed";
        }
        return "success";
    }
}
