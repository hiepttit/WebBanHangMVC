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
    }
}