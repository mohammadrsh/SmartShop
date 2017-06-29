using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop
{
    class Db

    {
        private static SmartShopEntities dbContex = new SmartShopEntities();
        public static SmartShopEntities GetContex()
        {
            return dbContex;
        }

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
