using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tema4MvcApp.Models;

namespace Tema4MvcApp.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            var adminService = new AdminService.AdminServiceSoapClient();
            var packageService = new PackageWebService.PackageWSClient();
            var result = adminService.GetAllPackages();
            var packages = new List<PackageModel>();
            var packagesV = new List<PackageModelV>();
            if (!result.Equals("no elements"))
            {
                packages = JsonConvert.DeserializeObject<List<PackageModel>>(result);
                foreach (var p in packages)
                {
                    var pack = new PackageModelV
                    {
                        id = p.id,
                        description = p.description,
                        destinationCity = p.destinationCity,
                        name = p.name,
                        senderCity = p.senderCity,
                        tracking = p.tracking,
                        Sender = packageService.getClientNameById(p.idSender),
                        Receiver = packageService.getClientNameById(p.idReceiver)
                    };

                    packagesV.Add(pack);
                }
                if (TempData["Mess"] != null) {
                    ViewBag.Mess = TempData["Mess"].ToString();
                    TempData.Remove("Mess");
                }
            }
            else
            {
                ViewBag.Mess = "There isn't any package";
            }

            return View(packagesV);
        }

        public ActionResult StartTracking(int id)
        {
            var adminService = new AdminService.AdminServiceSoapClient();
            var packageResult = adminService.GetPackgeById(id);
            if (!packageResult.Equals("no element"))
            {
                var package = JsonConvert.DeserializeObject<PackageModel>(packageResult);
                var result = adminService.TrackPackage(id, package.senderCity, DateTime.Now.ToString("HH:mm"), true);
            }
            else
            {
                TempData["Mess"] = "There isn't any package";
            }

            return RedirectToAction("Index");
        }

        public ActionResult StopTracking(int id)
        {
            var adminService = new AdminService.AdminServiceSoapClient();
            var packageResult = adminService.GetPackgeById(id);
            if (!packageResult.Equals("no element"))
            {
                var package = JsonConvert.DeserializeObject<PackageModel>(packageResult);
                var result = adminService.TrackPackage(id, package.destinationCity, DateTime.Now.ToString("HH:mm"), false);
            }
            else
            {
                TempData["Mess"] = "There isn't any package";
            }

            return RedirectToAction("Index");
        }

        public ActionResult UpdateStatus(int id)
        {
            var adminService = new AdminService.AdminServiceSoapClient();
            var packageResult = adminService.GetPackgeById(id);
            var package = JsonConvert.DeserializeObject<PackageModel>(packageResult);

            if(!package.tracking)
            {
                TempData["Mess"] = "This package isn't tracked";
                return RedirectToAction("Index");
            }

            var route = new RouteModel()
            {
                idPackage = id,
                time = DateTime.Now.ToString("HH:mm")
            };
            return View(route);
        }

        [HttpPost]
        public ActionResult UpdateStatus(RouteModel route)
        {
            var adminService = new AdminService.AdminServiceSoapClient();
            var result = adminService.UpdatePackageStatus(route.idPackage, route.city, route.time);
            if (result.Equals("failed"))
            {
                TempData["Mess"] = "Can't update the status";
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var adminService = new AdminService.AdminServiceSoapClient();
            var result = adminService.RemovePackage(id);
            if (result.Equals("failed"))
            {
                TempData["Mess"] = "There isn't any package";
            }
            return RedirectToAction("Index");
        }

        public ActionResult Route(int id)
        {
            var packageService = new PackageWebService.PackageWSClient();
            var result = packageService.verifyStatus(id);
            var routes = new List<RouteModel>();
            var routesV = new List<RouteModelV>();
            if (!result.Equals("no element"))
            {
                routes = JsonConvert.DeserializeObject<List<RouteModel>>(result);
                foreach(var r in routes)
                {
                    var route = new RouteModelV()
                    {
                        id = r.id,
                        city = r.city,
                        Package = packageService.getPackageNameById(r.idPackage),
                        time = r.time
                    };
                    routesV.Add(route);
                }
            }
            else
            {
                ViewBag.Mess = "This package don't have any route";
            }
            ViewBag.PackageId = id;
            return View(routesV);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PackageModel package)
        {
            var adminService = new AdminService.AdminServiceSoapClient();
            var result = adminService.AddPackage(package.idSender.ToString(), package.idReceiver.ToString(), package.name, package.description, package.senderCity, package.destinationCity);
            if (result.Equals("failed"))
            {
                ViewBag.Mess = "There isn't any package";
                return View(package);
            }
            return RedirectToAction("Index");
        }
    }
}