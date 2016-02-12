using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>();
            List<string> words = new List<string>();

            Console.OpenStandardOutput();
            bool inputtingData = true;

            while (inputtingData)
            {
                Console.Write("Enter integers or text: (type ? to end)");
                string data = Console.ReadLine();
                if (data == "?")
                {
                    inputtingData = false; //check for end
                    break;
                }
                int result;
                if (int.TryParse(data, out result)) //integer or text check
                {
                    Numbers.Add(result);
                }
                else
                {
                    words.Add(data);
                }
            }

            // compute avg, sum, min, max using functions (methods) and then print to console
            Console.Write("Integers entered: ");
            for (int i = 0; i < Numbers.Count; i++) //output number of integers entered
            {
                Console.WriteLine(Numbers[i]);
            }

            Decimal average = avgfunc(Numbers); //call function to compute average
            Console.WriteLine("The average value is: {0}", average); //output average

            int sum = sumfunc(Numbers);
            Console.WriteLine("The sume is: {0}", sum);

            int max = maxfunc(Numbers);
            Console.WriteLine("The maximum value is: {0}", max);

            int min = minfunc(Numbers);
            Console.WriteLine("The minimum value is: {0}", min);

            Console.Write("Text entered: "); //output text entered
            foreach (string chars in words)
            {
                Console.WriteLine(chars);
            }

            Console.ReadLine();  // keeps the console window open
        }

        static Decimal avgfunc(List<int> vars)
        {
            //Decimal avg = 0.0m;
            Decimal avg = vars.Sum() / vars.Count;
            return avg;
        }

        static int sumfunc(List<int> vars)
        {
            int sum = vars.Sum();
            return sum;
        }

        static int maxfunc(List<int> vars)
        {
            int max = vars.Max();
            return max;
        }

        static int minfunc(List<int> vars)
        {
            int min = vars.Min();
            return min;
        }
    }
}
