using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    1234
    123
    12
    1
    12
    123
    1234
*/

namespace Algorithms
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.patternOne(4);
            Console.Read();
        }

        public void patternOne(int n)
        {
            int newN = 9 - n;
            int numberTrain = 123456789;
            int firstLine = 0;
            for (int i = newN; i<9; i++)
            {
                firstLine = numberTrain / (int)Math.Pow(10, i);
                Console.WriteLine(firstLine);
            }
            for (int i = 9-2; i >= newN ; i--)
            {
                firstLine = numberTrain / (int)Math.Pow(10, i);
                Console.WriteLine(firstLine);
            }
        }
    }
}
