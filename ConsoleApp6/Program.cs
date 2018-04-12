using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("This program is used to find the difference betwwent two dates. Pleas enter a date int the following format: yyyy-mm-dd.");
                string Start = Console.ReadLine();
                DateTime StartDate = DateTime.Parse(Start);
                

                Console.WriteLine("Please type in another date in the following format: yy-mm-dd");
                string End = Console.ReadLine();
                DateTime EndDate = DateTime.Parse(End);



                Console.WriteLine("Start Date: " + StartDate);
                Console.WriteLine("End Date: " + EndDate);

                TimeSpan DateDifference;
                if (StartDate > EndDate)
                {
                    DateDifference = StartDate - EndDate;
                }
                else
                {
                    DateDifference = EndDate - StartDate;
                }

                Console.WriteLine(DateDifference.TotalDays + " Days");

                Console.WriteLine(DateDifference.TotalHours + " Hours");
                Console.WriteLine(DateDifference.TotalMinutes + " Minutes");
            }
            catch
            {
                Console.WriteLine("User Input was not in date format.");
            }

        }
    }
}
