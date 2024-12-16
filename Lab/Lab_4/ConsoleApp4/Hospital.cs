using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Hospital
    {
        public virtual void hospitalDetail()
        {
            Console.WriteLine("General Hospital Detail...!!");
        }
    }

    class Apollo : Hospital
    {
        public override void hospitalDetail()
        {
            Console.WriteLine("Apollo Hospital...!!");
        }
    }

    class Wockhardt : Hospital
    {
        public override void hospitalDetail()
        {
            Console.WriteLine("Wockhardt Hospital...!!");
        }
    }

    class Gokul_Superspeciality : Hospital
    {
        public override void hospitalDetail()
        {
            Console.WriteLine("Gokul_Superspeciality Hospital...!!");
        }
    }
}
