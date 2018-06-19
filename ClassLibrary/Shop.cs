    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ClassLibrary
    {
        public class Shop
        {
            internal string Name;
            internal string Adres;
            internal string Type;
            internal string ID;
            internal string Picture;


            public Shop()
            {
            
            }
            public string name { set; get; }
            public string adres { set; get; }
            public string type { set; get; }
            public string id = Convert.ToString( new Random().Next(1, 100000));
            public string picture { set; get; }

        }
    }
