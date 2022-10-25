using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VinFletchersArrows
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Arrow arrow = new Arrow(0, 0, 70);
            arrow = arrow.GetArrow();

            Console.WriteLine($"Your arrow will cost: {arrow.GetCost()} gold.");
        }
    }
}
