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
    
    public partial class User
    {
        public User()
        {
            this.Invoices = new HashSet<Invoice>();
            this.Kalas = new HashSet<Kala>();
        }
    
        public int id { get; set; }
        public string user1 { get; set; }
        public string pass { get; set; }
        public int access { get; set; }
    
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<Kala> Kalas { get; set; }
    }
}
