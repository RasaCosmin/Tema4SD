/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
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
                //pack.setTracking(rs.getInt("id"));
                
                packages.add(pack);
            }
        }catch (Exception e)
        {
            e.printStackTrace();
        }
        
        return packages;
    }
}
