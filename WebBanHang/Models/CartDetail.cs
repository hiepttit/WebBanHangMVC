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
    
    public partial class CartDetail
    {
        public int ID { get; set; }
        public Nullable<int> CartID { get; set; }
        public Nullable<int> ProductsID { get; set; }
        public Nullable<int> TheCount { get; set; }
        public Nullable<double> Price { get; set; }
    
        public virtual Cart Cart { get; set; }
        public virtual Product Product { get; set; }
    }
}
