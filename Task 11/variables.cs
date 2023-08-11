using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
   public  class Variables
    {
        public static int staticvar;
        public readonly int readonlyvar =45;
        public const int constvar = 15;

        public int instancevar;
       
        public Variables(int a) 
        {
            instancevar = a;
            staticvar =a;
            readonlyvar = a;
        }
        public void Value(int val)
        {
            staticvar = val;
        }
        public void Display()
        {
            Console.WriteLine("<--------------------------->");
            Console.WriteLine("Before Modifications");
            Console.WriteLine("<--------------------------->");
            Console.WriteLine("Static variable value :" + staticvar);
            Console.WriteLine("Constant variable value :" + constvar);
            Console.WriteLine("readonly variable value :" + readonlyvar);
            Console.WriteLine("instance variable value :" + instancevar);
            int b;

            Console.WriteLine("<--------------------------->");
            Console.WriteLine("enter value of b");
            b= Convert.ToInt32(Console.ReadLine());
            staticvar =b;
            instancevar =b;
        }
    }

    public class methods
    {
        static void Main(string[] args)
        {
            Variables var = new Variables(20);
            var.Display();
            Console.WriteLine("<--------------------------->");
            Console.WriteLine("After Modifications");
            Console.WriteLine("<--------------------------->");
            Console.WriteLine("Instance value :" + var.instancevar);
            Console.WriteLine("Static value :" + Variables.staticvar);
            Console.WriteLine("Constant value :" + Variables.constvar);
            Console.WriteLine("readonly value :" + var.readonlyvar);
            Console.ReadLine();    
        }
    }
}
