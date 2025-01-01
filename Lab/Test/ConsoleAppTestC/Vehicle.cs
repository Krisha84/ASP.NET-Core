using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestC
{
    internal interface Vehicle
    {
        void Start();
        void Stop();
    }

    public class Car : Vehicle
    {
        public void Start()
        {
            Console.WriteLine("The car has started !!");
        }
        
        public void Stop()
        {
            Console.WriteLine("The car has stopped !!");
        }
    }

}
