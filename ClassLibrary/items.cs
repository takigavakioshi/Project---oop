using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ItemsSHP
    {
        internal string NameIT;
        internal string DesIT;
        internal string NumerIT;
        internal string PriceIT;
        internal string IdIT;
        internal string PictureName;
        internal string ShopIdIT;

        public  ItemsSHP()
        {

        }

        public string nameIT { set; get; }
        public string desIT { set; get; }
        public string numerIT { set; get; }
        public string namerIT { set; get; }
        public string idIT = Convert.ToString(new Random().Next(1, 100000));
        public string priceIT { set; get; }
        public string pictureName { set; get; }
        public string shopIdIT { set; get; }

    }
}
