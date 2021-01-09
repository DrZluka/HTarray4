using System;

namespace HTarray4
{
    class Program
    {
        static void WhatIsThis(ref int[] array)
        {
            int[] newArray = new int[array.Length];

            newArray[0] = array[3];
            newArray[1] = array[2];
            newArray[2] = array[0];
            newArray[3] = array[1];
            newArray[4] = array[9];
            newArray[5] = array[7];
            newArray[6] = array[8];
            newArray[7] = array[6];
            newArray[8] = array[4];
            newArray[9] = array[5];

            array = newArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 8, 10, 1, 0, 55, 77, 22, 20, 21, 12 };//[0, 1, 8, 10, 12, 20, 21, 22, 55, 77]

            WhatIsThis(ref myArray);

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            
        }
    }
}
