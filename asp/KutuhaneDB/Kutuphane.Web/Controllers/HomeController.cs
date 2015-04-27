using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KutuhaneDB;
using Kutuphane_Web.Models;
using KutuphaneDB.Sorgular;

namespace Kutuphane_Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // DXCOMMENT: Pass a data model for GridView


            BOOKS bks = new BOOKS(); 
            return View(bks.getBook());
        }

        public ActionResult CreateBook()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateBook(BOOK bk)
        {
            BOOKS bks = new BOOKS();          
            bks.createBook(bk);
            return View();
        }
        public ActionResult GridViewPartialView()
        {
            // DXCOMMENT: Pass a data model for GridView in the PartialView method's second parameter
            BOOKS bk = new BOOKS();
            return PartialView("GridViewPartialView",bk.getBook());
        }

    }
}