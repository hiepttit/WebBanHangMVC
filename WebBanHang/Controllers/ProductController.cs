using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHang.DAO;

namespace WebBanHang.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Detail(int id)
        {
            this.ViewBag.lstImg = ImageDetail(id);
            ProductsDAO dao = new ProductsDAO();
            var old = dao.Model.Products.FirstOrDefault(f => f.ID == id);
            if (old != null)
                this.ViewBag.item = old;
            return View();
        }
        public String ImageMainDetail(int id)
        {
            string temp = "";
            ProductsDAO dao = new ProductsDAO();
            var old = dao.Model.ProductsImgs.FirstOrDefault(f => f.ProductID == id);
            if (old != null)
                temp = old.ImgLink.ToString();
            return temp;
        }
        public List<String> ImageDetail(int id)
        {
            List<String> lst = new List<string>();
            ProductsDAO dao = new ProductsDAO();
            var lstImg = dao.GetAllImgProduct();
            foreach (var item in lstImg)
            {
                if (item.ProductID == id)
                    lst.Add(item.ImgLink);
                else
                    break;
            }   
            return lst;
        }
	}
}