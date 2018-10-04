using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Math_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose to 1. Find Area  2. Find Volume  3. Convert Temperature");
            int choice = Convert.ToInt32(Console.ReadLine());
            int choice2 = 0;

            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Choose to Find Area for 1. 2D rectangle  2. Triangle  3. Circle ");
                        choice2 = Convert.ToInt32(Console.ReadLine());
                        area(choice2);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Choose to Find Volume for 1. Triangular pyramid  2. Box  3. Sphere");
                        choice2 = Convert.ToInt32(Console.ReadLine());
                        volume(choice2);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Choose to Convert Temperature from 1. Fahrenheit to Celsius 2. Celsius to Fahrenheit");
                        choice2 = Convert.ToInt32(Console.ReadLine());
                        temp(choice2);
                        break;
                    }
            }
            Console.ReadKey();
        }

        public static void area(int choice2)
        {
            double sum = 0;
            switch (choice2)
            {
                case 1:
                    {
                        Console.WriteLine("width :");
                        double width = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("length :");
                        double length = Convert.ToDouble(Console.ReadLine());
                        sum = width * length;
                        Console.WriteLine("The area for the 2D Rectangle is : " + sum);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("height :");
                        double height = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("base :");
                        double base1 = Convert.ToDouble(Console.ReadLine());
                        sum = (height * base1) / 2;
                        Console.WriteLine("The area for the Triangle is : " + sum);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("radius :");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        sum = Math.PI*Math.Pow(radius,2);
                        Console.WriteLine("The area for the Circle is : " + sum);
                        break;
                    }
            }
        }
        public static void volume(int choice2)
        {
            double sum = 0;
            switch (choice2)
            {
                case 1:
                    {
                        Console.WriteLine("width of the Base :");
                        double width = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("length of the Base :");
                        double length = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("height :");
                        double height = Convert.ToDouble(Console.ReadLine());
                        sum = ((width * length)*(height)/3);
                        Console.WriteLine("The Volume for the Triangular pyramid is : " + sum);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("length :");
                        double length = Convert.ToDouble(Console.ReadLine());
                        sum = Math.Pow(length,3);
                        Console.WriteLine("The Volume for the Box is : " + sum);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("radius :");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        sum = 4*(Math.PI * Math.Pow(radius, 3))/3;
                        Console.WriteLine("The Volume for the Sphere is : " + sum);
                        break;
                    }
            }
        }
        public static void temp(int choice2)
        {
            double sum = 0;
            switch (choice2)
            {
                case 1:
                    {
                        Console.WriteLine("degrees of Fahrenheit :");
                        double fah = Convert.ToDouble(Console.ReadLine());
                        sum = (fah-32)*5/9;
                        Console.WriteLine(fah +" degrees of Fahrenheit : " + sum+" degrees of Celsius");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("degrees of Celsius :");
                        double cel = Convert.ToDouble(Console.ReadLine());
                        sum = (cel*9/5)+32;
                        Console.WriteLine(cel + " degrees of Celsius : " + sum + " degrees of Fahrenheit");
                        break;
                    }
            }
        }
    }
}
