using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatCalculator
{
    class GroceryStore
    {

        static void Main(string[] args)
        {
            Console.Title = "Supermarket!";

            Product product = new Product();

            product.Start();

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}
