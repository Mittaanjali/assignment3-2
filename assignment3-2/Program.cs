using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Convert a string to an integer using TryParse
            string intString = "123";
            int result;
            if (int.TryParse(intString, out result))
            {
                int multipliedValue = result * 5;
                Console.WriteLine("Integer value multiplied by 5: " + multipliedValue);
            }
            else
            {
                Console.WriteLine("Error: Invalid integer string.");
            }

            // Convert a string to a DateTime object using Convert
            string dateString = "2023-11-08";
            try
            {
                DateTime date = Convert.ToDateTime(dateString);
                date = date.AddMonths(-1);
                Console.WriteLine("DateTime after subtracting 1 month: " + date);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid DateTime format.");
            }

            // Convert a string to a TimeSpan object using Parse
            string timeString = "02:30:45";
            try
            {
                TimeSpan time = TimeSpan.Parse(timeString);
                time = time.Add(new TimeSpan(2, 0, 0)); // Add 2 hours
                Console.WriteLine("TimeSpan after adding 2 hours: " + time);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid TimeSpan format.");
            }
        }
    }
}
    

