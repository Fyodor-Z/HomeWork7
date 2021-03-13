using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputList = new List<int>();


            var rndm = new Random();
            for (int i = 0; i < (rndm.Next(6) + 10); i++) //number of list elements from 10 to 15
            {
                inputList.Add(rndm.Next(999));
            }

            Console.WriteLine("Given list: " + string.Join(", ", inputList));
        }
    }
}
