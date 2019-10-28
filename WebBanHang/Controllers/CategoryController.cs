using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHang.DAO;

namespace WebBanHang.Controllers
{
    public class CategoryController : Controller
    {
        //
        // GET: /Category/
        public ActionResult Index()
        {
            ProductsDAO dao = new ProductsDAO();
            var lstCt = dao.GetAllCategory();
            return View("~/Views/Shared/_Layout.cshtml", lstCt);
        }
	}
}