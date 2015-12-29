/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package webservice;

import com.google.gson.Gson;
import dao.PackageDao;
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
    @WebMethod(operationName = "Search")
    public String GetClientPackage(@WebParam(name = "name") int clientId) {
       PackageDao db = new PackageDao();
       Gson gson  = new Gson();
       return gson.toJson(db.GetClientPackage(1));
    }
}
