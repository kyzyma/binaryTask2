using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client list = null;
            
            list = new Client(new ConcretFabrica());

            list.Input();
            list.Input();
            list.Remove(0);

            Console.ReadKey();
            
        }
    }
}
