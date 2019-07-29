using System;

namespace ArrayApplication
{
    class MyArray
    {
        static void Main(string[] args)
        {
            int[] n = new int[10]; // n is an array of 10 integers
            int i, j;

            // initialise elements of array n
            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            //output each array elements value
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            }
            Console.ReadKey();
        }
    }
}
