using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanitTesting.Cookies
{
    class Cookie
    {
        private string myflavour;
        private string mytopping;
        private int myweight;

        public Cookie(string flavourSample)
        {
            this.flavour = flavourSample;
            this.topping = "chocochip";
            this.weight = 10;

        }

        public string flavour { get { return myflavour; } set { myflavour = value; } }
        public string topping { get { return mytopping; } set { mytopping = value; } }
        public int weight { get { return myweight; } set { myweight = value; } }
    }
}
