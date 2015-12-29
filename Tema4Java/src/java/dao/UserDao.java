/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import models.User;

/**
 *
 * @author Cosmin
 */
public class UserDao {

    public User Login(String username, String password) {
        User user = new User();
        try {
            Connection conn = DbUtil.getConnection();
            String query = "Select * from Users where Username=? and Password=?";
            PreparedStatement pstmt = conn.prepareStatement(query);
            pstmt.setString(1, username);
            pstmt.setString(2, password);

            ResultSet rs = pstmt.executeQuery();

            if (rs.next()) {
                user.setId(rs.getInt("Id"));
                user.setUsername(rs.getString("Username"));
                user.setPassword(rs.getString("Password"));
                user.setRole(rs.getString("Role"));
            }
            pstmt.close();
        } catch (SQLException se) {
            System.out.println(se);
        }

        return user;
    }

    public void Register(User u) {
        try {
            Connection conn = DbUtil.getConnection();
            String SQL = "INSERT INTO Users(Username, Password, Role) Values(?,?,?)";
            PreparedStatement pstmt = conn.prepareStatement(SQL);
            pstmt.setString(1, u.getUsername());
            pstmt.setString(2, u.getPassword());
            pstmt.setString(3, "client");
            int e = pstmt.executeUpdate();
            pstmt.close();
        } catch (SQLException se) {
            System.out.println(se);
        }
    }

    public User GetUserByUsername(String username) {
         User user = new User();
        try {
            Connection conn = DbUtil.getConnection();
            String query = "Select * from Users where Username=?";
            PreparedStatement pstmt = conn.prepareStatement(query);
            pstmt.setString(1, username);
            

            ResultSet rs = pstmt.executeQuery();

           if (rs.next()) {
                user.setId(rs.getInt("Id"));
                user.setUsername(rs.getString("Username"));
                user.setPassword(rs.getString("Password"));
                user.setRole(rs.getString("Role"));
            }
            pstmt.close();
        } catch (SQLException se) {
            System.out.println(se);
        }

        return user;
    }
}

