using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPVirtualClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();
            Console.WriteLine("----------------------");
            int c = PlusMethod(5, 6);
            double d = PlusMethod(5.5, 5.6);
            string type1 = c.GetType().ToString(); // Return Type Int32
            string type2 = d.GetType().ToString(); // Return Type Double
            Console.WriteLine("Int: {0} and Double: {1}", c, d);
            Console.WriteLine("Type c: {0} and Type d: {1}", type1, type2);

            Console.ReadKey();
        }
        public static int PlusMethod(int a, int b)
        {
            return a + b;
        }
        public static double PlusMethod (double a, double b)
        {
            return a + b;
        }
    }
}
