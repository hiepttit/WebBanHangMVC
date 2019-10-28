using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBanHang.Models;

namespace WebBanHang.DAO
{
    public class ProductsDAO:BaseDAO
    {
        public List<Product> GetAllSP()
        {
            var lst = Model.Products.OrderBy(p=>p.ID).Take(3).ToList();
            return lst;
        }
        public List<ProductsImg> GetAllImgProduct()
        {
            var lst = Model.ProductsImgs.OrderBy(p => p.ProductID).ToList();
            return lst;
        }
        public List<Category> GetAllCategory()
        {
            var lst = Model.Categories.ToList();
            return lst;
        }
        public List<ProductsImg> ListImg(int idProducts)
        {
            return Model.ProductsImgs.Where(p => p.ProductID == idProducts).OrderBy(p=>p.ID).ToList();
        }
    }
}