using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmpWage
    {

        public const int emp_rate_per_hour = 20;
        public const int part = 1;
        public const int full = 2;

        public static void Main(string[] args)
        {
            int empWage = 0;
            int empHour = 0;

            Random random = new Random();
            int option = random.Next(0, 3);
            switch(option)
            {
                case part:
                    Console.WriteLine("Employee is working part time");
                    empHour = 4;
                    break;

                case full:
                    Console.WriteLine("employee is working full time");
                    empHour = 8;
                    break;

                case 0:
                    Console.WriteLine("employee is absent");
                    break;
           }
            empWage = emp_rate_per_hour * empHour;
            Console.WriteLine("the total employee wage is " + empWage);

        }





    
    }
}
