using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBanHang.Models;

namespace WebBanHang.DAO
{
    public class CategoryDAO : BaseDAO
    {
        public List<Category> GetList()
        {
            return Model.Categories.OrderBy(p=>p.ID).ToList();
        }
    }
}