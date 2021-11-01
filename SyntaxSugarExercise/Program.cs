using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = 15;
            
            var response = (answer < 9) ? $"{answer} is less than nine" :
                (answer == 15) ? $"{answer} is 15!" :
                (answer == 50) ? $"{answer} is 50!" :
                $"{answer} greater than or equal to nine";

            Console.WriteLine(response); 

          
        }
    }
}
