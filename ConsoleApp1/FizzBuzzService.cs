using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FizzBuzzService
    {
        public string GetValue(int n)
        {
            for (int i = 1; n < i; i++)
            {
                if (n % 5 == 0 && n % 3 ==0)
                    return "FizzBuzz";

                if (n % 3 == 0)
                    return "Fizz";

                if (n % 5 == 0)
                    return "Buzz";
            }
            return n.ToString();
        }
    }
}
