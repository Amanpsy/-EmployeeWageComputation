using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class attendence
    {
        public static void Main(string[] args)
        {
            int present = 0;
            int absent = 0;

            
            Random random = new Random();
            int option = random.Next(0, 2);
            switch(option)
            {
                case 0:

                    Console.Write("employee is present");
                    break;

                    case 1:

                    Console.WriteLine("employee is absent");
                    break ;
                   

            }
             
         
           

        }

    }
}
