using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopadv.Practices
{
    public class IfElse
    {
        public void IfElseExample(int num1, int num2)
        {
            //BAD example
            if (num1 <= 100 && num2 <= 100)
            {
                if (num1 % 2 == 0 && num2 % 2 == 0)
                {
                    if (num1 == num2)
                    {
                        Console.WriteLine("they are equal");
                    }
                }
            }

            //GOOD example
            if (num1 > 100 && num2 > 100) return;
            if (num1 % 2 != 0 && num2 % 2 != 0) return;
            if (num1 != num2) return;
            Console.WriteLine("they are equal");
        }
    }
}
