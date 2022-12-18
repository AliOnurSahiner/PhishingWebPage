using Newtonsoft.Json.Linq;
using PhishingWebPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Newtonsoft.Json;
using System.Web.Configuration;

namespace PhishingWebPage.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IndexAra(Users users)
        {

            // Kullanıcının IPsini almak için yazıldı
            string clientIP = Request.UserHostAddress;


            string phishingHeader = WebConfigurationManager.AppSettings["PhishingHeader"];
            string phishingBody = WebConfigurationManager.AppSettings["PhishingBody"];
            string phishingBody1 = WebConfigurationManager.AppSettings["phishingBody1"];
            string phishingBody2 = WebConfigurationManager.AppSettings["phishingBody2"];
            string phishingBody3 = WebConfigurationManager.AppSettings["phishingBody3"];
            string phishingBody4 = WebConfigurationManager.AppSettings["phishingBody4"];
            string phishingBody5 = WebConfigurationManager.AppSettings["phishingBody5"];
            string phishingBody6 = WebConfigurationManager.AppSettings["phishingBody6"];
            string phishingBody7 = WebConfigurationManager.AppSettings["phishingBody7"];
            string phishingBody8 = WebConfigurationManager.AppSettings["phishingBody8"];
            string phishingBody9 = WebConfigurationManager.AppSettings["phishingBody9"];


            ViewBag.phishingHead = phishingHeader;

            ViewBag.phishingBd = phishingBody;
            ViewBag.phishingBd1 = phishingBody1;
            ViewBag.phishingBd2 = phishingBody2;
            ViewBag.phishingBd3 = phishingBody3;
            ViewBag.phishingBd4 = phishingBody4;
            ViewBag.phishingBd5 = phishingBody5;
            ViewBag.phishingBd6 = phishingBody6;
            ViewBag.phishingBd7 = phishingBody7;
            ViewBag.phishingBd8 = phishingBody8;
            ViewBag.phishingBd9 = phishingBody9;

            string folder = @"C:\Phishing\";
            var newPath = System.IO.Directory.CreateDirectory(folder);
            string fileName = "Phishing.txt";
            string pathString = System.IO.Path.Combine(folder, fileName);

            //string fullPath = pathString;

            string username = users.username;
            string password = users.password;
            string tarih = DateTime.Now.ToString();

            string[] fullData = { "Kullanıcı Adı:" + " " + username + "/" + "Tarih :" + " " + tarih + "/" + "ClientIP :" + " " + clientIP};

            string jsonData = JsonConvert.SerializeObject(fullData);

            System.IO.File.AppendAllText(pathString, jsonData + Environment.NewLine);
          
            return View();

        }
    }
}