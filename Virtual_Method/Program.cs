using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Virtual_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car a = new Car();
            a.Name = "Hedi";
            a.LastName = "seza";
            a.Hi();
            Console.ReadKey();
        }
    }
    class Driver
    {
        public string Name;
        public string LastName;
        public virtual void Hi()
        {
            Console.WriteLine("Hi " + this.Name + " " + this.LastName);
        }
    }
    class Car:Driver
    {
        public override void Hi()
        {
            Console.WriteLine("Driver "+ Name + LastName +" please drive carefully with me");
        }
    }
}
