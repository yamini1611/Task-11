using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    public class Asyns_Await
    {  
       public static async Task<int> Sumcalculation()
        {
            int i, sum = 0, n;
            Console.Write("Enter the Nth Number : ");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i <= n; i++)
            {

                sum =+ i;
            }
            await Task.Delay(3000);
            return sum;
        }

        static async Task<int> ProductCalculation()
        {
            Console.WriteLine("Enter No of Values to be multiplied");
            int c = int.Parse(Console.ReadLine());
            int mul = 1;
            for (int i = 1; i <= c; i++)
            {
                mul *= i;
            }
            await Task.Delay(100);
            return mul;
           
        }

       public  static async Task Main(string[] args)
        {
            Task<int> sum = Sumcalculation();
            Task<int> product = ProductCalculation();
            var val1 = await sum;
            var val2 = await product;
            Console.WriteLine("Sum of a +b  " + val1);
            Console.WriteLine("Product of a * b " + val2);
            Console.ReadLine();
        }

    }

}
