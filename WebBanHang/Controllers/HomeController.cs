using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHang.DAO;

namespace WebBanHang.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            ProductsDAO dao = new ProductsDAO();
            var lstSP = dao.GetAllSP();
            this.ViewBag.lstSP = lstSP;
            return View();
        }
        public String ImageItem(int id)
        {
            string temp = "";
            ProductsDAO dao = new ProductsDAO();
            var old = dao.Model.ProductsImgs.FirstOrDefault(f => f.ProductID == id);
            if (old != null)
                temp = old.ImgLink.ToString();
            return temp;
        }
	}
}