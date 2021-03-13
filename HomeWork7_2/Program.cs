using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork7_2
    //Write a program in C# Sharp to count the frequency of each element of an array.
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputList = new List<int>();


            var rndm = new Random();
            for (int i = 0; i < (rndm.Next(6) + 15); i++) //number of list elements from 15 to 20
            {
                inputList.Add(rndm.Next(10));
            }

            Console.WriteLine("Given list: " + string.Join(", ", inputList));

            var uniqueList = inputList.Distinct().ToList(); //make a new list to avoid repeating of elements

            foreach (var item in uniqueList) 
            {
                Console.WriteLine($"Element:  {item} frequency: {inputList.Where(i => i== item).Count()}");
            }
        }
    }
}
