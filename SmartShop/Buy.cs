//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartShop
{
    using System;
    using System.Collections.Generic;
    
    public partial class Buy
    {
        public int kala_id { get; set; }
        public int invoice_id { get; set; }
        public int quantity { get; set; }
    
        public virtual Invoice Invoice { get; set; }
        public virtual Kala Kala { get; set; }
    }
}
