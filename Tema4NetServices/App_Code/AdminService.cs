using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using Newtonsoft.Json;

/// <summary>
/// Summary description for AdminService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class AdminService : System.Web.Services.WebService
{
    private DBService _db;
    public AdminService()
    {
        _db = new DBService();
        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string AddPackage(string sender, string receiver, string name, string description, string senderCity, string destinationCity)
    {
        var senderId = _db.GetClientIdByName(sender);
        var receiverId = _db.GetClientIdByName(receiver);
        return _db.AddPackage(senderId, receiverId, name, description, senderCity, destinationCity);
    }

    [WebMethod]
    public string RemovePackage(int packageId)
    {
        return _db.RemovePackage(packageId);
    }

    [WebMethod]
    public string TrackPackage(int packageId, string city, string time)
    {
        return _db.TrackPackage(packageId, city, time);
    }

    [WebMethod]
    public string UpdatePackageStatus(int packageId, string city, string time)
    {
        return _db.UpdateStatus(packageId, city, time);
    }

    [WebMethod]
    public string GetAllPackages()
    {
        return _db.GetAllPackages();
    }

    [WebMethod]
    public string GetAllUserNames()
    {
        return _db.GetAllUsernames();
    }
}
