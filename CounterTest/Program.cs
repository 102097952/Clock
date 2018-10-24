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

            for ( ; ; )
            {
                myClock.Second();
                Console.WriteLine(myClock.Print()); ///New line created every increment
            }
        }
    }
}
