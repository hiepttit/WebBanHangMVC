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
            return View();
        }
        [ChildActionOnly]
        public ActionResult GetCategory()
        {
            ProductsDAO dao = new ProductsDAO();
            var lstCt = dao.GetAllCategory();
            return PartialView(lstCt);
        }
	}
}