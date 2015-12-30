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
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import models.*;

/**
 *
 * @author Cosmin
 */
public class PackageDao {
    public ArrayList<models.Package> GetClientPackage(int clientId)
    {
        ArrayList<models.Package> packages = new ArrayList<models.Package>();
        
        try{
            Connection conn = DbUtil.getConnection();
            String query = "Select * from Package where IdSender=? or IdReceiver=?";
            PreparedStatement pstmt = conn.prepareStatement(query);
            pstmt.setInt(1, clientId);
            pstmt.setInt(2, clientId);
            ResultSet rs = pstmt.executeQuery();
            
            while(rs.next())
            {
                models.Package pack = new models.Package();
                pack.setId(rs.getInt("Id"));
                pack.setIdSender(rs.getInt("IdSender"));
                pack.setIdReceiver(rs.getInt("IdReceiver"));
                pack.setName(rs.getString("Name"));
                pack.setDescription(rs.getString("Description"));
                pack.setSenderCity(rs.getString("SenderCity"));
                pack.setDestinationCity(rs.getString("DestinationCity"));
                int track = rs.getInt("Tracked");
                boolean tr = false;
                if(track==1){
                   tr = true;
                }
                pack.setTracking(tr);
                
                packages.add(pack);
            }
        }catch (Exception e)
        {
            e.printStackTrace();
        }
        
        return packages;
    }

    public ArrayList SearchClientPackage(String packageName, int clientId) {
        ArrayList<models.Package> packages = new ArrayList<models.Package>();
        
        try{
            Connection conn = DbUtil.getConnection();
            String query = "Select * from Package where (IdSender=? or IdReceiver=?) and Name like ?";
            PreparedStatement pstmt = conn.prepareStatement(query);
            pstmt.setInt(1, clientId);
            pstmt.setInt(2, clientId);
            pstmt.setString(3, "%"+packageName+"%");
            
            ResultSet rs = pstmt.executeQuery();
            
            while(rs.next())
            {
                models.Package pack = new models.Package();
                pack.setId(rs.getInt("Id"));
                pack.setIdSender(rs.getInt("IdSender"));
                pack.setIdReceiver(rs.getInt("IdReceiver"));
                pack.setName(rs.getString("Name"));
                pack.setDescription(rs.getString("Description"));
                pack.setSenderCity(rs.getString("SenderCity"));
                pack.setDestinationCity(rs.getString("DestinationCity"));
                int track = rs.getInt("Tracked");
                boolean tr = false;
                if(track==1){
                   tr = true;
                }
                pack.setTracking(tr);
                
                packages.add(pack);
            }
        }catch (Exception e)
        {
            e.printStackTrace();
        }
        
        return packages;
    }

    public ArrayList PackageStatus(int packageId) {
        ArrayList<Route> routes = new ArrayList<Route>();
        
        try{
            Connection conn = DbUtil.getConnection();
            String query = "Select * from Route where IdPackage=?";
            PreparedStatement pstmt = conn.prepareStatement(query);
            pstmt.setInt(1, packageId);
                        
            ResultSet rs = pstmt.executeQuery();
            
            while(rs.next())
            {
                Route route = new  Route();
                route.setId(rs.getInt("Id"));
                route.setIdPackage(rs.getInt("IdPackage"));              
                route.setCity(rs.getString("City"));
                route.setTime(rs.getString("Time"));
                
                routes.add(route);
            }
        }catch (Exception e)
        {
            e.printStackTrace();
        }
        
        
        return routes;
    }

    public models.Package getPackageById(int idPackage) {
        models.Package pack = new models.Package();
        try {
            Connection conn = DbUtil.getConnection();
            String query = "Select * from Package where Id=?";
            PreparedStatement pstmt = conn.prepareStatement(query);
            pstmt.setInt(1, idPackage);
                        
            ResultSet rs = pstmt.executeQuery();
            
             if(rs.next())
            {
                pack = new models.Package();
                pack.setId(rs.getInt("Id"));
                pack.setIdSender(rs.getInt("IdSender"));
                pack.setIdReceiver(rs.getInt("IdReceiver"));
                pack.setName(rs.getString("Name"));
                pack.setDescription(rs.getString("Description"));
                pack.setSenderCity(rs.getString("SenderCity"));
                pack.setDestinationCity(rs.getString("DestinationCity"));
                int track = rs.getInt("Tracked");
                boolean tr = false;
                if(track==1){
                   tr = true;
                }
                pack.setTracking(tr);
            }
            
        } catch (SQLException ex) {
            pack = null;
            Logger.getLogger(PackageDao.class.getName()).log(Level.SEVERE, null, ex);
        }
        
        return pack;
    }
}
