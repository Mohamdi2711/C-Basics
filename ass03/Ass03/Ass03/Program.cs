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
            #endregion

            #region 3- Write a program that takes 3 integers from the user then prints the max element and the min element.
            Console.WriteLine("Plz Enter The Numbers");
            Console.Write("Number 01 : ");
            int Num01 = int.Parse(Console.ReadLine());
            Console.Write("Number 02 : ");
            int Num02 = int.Parse(Console.ReadLine());
            Console.Write("Number 03 : ");
            int Num03 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Max element = {Math.Max(Math.Max(Num01,Num02),Num03)}");
            Console.WriteLine($"Min element = {Math.Min(Math.Min(Num01, Num02), Num03)}");
            #endregion
        }
    }
}
