using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
  
                string word = "THIS is UPPERCASE string DD ";

                var result = word.Split(' ')
                                 .Where(w => w.All(char.IsUpper))
                                 .ToList();

               
                Console.WriteLine(string.Join(", ", result));

    }
}
}
