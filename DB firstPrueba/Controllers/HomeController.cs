using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DB_firstPrueba.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (BaseDeDatoNuevaEntities baseDeDatoNuevaEntities = new BaseDeDatoNuevaEntities())
            {
                Recipe recipe = new Recipe
                    (
                        
                    ); 

               
            }


                return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}