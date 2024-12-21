using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using System.Numerics;
using System;

namespace Ass04
{
    internal class Program
    {
        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            #region 1 - Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.Write("Enter Num : ");
            //int Num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= Num; i++)
            //{
            //    if (i == Num)
            //    {
            //        Console.Write($"{i}");
            //        break;
            //    }
            //    Console.Write($"{i}, ");
            //}

            #endregion

            #region 2- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.Write("Enter Number : ");
            //int Num = int.Parse(Console.ReadLine());
            //int Result = 0;
            //for (int i = 0; i < 12; i++)
            //{
            //    Result += Num;
            //    Console.Write($"{Result} ");
            //}

            #endregion

            #region 3- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.Write("Enter Num : ");
            //int Num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= Num; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.Write($"{i} ");
            //}

            #endregion

            #region 4- Write a program that takes two integers then prints the power.
            //Console.Write("Enter The Num : ");
            //int Num = int.Parse(Console.ReadLine());
            //Console.Write("Enter The Power : ");
            //int Power = int.Parse(Console.ReadLine());
            //int Result = 1;
            //for (int i = 0; i < Power; i++)
            //{
            //    Result *= Num;
            //}
            //Console.WriteLine(Result);
            //Console.WriteLine(Math.Pow(Num, Power));
            #endregion

            #region 5- Write a program to allow the user to enter a string and print the REVERSE of it.
            //Console.WriteLine("Enter Name : ");
            //string Name = Console.ReadLine();
            //for (int i = Name.Length-1; i >= 0; i--)
            //{
            //    Console.Write(Name[i]);
            //}
            #endregion

            #region 6- Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Console.Write("Enter Number Of Start Range : ");
            //int StartRange = int.Parse(Console.ReadLine());
            //Console.Write("Enter Number Of End Range : ");
            //int EndRange = int.Parse(Console.ReadLine());

            //for (int i = StartRange; i <= EndRange; i++)
            //{
            //    if (IsPrime(i))
            //    {
            //        Console.Write($"{i} ");
            //    }
            //}
            #endregion

            #region 7- . Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //Console.Write("Enter number You Want Convert To Binary : ");
            //int num = int.Parse(Console.ReadLine());
            //string binary = "";

            //while (num > 0)
            //{
            //    binary = $"{(num % 2)} "+ binary;
            //    num /= 2;
            //}

            //Console.WriteLine(binary);
            #endregion

            #region 8- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //Console.Write("Enter Size Of Array : ");
            //int N = int.Parse(Console.ReadLine());
            //int[,] IdentityMatrix = new int[N, N];
            //for (int i = 0; i < IdentityMatrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < IdentityMatrix.GetLength(1); j++)
            //    {
            //        if (i == j)
            //        {
            //            IdentityMatrix[i, j] = 1;
            //        }
            //        Console.Write($"{IdentityMatrix[i, j]} ");
            //    }
            //    Console.WriteLine("  ");
            //}


            #endregion

            #region 9- Write C# program that Extract a substring from a given string.
            //Console.Write("Enter Your Name : ");
            //string Name = Console.ReadLine();

            //Console.Write("Enter Start Length To Extruct : ");
            //int StartLen = int.Parse(Console.ReadLine());

            //Console.Write("Enter Length Of Chars : ");
            //int CharLen = int.Parse(Console.ReadLine());

            //for (int i = StartLen ; i < StartLen+ CharLen ; i++)
            //{   
            //    Console.Write(Name[i]);
            //}
            //Console.WriteLine(" ");
            //Console.WriteLine(Name.Substring(StartLen,CharLen));
            #endregion

            #region 10- Write C# program that take two string variables and print them as one variable 
            //Console.Write("Enter Frist Name : ");
            //string FristName = Console.ReadLine();

            //Console.Write("Enter Last Name : ");
            //string LastName = Console.ReadLine();

            //Console.WriteLine($"Your Full Name Is [{FristName + " " +LastName}]");

            //Console.Write("Enter Frist Name : ");
            //StringBuilder Name = new StringBuilder();
            //Name.Append( Console.ReadLine() );

            //Console.Write("Enter Last Name : ");
            //Name.AppendLine($" {Console.ReadLine()}");

            //Console.WriteLine(Name);
            #endregion

            #region 11- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //Repeated In Q.8
            #endregion

            #region 12- Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] Arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int Sum = 0;
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    Sum += Arr[i];
            //}
            //Console.WriteLine($"The Sum Element in Array = {Sum}");

            //If 2D

            //int[,] Arr = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
            //int Sum = 0;

            //for (int i = 0; i < Arr.GetLength(0); i++)
            //{ 
            //    for (int j = 0; j < Arr.GetLength(1); j++)
            //    {
            //        Sum += Arr[i, j];
            //    }
            //}
            //Console.WriteLine($"The Sum Element in Array = {Sum}");
            #endregion

            #region 13- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int[] Arr01 = { 1, 2, 3, 4 };
            //int[] Arr02 = { 5, 6, 7, 8 };
            //int N = Arr01.Length;
            //int[] MergeArr = new int[N * 2];

