using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remover.Library
{
    public class Remover
    {
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            if (numbers.Any())
            {
                int lowestInt = numbers[0];
                //int lowestId = 0;
                int i = 0;

                foreach (int x in numbers)
                {
                    if (x < lowestInt)
                    {
                        lowestInt = x;
                        //lowestId = i;
                    }
                    i++;
                }

                //numbers.RemoveAt(lowestId);
                numbers.Remove(lowestInt);
            }

            return numbers;
        }
    }
}
