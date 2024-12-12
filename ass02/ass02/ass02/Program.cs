using System.Drawing;

namespace ass02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  1
            //Console.Write("Enter your number : ");
            //int Num = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Your Number is ({Num})");
            #endregion

            #region 2
            //int x = 5;
            //int y = 10;
            //Console.WriteLine($"Before Modifying X = {x} , Y = {y} ");  //(5,10)
            //y = x;
            //x = 22;
            //Console.WriteLine($"After Modifying X = {x} , Y = {y} ");  //(22,5)
            #endregion

            #region 3
            Point p1;
            p1 = new Point(5, 10);
            Point p2 = new Point(15, 20);
            Console.WriteLine((p1.X, p1.Y));  //(5, 10)
            Console.WriteLine((p2.X, p2.Y));  //(15,20)
            Console.WriteLine("************************************************");
            p2 = p1;
            Console.WriteLine((p1.X, p1.Y));//(5,10)
            Console.WriteLine((p2.X, p2.Y));//(5,10)

            #endregion
        }
    }
}
