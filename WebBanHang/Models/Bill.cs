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
    
    public partial class Bill
    {
        public int ID { get; set; }
        public Nullable<int> CartID { get; set; }
        public Nullable<double> TotalPrices { get; set; }
        public Nullable<double> DiscountPercent { get; set; }
        public Nullable<double> PayPrice { get; set; }
    
        public virtual Cart Cart { get; set; }
    }
}
