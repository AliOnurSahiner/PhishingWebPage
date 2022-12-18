using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhishingWebPage.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string username { get; set; }

        public string ClientIP { get; set; }

        public  string password { get; set; }


    }
}