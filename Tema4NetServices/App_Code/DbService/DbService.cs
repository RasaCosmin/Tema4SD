using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class DBService
{
    private SqlConnection _conn;
    public DBService()
    {
        _conn = new SqlConnection("server=COSMIN\\SQLEXPRESS;database=Tema4;Integrated Security=SSPI");
    }

    public int GetClientIdByName(string name)
    {
        var query = string.Format("Select Id from Users where Username='{0}'", name);
        var command = new SqlCommand(query, _conn);
        _conn.Open();
        var reader = command.ExecuteReader();

        var id = -1;

        if (reader.Read())
        {
            id = reader.GetInt32(0);
        }

        _conn.Close();
        return id;
    }

    public string AddPackage(int senderId, int receiverId, string name, string description, string senderCity, string destinationCity)
    {
        var query = string.Format("INSERT INTO Package (IdSender, IdReceiver, Name, Description, SenderCity, DestinationCity, Tracked) " +
            "values ({0}, {1}, '{2}', '{3}', '{4}', '{5}', 0)", senderId, receiverId, name, description, senderCity, destinationCity);
        var command = new SqlCommand(query, _conn);
        _conn.Open();
        var message = "";
        try
        {
            command.ExecuteNonQuery();
            message = "success";
        }
        catch (Exception e)
        {
            message = "failed";
            Console.Write(e.StackTrace);
        }

        _conn.Close();
        return message;
    }

    public string UpdateStatus(int packageId, string city, string time)
    {
        var query = string.Format("INSERT INTO Route (IdPackage, City, Time) VALUES ({0}, '{1}', '{2}')", packageId, city, time);
        var command = new SqlCommand(query, _conn);
        _conn.Open();
        var message = "";
        try
        {
            command.ExecuteNonQuery();
            message = "success";
        }
        catch (Exception e)
        {
            message = "failed";
            Console.Write(e.StackTrace);
        }

        _conn.Close();
        return message;
    }

    public string GetPackageById(int id)
    {
        var query = string.Format("SELECT * FROM Package WHERE id = {0}", id);
        var command = new SqlCommand(query, _conn);
        _conn.Open();
        var reader = command.ExecuteReader();
        var message = "";
        var p = new Package();

        if(reader.Read())
        {
            p.id = reader.GetInt32(0);
            p.idSender = reader.GetInt32(1);
            p.idReceiver = reader.GetInt32(2);
            p.name = reader.GetString(3);
            p.description = reader.GetString(4);
            p.senderCity = reader.GetString(5);
            p.destinationCity = reader.GetString(6);
            p.tracking = reader.GetBoolean(7);

            message = JsonConvert.SerializeObject(p);
        }
        else
        {
            message = "no element";
        }
        _conn.Close();
        return message;
    }

    public string GetAllUsernames()
    {
        var usernames = new List<string>();
        var query = "SELECT Username FROM Users";
        var command = new SqlCommand(query, _conn);
        _conn.Open();
        var message = "";
        try {
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var name = reader.GetString(0);
                usernames.Add(name);
            }

            message = JsonConvert.SerializeObject(usernames);
        }catch(Exception e)
        {
            message = "no elements";
        }
        _conn.Close();
        return message;
    }

    public string GetAllPackages()
    {
        var packages = new List<Package>();
        var query = "SELECT * FROM Package";
        var command = new SqlCommand(query, _conn);
        _conn.Open();
        var message = "";
        try
        {
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var p = new Package {
                    id = reader.GetInt32(0),
                    idSender = reader.GetInt32(1),
                    idReceiver = reader.GetInt32(2),
                    name = reader.GetString(3),
                    description = reader.GetString(4),
                    senderCity = reader.GetString(5),
                    destinationCity = reader.GetString(6),
                    tracking = reader.GetBoolean(7)
                };
                                                
                packages.Add(p);
            }

            message = JsonConvert.SerializeObject(packages);
        }
        catch (Exception e)
        {
            message = "no elements";
            Console.Write(e.StackTrace);
        }
        _conn.Close();
        return message;
    }

    public string TrackPackage(int packageId, string city, string time, bool track)
    {
        int tr;
        if(track)
        {
            tr = 1;
        }
        else
        {
            tr = 0;
        }
        var query1 = string.Format("UPDATE Package SET Tracked = {0} WHERE Id = {1}", tr, packageId);
        var query2 = string.Format("INSERT INTO Route (IdPackage, City, Time) VALUES ({0}, '{1}', '{2}')", packageId, city, time);
        _conn.Open();
        var transaction = _conn.BeginTransaction();
        var message = "";
        try
        {
            new SqlCommand(query1, _conn, transaction)
                .ExecuteNonQuery();
            new SqlCommand(query2, _conn, transaction)
                .ExecuteNonQuery();
            transaction.Commit();
            message = "success";
        }catch(Exception e)
        {
            transaction.Rollback();
            message = "failed";
        }
        _conn.Close();
        return message;
    }

    public string RemovePackage(int packageId)
    {
        var query = string.Format("DELETE FROM Package WHERE Id={0}", packageId);
        var command = new SqlCommand(query, _conn);
        _conn.Open();
        var message = "";
        try
        {
            command.ExecuteNonQuery();
            message = "success";
        }
        catch (Exception e)
        {
            message = "failed";
            Console.Write(e.StackTrace);
        }

        _conn.Close();
        return message;
    }
}