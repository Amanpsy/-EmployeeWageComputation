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
        public const int present = 1;
        public const int absent = 0;

        public static void Main(string[] args)
        {
            int empWage = 0;
            int empHour = 0;

            Random random = new Random();
            int option = random.Next(0, 2);
            switch(option)
            {
                case present:
                    Console.WriteLine("Employee is present");
                    empHour = 8;
                    break;

                case absent:
                    Console.WriteLine("employee is absent ");
                    empHour = 0;
                    break;
           }
            empWage = emp_rate_per_hour * empHour;
            Console.WriteLine("the total employee wage is " + empWage);

        }





    
    }
}
