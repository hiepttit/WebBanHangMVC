//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanHang.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account
    {
        public int id { get; set; }
        public string UserName { get; set; }
        public string Pwd { get; set; }
        public string Name { get; set; }
        public string Addresss { get; set; }
        public Nullable<int> RoleID { get; set; }
        public Nullable<int> CustomerID { get; set; }
    
        public virtual Role Role { get; set; }
    }
}
