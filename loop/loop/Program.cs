using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //commenting the while loop statement
          /*  int countVariable = 0;
            while (countVariable < 10)
            {
                Console.Write("For this iteration the value of countVariable is:{0}\n", countVariable);
                countVariable++;
            }*/
            for (int counter=0; counter < 20; counter++)
            {
                Console.WriteLine("The value of the variable is:{0}\n", counter);
            }
        }
    }
}
