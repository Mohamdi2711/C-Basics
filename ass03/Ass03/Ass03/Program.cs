namespace Ass03
{
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
            Console.WriteLine("Enter Marks Of Subjects");
            Console.Write("Enter Sub01 : ");
            int Sub01 = int.Parse(Console.ReadLine());
            Console.Write("Enter Sub02 : ");
            int Sub02 = int.Parse(Console.ReadLine());
            Console.Write("Enter Sub03 : ");
            int Sub03 = int.Parse(Console.ReadLine());
            Console.Write("Enter Sub04 : ");
            int Sub04 = int.Parse(Console.ReadLine());
            Console.Write("Enter Sub05 : ");
            int Sub05 = int.Parse(Console.ReadLine());

            int TotalMarks = Sub01+ Sub02 + Sub03+ Sub04+ Sub05;
            int AverageMarks = TotalMarks/5;
            int Percentage = (TotalMarks / 500)* 100;
            Console.WriteLine("Total Marks = { }");



            #endregion
        }
    }
}
