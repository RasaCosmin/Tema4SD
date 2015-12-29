using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Package
/// </summary>
public class Package
{
    public int id { get; set; }
    public int idSender { get; set; }
    public int idReceiver { get; set; }
    public String name { get; set; }
    public String description { get; set; }
    public String senderCity { get; set; }
    public String destinationCity { get; set; }
    public bool tracking { get; set; }
}