            //int i = 0, j = 0, k = 0;
            //while (i < N && j < N)
            //{
            //    if (Arr01[i] <= Arr02[j])
            //    {
            //        MergeArr[k++] = Arr01[i++];
            //    }
            //    else
            //    {
            //        MergeArr[k++] = Arr02[j++];
            //    }
            //}
            //while (i < N)
            //{
            //    MergeArr[k++] = Arr01[i++];
            //}

            //while (j < N)
            //{
            //    MergeArr[k++] = Arr02[j++];
            //}

            //Array.Sort(MergeArr);
            //foreach (int Res in MergeArr)
            //    Console.WriteLine(Res);

            //************************************************************
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };
            //int[] MergeArr = new int[Arr01.Length];

            //for (int i = 0; i < Arr01.Length; i++)
            //{
            //    MergeArr[i] = Arr01[i] + Arr02[i];
            //}
            //foreach (int i in MergeArr) 
            //    Console.WriteLine(i);
            #endregion

            #region 14- Write a program in C# Sharp to count the frequency of each element of an array.
            //int[] arr = { 1, 2, 3, 4, 5, 4, 2, 2, 4, 1 };


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] != -1)
            //    {
            //        int count = 1;
            //        for (int j = i + 1; j < arr.Length; j++)
            //        {
            //            if (arr[i] == arr[j])
            //            {
            //                count++;
            //                arr[j] = -1;
            //            }
            //        }
            //        Console.WriteLine($"{arr[i]} appears {count} times");
            //    }
            //}

            #endregion

            #region 15- Write a program in C# Sharp to find maximum and minimum element in an array
            //int[] arr = {22,82,27,98,514};

            //int min = arr[0];
            //int max = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (min > arr[i])
            //    {
            //        min = arr[i];
            //    }
            //}
            //Console.WriteLine($"the min value is : {min}" );
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (max < arr[i])
            //    {
            //        max = arr[i];
            //    }
            //}
            //Console.WriteLine($"the max value is : {max}");
            #endregion

            #region 16- Write a program in C# Sharp to find the second largest element in an array.
            //int[] arr = { 51, 73, 24, 54, 25 };
            //Array.Sort(arr);
            //Console.WriteLine(arr[arr.Length-2]);
            #endregion

            #region Q.17
            //Console.Write("Enter Size Of Array : ");
            //int Size = int.Parse(Console.ReadLine());

            //int[] Arr = new int[Size];
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    Console.Write($"Enter Element [{i}] : ");
            //    Arr[i] = int.Parse(Console.ReadLine());
            //}
            //int distance = 0;
            //int MaxD = 0;
            //if (Arr[0] == Arr[Arr.Length - 1])
            //{
            //    Console.WriteLine($"The Number Of Cells = {Arr.Length - 2}");
            //}
            //else
            //{
            //    for (int i = 0; i < Arr.Length; i++)
            //    {
            //        for (int j = 1; j < Arr.Length; j++)
            //        {
            //            if (Arr[i] == Arr[j])
            //            {
            //                distance = j - i - 1;
            //                MaxD = Math.Max(MaxD, distance);
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine($"The Number Of Cells = {MaxD}");
            #endregion

            #region 18- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
            //Console.WriteLine("Enter Size Of Array : ");
            //Console.Write("Rows = ");
            //int Row = int.Parse(Console.ReadLine());
            //Console.Write("Columns = ");
            //int Column = int.Parse(Console.ReadLine());

            //int[,] Arr01 = new int[Row, Column];
            //int[,] Arr02 = new int[Row, Column];


            //for (int i = 0; i < Arr01.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Arr01.GetLength(1);)
            //    {
            //        bool flag;
            //        Console.Write($"Element [{i},{j}] : ");
            //        flag = int.TryParse(Console.ReadLine(), out Arr01[i, j]);

            //        //if(flag && Marks[i,j]>=0)
            //        //{
            //        //    j++; 
            //        //}

            //        j = flag && Arr01[i, j] >= 0 ? ++j : j;

            //    }
            //    Console.WriteLine(" ");
            //}


            //for (int i = 0; i < Arr02.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Arr02.GetLength(1); j++)
            //    {
            //        Arr02[i,j] = Arr01[i,j];
            //    }
            //}

            //OR == >  Array.Copy(Arr01,Arr02,Arr01.Length)

            //for (int i = 0; i < Arr02.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Arr02.GetLength(1); j++)
            //    {
            //        Console.Write($"{Arr02[i, j]} "); 
            //    }
            //    Console.WriteLine(" ");
            //    Console.WriteLine(" ");
            //}
            #endregion

            #region 19- Write a Program to Print One Dimensional Array in Reverse Order
            //int[] Arr01 = { 1, 2, 3, 4, 5, 6, 7 };

            //for (int i = Arr01.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(Arr01[i]);
            //}

            //OR  == >  Array.Reverse(Arr01);



            #endregion


        }
    }
}