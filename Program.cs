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
            Console.WriteLine("The sum of the example array is {}", SumNum(exampleArray));
                                //How does {0} work?                    //This an equation multiplying the 2?
            SumNum(exampleArray);

        }
        static int SumNum(int[] exampleArray)
        {
            int answer = 0;
            for(int i = 0; i < exampleArray.Length; i++)
            {
                Console.WriteLine(exampleArray[i]);
            }
        return answer;

        }
    }
}
