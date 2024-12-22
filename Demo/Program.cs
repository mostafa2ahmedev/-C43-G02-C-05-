using System.Security.Principal;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q19)Write a program that prints an identity matrix using for loop, inother words takes a value n from the user and shows the identity table of size n* n.
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

            #region Q20)Write a program in C# Sharp to find the sum of all elements of the array.
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

            
        }
    }
}
