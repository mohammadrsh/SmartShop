using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop
{
    class Db
    {
        public static SmartShopEntities ume;
        public static SmartShopEntities getInstance()
        {
            if (ume == null)
            {
                ume = new SmartShopEntities();
                return ume;
            }
            else
            {
                return ume;
            }

        }
    }
}
