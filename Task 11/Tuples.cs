using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_11
{
    internal class Tuples
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Count");
            int count = int.Parse(Console.ReadLine());
            for(int i=0; i<count; i++)
            {
                Console.WriteLine("Enter Name :");
                var Name =Console.ReadLine();
                Console.WriteLine("Enter Age :");
                var Age =Console.ReadLine();
                Console.WriteLine("Enter Degree :");
                var Degree =Console.ReadLine();
                Console.WriteLine("Department :");
                var Department =Console.ReadLine();

                var details = (Name, Age, Degree, Department);

                Console.WriteLine($"Employeee {details.Name} of Age {details.Age} Studied {details.Degree} is working in Department {details.Department}");

            }
            Console.ReadLine();
        }
    }
}

namespace TupleArgument
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Degree { get; set; }
        public string Department { get; set; }
        public string Company { get; set; }
    }

    public class Tuple
    {
        public void TupleDisplay(Employee employee)
        {
            if (employee.Company == "G2")
            {
                Console.WriteLine($"Employee {employee.Name} of Age {employee.Age} Studied {employee.Degree} is working in Department of {employee.Department} at {employee.Company}");
            }
            else if (employee.Company == "CG-VAK")
            {
                Console.WriteLine($"Employee {employee.Name} of Age {employee.Age} Studied {employee.Degree} is working in Department of {employee.Department} at {employee.Company}");
            }
            else
            {
                Console.WriteLine("Invalid Company Name");
            }
        }
    }

    public class Display
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Count");
            int count = int.Parse(Console.ReadLine());
            List<Employee> employeeList = new List<Employee>();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter Name :");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter Age :");
                int Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Degree :");
                string Degree = Console.ReadLine();
                Console.WriteLine("Department :");
                string Department = Console.ReadLine();
                Console.WriteLine("Enter Company");
                string Company = Console.ReadLine();

                Employee employee = new Employee
                {
                    Name = Name,
                    Age = Age,
                    Degree = Degree,
                    Department = Department,
                    Company = Company
                };

                employeeList.Add(employee);
            }

            Tuple tuple = new Tuple();

            Console.WriteLine("\nEmployee Details:");
            foreach (var employee in employeeList)
            {
                tuple.TupleDisplay(employee);
            }

            Console.ReadLine();
        }
    }
}

