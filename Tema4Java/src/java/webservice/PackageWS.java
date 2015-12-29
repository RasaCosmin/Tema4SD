/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package webservice;

import com.google.gson.Gson;
import dao.PackageDao;
import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author Cosmin
 */
@WebService(serviceName = "PackageWS")
public class PackageWS {

    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "getClientPackage")
    public String GetClientPackage(@WebParam(name = "name") int clientId) {
       PackageDao db = new PackageDao();
       ArrayList packages = db.GetClientPackage(clientId);
       Gson gson  = new Gson();
       if(packages.size()>0)
       return gson.toJson(packages);
       else return "no element";
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "search")
    public String search(@WebParam(name = "packageName") String packageName, @WebParam(name = "clientId") int clientId) {
       PackageDao db = new PackageDao();
       ArrayList packages = db.SearchClientPackage(packageName, clientId);
       Gson gson  = new Gson();
       if(packages.size()>0)
       return gson.toJson(packages);
       else return "no element";
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "verifyStatus")
    public String VerifyStatus(@WebParam(name = "packageId") int packageId) {
       PackageDao db = new PackageDao();
       ArrayList statuses = db.PackageStatus(packageId);
       Gson gson  = new Gson();
       if(statuses.size()>0)
       return gson.toJson(statuses);
       else return "no element";
    }
}
