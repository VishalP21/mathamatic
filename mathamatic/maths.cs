using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathamatic
{
    public class maths
    {
        
        public void add(int x, int y)
        {
            Console.WriteLine(x + y);
           
        }
        public void add(int x, int y, int z) 
        {
            Console.WriteLine(x + y + z);

        }
        public void mins(int x, int y)
        {
            Console.WriteLine(x - y);
           
        }
        public void mins(int x, int y, int z)
        {
            Console.WriteLine(x - y - z);
           
        }
        public void multis(int x, int y)
        {
           Console.WriteLine(x * y);
        }
        public void multis(int x, int y, int z)
        {
            Console.WriteLine(x * y * z);
        }
        public void divi(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        public void divi(int x, int y, int z)
        {
            Console.WriteLine(x / y / z);
        }
    }
}
