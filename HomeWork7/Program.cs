using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork7_1
     /*Write a C# Sharp program to create a new list of the rightmost digits
      from a given list of positive integers.*/
{
    class Program
    {
        static void Main(string[] args)


        {
            var inputList = new List<int>();
                       

            var rndm = new Random();
            for (int i = 0; i < (rndm.Next(6)+5); i++) //number of list elements from 5 to 10
            {
                inputList.Add(rndm.Next(999));
            }

            Console.WriteLine("Given list: " + string.Join(", ", inputList));

            var outputList = inputList.Select(i => i % 10).ToList();

            Console.WriteLine("Output list:  " + string.Join(", ", outputList));
        }
    }
}
