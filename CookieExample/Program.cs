using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanitTesting.Cookies
{
    class Program
    {
        static void Main(string[] args)
        {
            Cookie cookie1 = new Cookie("choclate");
            Cookie cookie2 = new Cookie("coconut");

            cookie1.topping= "gemschips";
            cookie1.weight = 20;
            cookie2.topping = "cashews";
            cookie2.weight = 30;

            Console.WriteLine("the flavor, topping and weight is ${cookie1.flavour} ,%s ,%d", cookie1.flavour, cookie1.topping, cookie1.weight );
            Console.WriteLine("the flavor, topping and weight is" + cookie2.flavour + ", " + cookie2.topping + ", " + cookie2.weight);

        }
    }
}
