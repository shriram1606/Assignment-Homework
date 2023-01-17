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
            Console.WriteLine("enter 1st subject marks");
            int marks1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd subject marks");
            int marks2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 3rd subject marks");
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
                Console.WriteLine("grade is C");
            }
            else if (percentage >= 50 && percentage <= 75)
            {
                Console.WriteLine("grade is B");
            }
            else if (percentage >= 75)
            {
                Console.WriteLine("grade is A");
            }
        }
    }
}

