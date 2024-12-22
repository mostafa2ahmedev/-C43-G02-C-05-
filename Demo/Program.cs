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
            #region Q23) Write a program in C# Sharp to find maximum and minimum element in an array
            //int ArrayLength;
            //bool parsed;
            //do
            //{
            //    Console.Write("Enter the array length : ");
            //    parsed = int.TryParse(Console.ReadLine(), out ArrayLength);
            //}
            //while (ArrayLength == 0 || !parsed);

            //int[] ar = new int[ArrayLength];

            //for (int i = 0; i < ArrayLength; i++)
            //{
            //    Console.Write($"Enter the {i + 1} Element : ");

            //    int.TryParse(Console.ReadLine(), out ar[i]);

            //}
            //int max = ar[0];
            //int min = ar[0];
            //for (int j = 0; j < ArrayLength; j++)
            //{
            //    if (ar[j] < min)
            //        min = ar[j];
            //    if (ar[j] > max)
            //        max = ar[j];
            //}
            //Console.WriteLine($"min is {min} & max is {max}");

            #endregion


            #region Q24) Write a program in C# Sharp to find the second largest element in an array.

            //int ArrayLength;
            //bool parsed;
            //do
            //{
            //    Console.Write("Enter the array length : ");
            //    parsed = int.TryParse(Console.ReadLine(), out ArrayLength);
            //}
            //while (ArrayLength == 0 || !parsed);

            //int[] ar = new int[ArrayLength];

            //for (int i = 0; i < ar.Length;)
            //{
            //    Console.Write($"Enter an integer values please for the First Array element No {i + 1}  : ");
            //    parsed = int.TryParse(Console.ReadLine(), out ar[i]);
            //    if (parsed)
            //        i++;
            //}

            //int max = ar[0];
            //int sMax = 0;
            //for (int j = 0; j < ArrayLength; j++)
            //{

            //    if (ar[j] > max)
            //    {
            //        sMax = max;
            //        max = ar[j];
            //    }

            //}
            //Console.WriteLine($"Second largest maximum is {sMax} & max is {max}");

            #endregion

            #region Q25)Consider an Array of Integer values with size N, having values as in this Example
            //Console.Write("Enter the size of the array: ");
            //int number;
            //int.TryParse(Console.ReadLine(), out number);

            //int[] arr = new int[number];


            //for (int i = 0; i < number; i++)
            //{
            //    Console.Write($"Enter the array elements No {i + 1}");

            //     int.TryParse(Console.ReadLine(),out arr[i]);
            //}

            //int maxDistance = 0;

            //for (int i = 0; i < number; i++)
            //{
            //    for (int j = number - 1; j > i; j--)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            if ((j - i) > maxDistance)
            //            {
            //                maxDistance = (j - i);
            //            }
            //            break; 
            //        }
            //    }
            //}

            //Console.WriteLine($"The longest distance is: {maxDistance}");
            #endregion

            #region Q26) Given a list of space separated words, reverse the order of the words.
            //string input;
            //do
            //{
            //    Console.WriteLine("Enter a sentence: ");
            //    input = Console.ReadLine();
            //}
            //while (string.IsNullOrEmpty(input));

            //string reversed = string.Join(" ", input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse());

            //Console.Write("Reversed Sentence: ");
            //Console.Write(reversed);

            #endregion

            #region Q27) Write a program to create two multidimensional arrays of same size.Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
            //int ArrayLength;
            //bool parsed;
            //do
            //{
            //    Console.Write("Enter the array length : ");
            //    parsed = int.TryParse(Console.ReadLine(), out ArrayLength);
            //}
            //while (ArrayLength == 0 || !parsed);
            //int[,] fArr = new int[ArrayLength, ArrayLength];

            //for (int i = 0; i < fArr.GetLength(0); i++)
            //{
            //    for (int j = 0;  j < fArr.GetLength(1);  )
            //    {
            //        Console.Write($"Enter the value of the element of {i+1} and {j+1} : ");
            //        parsed= int.TryParse(Console.ReadLine(), out fArr[i, j]);
            //        if (parsed)
            //            j++;
            //    }

            //}

            //int[,] sArr = new int[ArrayLength, ArrayLength];
            //// copy data to the second array
            //for (int i = 0; i < sArr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < sArr.GetLength(1);j++)
            //    {
            //        sArr[i, j] = fArr[i, j];

            //    }

            //}
            //// print the second array
            //for (int i = 0; i < sArr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < sArr.GetLength(1); j++)
            //    {
            //        Console.Write(sArr[i,j]);

            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region Q28) Write a Program to Print One Dimensional Array in Reverse Order
            //int ArrayLength;
            //bool parsed;
            //do
            //{
            //    Console.Write("Enter the array length : ");
            //    parsed = int.TryParse(Console.ReadLine(), out ArrayLength);
            //}
            //while (ArrayLength == 0 || !parsed);

            //int[] ar = new int[ArrayLength];


            //for (int i = 0; i < ar.Length;)
            //{
            //    Console.Write($"Enter an integer values please for the First Array element No {i + 1}  : ");
            //    parsed = int.TryParse(Console.ReadLine(), out ar[i]);
            //    if (parsed)
            //        i++;
            //}
            //// Loop for printing the array in reversed order
            //for (int i = ar.Length-1; i>=0; i--)
            //{
            //    Console.Write($"{ar[i]} ");   
            //}


            #endregion

            /*Functions*/


            #region Q1) Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            /** passing by value for value type parameters
             * {when we pass by value for the value type parameter
             * only the data is copied to the parameters  and these parameters acts as a new parameters inside the function}
             * passing by reference for value type parameters
             * the actual place is copies to the parameters so the parameters using the actual address of the variables that passed
             * so if there is new change happened to the parameters it will reflected directly to the actual variables */

            //Passing value types parameters by value
            //int A = 10, B = 20;
            //SwapByValue(A, B);
            //Console.WriteLine($"A :  {A}");
            //Console.WriteLine($"B :  {B}");
            //Console.WriteLine("-------");
            ////Passing value types parameters by ref
            //SwapByRef(ref A, ref B);
            //Console.WriteLine($"A :  {A}");
            //Console.WriteLine($"B :  {B}");
            #endregion

            #region Q2) Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //int Number;
            //do
            //{
            //    Console.Write("Enter a number : ");
            //    int.TryParse(Console.ReadLine(), out Number);
            //}
            //while (Number==0);
            //int mod;
            //int result = 0;
            //while (Number > 0) {
            //    mod = Number % 10;
            //    Number /= 10;
            //    result += mod;
            //}
            //Console.WriteLine($"result is : {result}");

            #endregion

            #region Q3) Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not .
            //int number;
            //bool parsed;
            //do
            //{
            //    Console.Write("Enter a number : ");
            //    parsed = int.TryParse(Console.ReadLine(), out number);
            //}
            //while (!parsed );

            //bool isPrime = true ;
            //if (number <= 1)
            //{
            //    isPrime = false;
            //}
            //else {
            //    for (int i = 2; i < number-1; i++)
            //    {
            //        if (number % i == 0)
            //        {  //5
            //            isPrime = false;
            //            break;
            //        }

            //    }
            //}
            //if (isPrime) 
            //    Console.WriteLine("Prime");
            //else
            //    Console.WriteLine("Not Prime");


            #endregion







        }
    }
}
    

