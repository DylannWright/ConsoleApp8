using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Rocket Sputnick = new Rocket();
            Console.WriteLine (Sputnick.Countdown(10));

        }
    }
}
