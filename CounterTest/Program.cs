using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock myClock = new Clock();

            Console.WriteLine("1 hour clock");
            for ( int i = 0; i < 3600; i++)
            {
                Thread.Sleep(1000);
                myClock.Second();
                Console.Write("\r" + myClock.Print());
            }
        }
    }
}
