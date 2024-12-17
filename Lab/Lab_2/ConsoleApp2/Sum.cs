using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Sum
    {
        public abstract int SumOfTwo(int a, int b);
        public abstract int SumOfThree(int x, int y, int z);
    }

    public class Calculate : Sum
    {
        public override int SumOfTwo(int a, int b)
        {
            return (a + b);
        }

        public override int SumOfThree(int x, int y, int z)
        {
            return (x+y+z);    
        }
    }
}
