using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Demo
{
    internal class Program
    {

        public static void SwapByValue(int x, int y)
        {
            int temp = y;
            y = x;
            x = temp;
        }
        public static void SwapByRef(ref int x, ref int y)
        {
            int temp = y;
            y = x;
            x = temp;
        }

        public static void ChangeChar(int charIndex, char newChar,ref StringBuilder str) {

            str[charIndex] = newChar;

        }
        static void Main(string[] args)
        {
            #region Q19) Write a program that prints an identity matrix using for loop, inother words takes a value n from the user and shows the identity table of size n* n.
            //int number;
            //bool parsed;
            //do
            //{
            //    Console.Write("Enter a number more than 1 that will be used for the size of the matrix : ");
            //  parsed=  int.TryParse(Console.ReadLine(), out number);
            //}
            //while (!parsed ||number<=1);

            //int[,] arr = new int[number,number];

            //for (int i = 0; i < arr.GetLength(0); i++) // Row
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++) // Column
            //    {
            //        if (i == j)
            //            arr[i,j] = 1;
            //        else
            //            arr[i,j] = 0;
            //        Console.Write(arr[i,j]);
            //    }
            //    Console.WriteLine();
            //}



            #endregion

            #region Q20) Write a program in C# Sharp to find the sum of all elements of the array.
            //int ArrayLength;
            //bool parsed;
            //do
            //{
            //    Console.Write("Enter the array length ");
            //    parsed = int.TryParse(Console.ReadLine(), out ArrayLength);
            //}
            //while (ArrayLength <= 0 || !parsed);

            //int[] ar = new int[ArrayLength];
            //// loop for getting the values from the user
            //for (int i = 0; i < ar.Length; i++)
            //{
            //    Console.Write($"Enter the {i + 1} Element : ");

            //    int.TryParse(Console.ReadLine(), out ar[i]);

            //}

            //int result = 0;
            //// loop for getting the sum of the elements
            //for (int i = 0; i < ar.Length; i++)
            //{
            //    result += ar[i];
            //}
            //Console.WriteLine($"The sum is : {result}");
            #endregion

            #region Q21) Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int ArrayLength;
            //bool parsed;
            //do
            //{
            //    Console.Write("Enter the array length ");
            //    parsed = int.TryParse(Console.ReadLine(), out ArrayLength);
            //}
            //while (ArrayLength <= 0 || !parsed);

            //int[] fArray = new int[ArrayLength];
            //int[] sArray = new int[ArrayLength];
            //int[] tArray = new int[2 * ArrayLength];

            //for (int i = 0; i < fArray.Length;)
            //{
            //    Console.Write($"Enter an integer values please for the First Array element No {i + 1}  : ");
            //    parsed = int.TryParse(Console.ReadLine(), out fArray[i]);
            //    if (parsed)
            //        i++;
            //}
            //Console.WriteLine("-----------------");
            //for (int i = 0; i < sArray.Length;)
            //{
            //    Console.Write($"Enter an integer values please for the Second Array element No {i + 1}  : ");
            //    parsed = int.TryParse(Console.ReadLine(), out sArray[i]);
            //    if (parsed)
            //        i++;
            //}
            //for (int i = 0; i < fArray.Length; i++)
            //{
            //    tArray[i] = fArray[i]; // Copy first array into total array
            //}
            //for (int i = 0; i < sArray.Length; i++)
            //{
            //    tArray[fArray.Length + i] = sArray[i]; // Copy second array into total array
            //}

            //Array.Sort(tArray);  // using built in funtion  [class member function]

            //for (int i = 0; i < tArray.Length; i++)
            //{
            //    Console.WriteLine(tArray[i]);
            //}



            #endregion

            #region Q22) Write a program in C# Sharp to count the frequency of each element of an array.
            //int ArrayLength;
            //bool parsed;
            //do
            //{
            //    Console.Write("Enter the array length ");
            //    parsed = int.TryParse(Console.ReadLine(), out ArrayLength);
            //}
            //while (ArrayLength <= 0 || !parsed);

            //int[] arr = new int[ArrayLength];

            //for (int i = 0; i < arr.Length;)
            //{
            //    Console.Write($"Enter an integer values please for the First Array element No {i + 1}  : ");
            //    parsed = int.TryParse(Console.ReadLine(), out arr[i]);
            //    if (parsed)
            //        i++;
            //}
            //int counter;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    counter = 1;
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        if (i == j)
            //            continue;
            //        if (arr[i] == arr[j]) {
            //            counter++;
            //        }


            //    }
            //    Console.WriteLine($"This Element {{{arr[i]}}} repeated {counter} time ");   
            //}

            #endregion




        }
    }
}
    

