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
    public class SiteController : Controller
    {
        ProductDAO productDAO = new ProductDAO();
        // GET: Site
        public ActionResult Index(String slug=null)
        {
            LinkDAO LinkDAO = new LinkDAO();

            if (slug == null)
            {
                return this.Home();
            }
            else
            {
                Link row_link = LinkDAO.getRow(slug);
                if(row_link != null)
                {
                    String linktype = row_link.table_name;
                    switch (linktype)
                    {
                        case "LoaiGiay":
                            return this.ProductCategory();

                    }
                }
                else
                {
                    Giay row_product = productDAO.getRow(slug);
                    if (row_product != null)
                    {
                        return ProductDetail(slug);
                    }
                }
            }
            return Error404(); 
        }
        public ActionResult Error404()
        {
            return View("Error404");
        }
        public ActionResult ProductDetail(String slug)
        {
            return View("ProductDetail");
        }
        public ActionResult ProductCategory()
        {
            return View("ProductCategory");
        }
        public ActionResult Home()
        {
            return View("Home");
        }
    }
}