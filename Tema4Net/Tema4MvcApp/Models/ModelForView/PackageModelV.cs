using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tema4MvcApp.Models
{
    public class PackageModelV
    {
        public int id { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public String name { get; set; }
        public String description { get; set; }
        public String senderCity { get; set; }
        public String destinationCity { get; set; }
        public bool tracking { get; set; }
    }
}