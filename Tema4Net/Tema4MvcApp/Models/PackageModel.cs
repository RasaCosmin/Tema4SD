using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tema4MvcApp.Models
{
    public class PackageModel
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
}