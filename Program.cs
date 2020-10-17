using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace moorelaw
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double x;
            n= int.Parse(Console.ReadLine());
            x = Math.Log(n, 2) * 1.5;
            Console.WriteLine(x + " " + "ani");
            Console.ReadKey();
            
            
        }
    }
}
