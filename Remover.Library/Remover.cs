using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * If there are multiple elements with the same value, remove the one with a lower index
 */
namespace Remover.Library
{
    public class Remover
    {
        


        public static List<int> RemoveSmallest(List<int> numbers)
        {


            //numbers = numbers.Take(numbers.IndexOf(numbers.Min()))
            //.Concat(numbers.Skip(numbers.IndexOf(numbers.Min()) + 1))
            //.ToList();
            //return numbers;
            //---------------------------------------------------------------------------
            //numbers.Remove(numbers.Min());
            //return numbers;
            //---------------------------------------------------------------------------
            //with linq
            IEnumerable<int> test = 
            numbers.Where((x,i)=> numbers.Any() && i!=numbers.IndexOf(numbers.Min()));
            return test.ToList();
            //---------------------------------------------------------------------------
            //numbers.Remove(numbers.Where(x => x == numbers.Min()).First());
            //return numbers;
            //---------------------------------------------------------------------------
            //numbers.Remove(numbers.FirstOrDefault(n => n == numbers.Min()));
            //return numbers;
            //---------------------------------------------------------------------------
            /*if (numbers.Any())
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

            return numbers;*/
        }
    }
}
