using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBanHang.Models;

namespace WebBanHang.DAO
{
    public class BaseDAO
    {
        public BaseDAO()
        {
            Model = new WebBanHangEntities();
        }
        public WebBanHangEntities Model { get; set; }
    }
}