﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndHeap
{
    class Program
    {
   
        static void Main(string[] args)
        {
            BirthYear birthYear = new BirthYear("opemipo",14); //Reference to birthyear stored in the stack although birth year it self is stored in the heap
            birthYear.AddYear();//makes changes my adding a year to age in the heap
            birthYear.DisplayResult();//display the values
            Console.ReadLine();
        }
    }
}
