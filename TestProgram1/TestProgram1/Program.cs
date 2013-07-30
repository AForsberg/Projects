using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            
             int[,] results = {{81, 130, 97, 92}, {75, 84, 93, 80},

                                 {19, 95, 92, 94}, {91, 13, 90, 77}};

             Console.WriteLine(results[1, 2]);
            Console.ReadLine();
        }
        
        
       
    }
}
