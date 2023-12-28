using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPVirtualClass
{
    internal class Dog:Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog speak *woof*");
        }
    }
}
