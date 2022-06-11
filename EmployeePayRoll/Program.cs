using System;

namespace EmployeePayRoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckEmployeePresentOrAbsent();


        }
         public static void CheckEmployeePresentOrAbsent()
        {
            Console.WriteLine("Welcome to Employee Pay Roll");
            Random r = new Random();
            int wagePerHour = 20;
            int fullDayhour = 8;
            int PartTimeHour = 4;
            int totalWage = 0;
            int number = r.Next(0,3);
            if (number == 0)
            {
                Console.WriteLine("Employee is Absent");
              

            }
            else if(number == 1)
            {
                Console.WriteLine("Employee is Present");
                totalWage = wagePerHour * fullDayhour;
                

            }
            else
            {
                Console.WriteLine("Employee is Present and PartTime Employee");
                totalWage = wagePerHour * PartTimeHour;



            }
            Console.WriteLine("Employee's total wage is:" + totalWage);
        }
    }
}
