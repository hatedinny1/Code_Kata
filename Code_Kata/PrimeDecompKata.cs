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
            var counter = new Dictionary<string, int>();
            while (lst > 1)
            {
                for (int i = 2; i <= lst; i++)
                {
                    if (lst % i == 0)
                    {
                        lst = lst / i;
                        var key = i.ToString();
                        if (!counter.ContainsKey(key))
                        {
                            counter[key] = 1;
                        }
                        else
                        {
                            counter[key]++;
                        }
                        break;
                    }
                }
            }

            return counter
                   .Aggregate(result, (current, c) =>
                   current + 
                   (c.Value > 1 ?
                   $"({c.Key}**{c.Value})" :
                   $"({c.Key})"));
        }
    }
}
