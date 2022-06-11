using System;

namespace EmployeePayRoll
{
    internal class Program
    {
        public const int IsPartTime = 1;
        public const int IsFullTime = 2;
        public const int IsAbsent = 0;
        public const int WagePerHour = 20;
        public const int NumberOfWorkingDays = 20;
        public const int MaxHrsInMonth = 100;
        static void Main(string[] args)
        {
            int empHrs = 0, empwage = 0, TotalWage = 0;
            
            for (int day = 0; day < NumberOfWorkingDays; day++)
            {
                Random random = new Random();
                int number = random.Next(0, 3);

                switch (number)
                {
                    case IsAbsent:
                        empHrs = 0;
                        break;

                    case IsFullTime:
                        empHrs = 8;
              
                        break;
                    case IsPartTime:
                        empHrs = 4;
                     
                        break;
                }

                empwage = empHrs * WagePerHour;
                TotalWage += empwage;
                Console.WriteLine("Emp Wage : " + empwage);


            }
            Console.WriteLine("Total Emp Wage : " + TotalWage);
        }
    }
}
