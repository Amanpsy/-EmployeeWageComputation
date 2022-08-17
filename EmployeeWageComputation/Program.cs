using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class Program
    {
        public const int part_time = 1;
        public const int full_time = 2;
        public const int empRateperHour = 20;
        public const int numberOfworkingDays = 20;
        public const int maxHoursinMonth = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            int empHrs, totalEmpWage, totalWorkingDays = 0, totalEmpHrs = 0;

            Random random = new Random();
            while (totalWorkingDays < numberOfworkingDays &&  totalEmpHrs <= maxHoursinMonth)
            {
                totalWorkingDays++;
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case part_time:
                        empHrs = 4;
                        break;
                    case full_time:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;


                Console.WriteLine(" day number  " + totalWorkingDays + "working hours = " + empHrs);
            }
            totalEmpWage = totalEmpHrs * empRateperHour;
            Console.WriteLine("Monthly employee wage = " + totalEmpWage);
            
        }
    }
}