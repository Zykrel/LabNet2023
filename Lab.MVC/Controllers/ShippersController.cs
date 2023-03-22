using Lab.EF.Entities;
using Lab.EF.Logic;
using Lab.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.MVC.Controllers
{
    public class ShippersController : Controller
    {

        ShippersLogic sLogic = new ShippersLogic();

        // GET: Shippers


        public ActionResult Index()
        {

            List<Shippers> listDeShippers = sLogic.ObtenerTodo();

            List<ShippersView> sView = listDeShippers.Select(s => new ShippersView
            {
                ID = s.ShipperID,
                companyName= s.CompanyName,
            }).ToList();



            return View(sView);
        }

        public ActionResult Insert()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Insert(ShippersView shippersView)
        {
            try
            {

                Shippers shipperEntity = new Shippers { CompanyName = shippersView.companyName};

                sLogic.insertarData(shipperEntity);
                return RedirectToAction("Index");

        }
            
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Delete(int id)
        {

            sLogic.Borrar(id);

            return RedirectToAction("Index");
        }

        public ActionResult Update()
        {

            

            return RedirectToAction("Index");
        }


    }
}