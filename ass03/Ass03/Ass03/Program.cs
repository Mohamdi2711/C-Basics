using System.Threading;
using System;

namespace Ass03
{
    class Jop
    {
        public string Name { get; set; }
        public string Location { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //Console.Write("Plz Enter The Number : ");
            //int Number = int.Parse(Console.ReadLine());
            //if ( Number % 4 == 0 && Number % 3 == 0)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}
            #endregion

            #region 2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.Write("Plz Enter The Number : ");
            //int Number = int.Parse(Console.ReadLine());
            //if (Number > 0)
            //    Console.WriteLine("Positive");
            //else if (Number < 0)
            //    Console.WriteLine("Negative");
            //else if (Number == 0)
            //    Console.WriteLine("Zero Is Not Positive Or Negative");
            //else
            //    Console.WriteLine("Invalid");
            #endregion

            #region 3- Write a program that takes 3 integers from the user then prints the max element and the min element.
            //Console.WriteLine("Plz Enter The Numbers");
            //Console.Write("Number 01 : ");
            //int Num01 = int.Parse(Console.ReadLine());
            //Console.Write("Number 02 : ");
            //int Num02 = int.Parse(Console.ReadLine());
            //Console.Write("Number 03 : ");
            //int Num03 = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Max element = {Math.Max(Math.Max(Num01, Num02), Num03)}");
            //Console.WriteLine($"Min element = {Math.Min(Math.Min(Num01, Num02), Num03)}");
            #endregion

            #region 4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.Write("Enter The Number :  ");
            //int Number = int.Parse(Console.ReadLine());
            //if (Number == 0)
            //    Console.WriteLine("Zero Not Even Or Odd ");
            //else if (Number % 2 == 0)
            //    Console.WriteLine("Even");
            //else if (Number % 2 != 0)
            //    Console.WriteLine("Odd");
            //else
            //    Console.WriteLine("Invalid");
            #endregion

            #region 5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //Console.WriteLine("Enter The Character : ");
            //char Character = Console.ReadLine().ToLower()[0];
            //if (Character == 'a' || Character == 'e' || Character == 'i' || Character == 'o' || Character == 'u')
            //{
            //    Console.WriteLine("vowel");
            //}
            //else 
            //{
            //    Console.WriteLine("consonant");
            //}
            #endregion

            #region 7- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.Write("Enter Number : ");
            //int Num = int.Parse(Console.ReadLine());
            //int Result = 0;
            //for (int i = 0; i < 12; i++)
            //{
            //    Result += Num;
            //    Console.Write($"{Result} ");
            //}

            #endregion

            #region 9- Write a program that takes two integers then prints the power.
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
            //Console.WriteLine(Math.Pow(Num,Power));

            #endregion

            #region 10- Write a program to enter marks of five subjects and calculate total, average and percentage.
            //Console.WriteLine("Enter Marks Of Subjects");
            //Console.Write("Enter Sub01 : ");
            //int Sub01 = int.Parse(Console.ReadLine());
            //Console.Write("Enter Sub02 : ");
            //int Sub02 = int.Parse(Console.ReadLine());
            //Console.Write("Enter Sub03 : ");
            //int Sub03 = int.Parse(Console.ReadLine());
            //Console.Write("Enter Sub04 : ");
            //int Sub04 = int.Parse(Console.ReadLine());
            //Console.Write("Enter Sub05 : ");
            //int Sub05 = int.Parse(Console.ReadLine());

            //int TotalMarks = Sub01 + Sub02 + Sub03 + Sub04 + Sub05;
            //int AverageMarks = TotalMarks / 5;
            //int Percentage = (int)((TotalMarks / 500.0) * 100);

            //Console.WriteLine($"Total Marks = {TotalMarks}\n" +
            //    $"Average Marks = {AverageMarks}\n" +
            //    $"Percentage = {Percentage}");


            #endregion

            #region 11- Write a program to input the month number and print the number of days in that month.
            //Console.Write("Month Number : ");
            //int Month = int.Parse(Console.ReadLine());

            //switch (Month)
            //{   
            //    case 2:
            //        Console.WriteLine("Days In Month : 28 , In Leap year : 29");
            //        break;

            //    case 1:
            //    case 3:
            //    case 5:    
            //    case 7:    
            //    case 8:    
            //    case 10:    
            //    case 12:
            //        Console.WriteLine("Days In Month : 31 ");
            //        break;


            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("Days In Month : 30");
            //        break;
            #endregion

            #region 17 - Create a program that asks the user to input three points(x1, y1), (x2, y2), and(x3, y3), and determines whether these points lie on a single straight line.
            //Console.WriteLine("Enter (X1 , Y1) ");
            //Console.Write("X1 : ");
            //int X1 = int.Parse(Console.ReadLine());
            //Console.Write("Y1 : ");
            //int Y1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter (X2 , Y2) ");
            //Console.Write("X2 : ");
            //int X2 = int.Parse(Console.ReadLine());
            //Console.Write("Y2 : ");
            //int Y2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter (X3 , Y3) ");
            //Console.Write("X1 : ");
            //int X3 = int.Parse(Console.ReadLine());
            //Console.Write("Y1 : ");
            //int Y3 = int.Parse(Console.ReadLine());

            //int tendencyA = (Y2 - Y1) / (X2-X1);
            //int tendencyB = (Y3 - Y2) / (X3-X2);

            //if (tendencyA == tendencyB)
            //    Console.WriteLine("these points lie on a single straight line.");
            //else
            //    Console.WriteLine("these points not lie on a single straight line.");

            #endregion

            #region 18
            //Console.Write("Enter the number of worker hours : ");
            //double Num = double.Parse(Console.ReadLine());

            //if (Num >= 2 && Num <= 3)
            //    Console.WriteLine("Highly Efficient");
            //else if (Num > 3 && Num <= 4)
            //    Console.WriteLine("increase Your Speed");
            //else if (Num > 4 && Num <= 5)
            //    Console.WriteLine("provid with training to enhance Your speed");
            //else if (Num > 5)
            //    Console.WriteLine("leave the company :( ");
            //else
            //    Console.WriteLine("Invalid");

            #endregion

            #region 21-	Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int x = 5;
            //int y = 10;
            //Console.WriteLine($"Before Modifying X = {x} , Y = {y} ");  //(5,10)
            //y = x;
            //x = 22;
            //Console.WriteLine($"After Modifying X = {x} , Y = {y} ");  //(22,5)
            #endregion

            #region 22-	Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //Jop j01 = new Jop();
            //j01.Name = "Editor";
            //j01.Location = "Cairo";
            //Jop j02 = new Jop();
            //j02 = j01;
            //j02.Name = "Developer";
            //j02.Location = "ALex";

            //Console.WriteLine(j02.Name + " , "+ j02.Location); //(Developer , Alex)
            //Console.WriteLine(j01.Name + " , " + j01.Location); //(Developer , Alex)


            #endregion

            #region 23-	Which of the following statements is correct about the C#.NET code snippet given below?
            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            ///*
            //    a)	A value 0 will be assigned to d.
            //    b)	A value 1 will be assigned to d.  ==>TRUE (Condition will be true and convert (true) = 1 )
            //    c)	A value -1 will be assigned to d.
            //    d)	The code reports an error.
            //    e)	The code snippet will work correctly if ! is replaced by Not.
            // */
            #endregion

            #region 24-	Which of the following is the correct output for the C# code given below?
            //Console.WriteLine(13 / 2 + " " + 13 % 2);

            ///*
            //    a)	6.5 1
            //    b)	6.5 0
            //    c)	6 0
            //    d)	6 1  ==> TRUE (13/2 = 6 Two Type Int So Result = 6 if 13.0/2 Result will = 6.5  ,
            //                       13 % 2 = 1)
            //    e)	6.5 6.5
            // */
            #endregion

            #region 25-	What will be the output of the C# code given below?
            //int num = 1, z = 5;

            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);

            ///*
            //    a)	5 6
            //    b)	6 5
            //    c)	6 6
            //    d)	7 7     ==>TRUE (Condition will be true , ++num (2) And Num = 2  ,
            //                                                  z++   (5) And z   = 6  ,
            //                                                  ++z   (7) And z   = 7   )

            // */
            #endregion
        }

    }
}
