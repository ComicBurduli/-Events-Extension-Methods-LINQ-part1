using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Linq;

namespace homework_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            List<int> Numbers = new List<int> { 30, 54, 3, 14, 25, 82, 1, 100, 23, 95 };

            var result = Numbers.Where(n => n > 30 && n < 100).ToList();


            Console.WriteLine(string.Join(", ", result));




            Console.WriteLine();



            //task2
            List<string> animals = new List<string> { "zebra", "elephant", "cat", "dog", "rhino", "bat" };

            var result2 = animals.Where(a => a.Length >= 5)
                                .Select(a => a.ToUpper())
                                .ToList();


            Console.WriteLine(string.Join(", ", result2));




            //task 3




            List<string> words = new List<string>
        {
            "alabam", "am", "balalam", "tara", "", "a", "axeliam", "39yo0m", "trol"
        };

            var result3 = words.Where(w => w.StartsWith("a") && w.EndsWith("m")).ToList();


            Console.WriteLine(string.Join(", ", result3));
        }
    }





}