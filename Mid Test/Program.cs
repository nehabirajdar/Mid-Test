using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Test
{
    public class Program
    {
        private static double pi = 3.14;


       
        static void Main(string[] args)
        {

           
            double r = Convert.ToDouble(Console.ReadLine());
            double area = pi * r * r;
            Console.WriteLine("Area of Circle" + area);


        }
    }
}
