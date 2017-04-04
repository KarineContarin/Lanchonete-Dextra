using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lanchonete.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sobre()
        {
            return View();
        }

        public ActionResult Ingredientes()
        {
            var H = Request["H"].ToString();
            var B = Request["B"].ToString();
            var O = Request["O"].ToString();
            var Q = Request["Q"].ToString();
            
            var subtotal = "0";

            if (H == "1")
            {
                subtotal = (Convert.ToDouble(subtotal) + 3).ToString("n2");
            }
            if (B == "1")
            {
                subtotal = (Convert.ToDouble(subtotal) + 2).ToString("n2");
            }
            if (O == "1")
            {
                subtotal = (Convert.ToDouble(subtotal) + 0.80).ToString("n2");
            }
             if (Q == "1")
            {
                subtotal = (Convert.ToDouble(subtotal) + 1.50).ToString("n2");
            }

         

            ViewBag.B = HttpUtility.HtmlEncode(B);
            ViewBag.H = HttpUtility.HtmlEncode(H);
            ViewBag.Q = HttpUtility.HtmlEncode(Q);
            ViewBag.O = HttpUtility.HtmlEncode(O);
            ViewBag.S = HttpUtility.HtmlEncode(subtotal.Replace(",","."));


            return View();
        }







    }
}
