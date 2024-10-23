using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {



            List<int> Numbers = new List<int> { 3, 9, 2, 4, 6, 5, 7 };

            var result = Numbers
                .Select(n => new { Number = n, Square = n * n })
                .Where(x => x.Square > 20)
                .ToList();

            foreach (var item in result)
            {
                Console.WriteLine($"Number: {item.Number}, Square: {item.Square}");
            }



        }
    }
}
