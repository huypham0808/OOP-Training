using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAbstractClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.speed = 200;
            car.go();
            Console.WriteLine(((car.speed).ToString()));

            Console.ReadKey();
        }
    }
    abstract class Vihecle
    {
        public int speed = 0;

        public void go ()
        {
            Console.WriteLine("Vihecle is moving");
        }
    }
    class Car : Vihecle
    {
        int maxSpeed = 400;
        public int wheels = 4;
    }
    class Bike: Vihecle
    {
        int maxSpeed = 100;
        public int wheels = 2;
    }
       
}
