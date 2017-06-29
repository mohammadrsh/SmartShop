using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop
{
    class Controller
    {
        public void addInvoice(Invoice i)
        {
            var context = Db.getInstance();
            context.Invoices.Add(i);
            context.SaveChanges();
        }

        public void removeInvoice(Invoice i)
        {
            var context = Db.getInstance();
            context.Invoices.Remove(i);
            context.SaveChanges();
        }

        public void removeInvoiceFromDb(int id)
        {
            var context = Db.getInstance();
            Invoice i = context.Invoices.FirstOrDefault(inv => inv.id == id);
            context.Invoices.Remove(i);
            context.SaveChanges();
        }

        public void addCustomer(Customer c)
        {
            var context = Db.getInstance();
            context.Customers.Add(c);
            context.SaveChanges();
        }
    }
}
