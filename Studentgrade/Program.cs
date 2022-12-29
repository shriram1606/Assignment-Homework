using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentgrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total;
            float percentage;
            Console.WriteLine("enter first subject marks");
            int marks1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second subject marks");
            int marks2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third subject marks");
            int marks3 = Convert.ToInt32(Console.ReadLine());

            total = marks1 + marks2 + marks3;
            percentage = total / 3.0f;
            Console.WriteLine("total marks :" + total);
            Console.WriteLine("percentage is " + percentage);
            if (percentage <= 40)
            {
                Console.WriteLine("grade is fail");
            }
            else if (percentage >= 40 && percentage <= 50)
            {
                Console.WriteLine("grade is c");
            }
            else if (percentage >= 50 && percentage <= 75)
            {
                Console.WriteLine("grade is b");
            }
            else if (percentage >= 75 && percentage <= 80)
            {
                Console.WriteLine("grade is a");
            }
        }
    }
}

