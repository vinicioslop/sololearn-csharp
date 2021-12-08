﻿using System;

namespace AreaDoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Area of a Circle
            *
            * We are going to write a program that will calculate the area of
            * a circle.
            * The area enclosed by a circle of radius r is πr², where π (pi)
            * is the constant ratio of the circumference of any circle to its
            * diameter, and r is the radius.
            * The given program declares a constant pi variable with a value
            * of 3.14.
            * Complete the program to take the radius as input, then calculate
            * and output the area of the circle. 
            */
            const double pi = 3.14;
            double radius;

            //your code goes here
            radius = Convert.ToDouble(Console.ReadLine());

            double area = pi * (radius * radius);
            Console.WriteLine(area);
        }
    }
}