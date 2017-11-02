using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Kata
{
    public class PrimeDecompKata
    {
        public String Factors(int lst)
        {
            if (lst < 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            var result = string.Empty;
            while (lst > 1)
            {
                for (int i = 2; i <= lst; i++)
                {
                    if (lst % 2 == 0)
                    {
                        lst = lst / i;
                        result = $"({i})";
                    }
                }
            }
            return result;
        }
    }
}
