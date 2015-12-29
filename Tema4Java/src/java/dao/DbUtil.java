package dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.Properties;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
/**
 *
 * @author Cosmin
 */
public class DbUtil {
    private static Connection conn = null;
    
    public static Connection getConnection(){
        if(conn!= null){
            return conn;
        }else{
            try{
                String driver = "com.microsoft.sqlserver.jdbc.SQLServerDriver";
                String user = "sa";
                String password = "P@ssw0rd";        
                conn = DriverManager.getConnection("jdbc:sqlserver://COSMIN:54097;databaseName=Tema4",user,password);
                
                //conn = DriverManager.getConnection(url, user, password); 
            } catch ( SQLException ex) {
                ex.printStackTrace();
            }
        }
        return conn;
    }
}
