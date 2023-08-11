using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    internal class Cla
    {
        public static void Main(string[] args)
        {
            int id = Convert.ToInt32(args[0]);

            string name = Convert.ToString(args[1]);

            int age = Convert.ToInt32(args[2]);

            string designation = Convert.ToString(args[3]);

            Console.WriteLine($" Id {id} ,  Employee {name} , Age {age} , Designation {designation}  ");
            Console.ReadLine();
        }
    }
}
