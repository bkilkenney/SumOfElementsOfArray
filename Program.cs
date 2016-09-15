using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfElementsOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] exampleArray = { 20, 10, 5, 2 };
            Console.WriteLine("The sum of the example array is " + SumNum(exampleArray));
                                //How does {0} work?                    //SumNum is the method being applied to ExampleArray

            SumNum(exampleArray);  //taking answer from next method and summing it in my array

        }
        static int SumNum(int[] exampleArray)
        {
            int answer = 0;
            for(int i = 0; i < exampleArray.Length; i++) //For loops often used with arrays
            {
                answer += exampleArray[i]; //This lines means variable of "answer" + exampleArray AT THE INDEX OF [i]
            }
        return answer;

        }
    }
}
