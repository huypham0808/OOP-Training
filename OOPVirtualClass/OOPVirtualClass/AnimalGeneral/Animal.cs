using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPVirtualClass
{
    public class Animal
    {
        public virtual void Speak()
        {
            Console.Write("Animal speak **brr");
        }
    }
}
