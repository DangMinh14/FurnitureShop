//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class orderdetail
    {
        public int id { get; set; }
        public Nullable<int> orderid { get; set; }
        public Nullable<int> productid { get; set; }
        public Nullable<int> price { get; set; }
        public Nullable<int> quantity { get; set; }
    
        public virtual order order { get; set; }
        public virtual product product { get; set; }
    }
}