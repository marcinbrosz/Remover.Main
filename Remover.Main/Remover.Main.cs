using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remover.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int> ();
            lista = Remover.Library.Remover.RemoveSmallest(new List<int> { 2, 2, 1, 2, 1 });

            lista.ForEach(Console.WriteLine);

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}
