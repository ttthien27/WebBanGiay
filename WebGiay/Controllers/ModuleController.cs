using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyClass;
using MyClass.DAO;
using MyClass.Model;

namespace WebGiay.Controllers
{
    public class ModuleController : Controller
    {
        // GET: Module
        public ActionResult SaleSite()
        {
            //CategoryDAO categoryDAO = new CategoryDAO();
            //List<LoaiGiay> list = categoryDAO.getList();
            return View("SaleSite"/*, list*/);
        }
        public ActionResult MainMenu()
        {
            CategoryDAO categoryDAO = new CategoryDAO();
            List<LoaiGiay> list = categoryDAO.getList();
            return View("MainMenu",list);
        }
        public ActionResult SlideShow()
        {
            SlideDAO slideDAO = new SlideDAO();
            List<Slider> list = slideDAO.getList("slideshow");
            return View("SlideShow",list);
        }
    }
}