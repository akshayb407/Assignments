using System;

namespace EmployeePayRoll
{
    internal class Program
    {
        public const int IsPartTime = 1;
        public const int IsFullTime = 2;
        public const int IsAbsent = 0;

        static void Main(string[] args)
        {
            int TotalWage = 0;
            int WagePerHour = 20;
            int PartTimeHour = 4;
            int FullTimeHour = 8;
            int NumberOfWorkingDays = 20;

            for (int i = 0; i < NumberOfWorkingDays; i++)
            {
                Random random = new Random();
                int number = random.Next(0, 3);

                switch (number)
                {
                    case IsAbsent:
                        Console.WriteLine("Employee is Absent");
                        break;
                    case IsFullTime:
                        Console.WriteLine("Employee is fulltime");
                        TotalWage = TotalWage + WagePerHour * FullTimeHour;
                        break;
                    case IsPartTime:
                        Console.WriteLine("Employee is Present and PartTime Employee");
                        TotalWage = TotalWage + WagePerHour * PartTimeHour;
                        break;
                }
                    Console.WriteLine("Employee's total wage is:" + TotalWage);


            }

        }
    }
}
