using System;
using System.Linq;
using MODULE3HW4.delegateTasl;

namespace MODULE3HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            var startLinq = new StarterLinq();
            //startLinq.Run();

            var starterDelegat = new StarterDelegat();
            starterDelegat.Run();

        }
    }
}