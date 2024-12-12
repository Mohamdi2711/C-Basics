using System.Drawing;

namespace Demo02
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Error Types
            #region Syntax Error - Compilation Error
            //console.WriteLine("Hello World");
            //iint x;
            #endregion
            #region RunTime Error
            //int x = 5;
            //int y = 0;
            //Console.WriteLine(x / y);
            #endregion
            #region Locaial Error
            //int a = 88;
            //int b = 22;
            //Console.WriteLine(sum(a, b));  //User Want A+B But Output is A-B (Logical Error)
            #endregion
            #region Warning
            //int x =5;   The variable 'x' is assigned but its value is never used

            #endregion
            #endregion

            #region Variable
            int x = 5;
            #endregion

            #region CTL-CLS
            //string name = "mostafa";//8 Byte
            //name = "Ali"

            #endregion

            #region value type
            //int a;
            //Console.WriteLine(a);
            //a=5;
            //int b = 10;
            //a = b;

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine("--------------------------------------------");
            //a++;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            #endregion

            #region reference type
            //point p1;
            //p1= new point();
            //point p2= new point();
            //Console.WriteLine(p1.GetHashCode());
            //Console.WriteLine(p2.GetHashCode()); 
            //Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            //p1 = p2;
            //Console.WriteLine(p1.GetHashCode());
            //Console.WriteLine(p2.GetHashCode());
            #endregion

            #region object
            //point p01=new point();

            //object obj1=new object();
            //object obj2 = new object();
            //Console.WriteLine(obj1.GetHashCode());
            //Console.WriteLine(obj2.GetHashCode());
            //Console.WriteLine("*********************************");
            //obj1 = obj2;
            //Console.WriteLine(obj1.GetHashCode());
            //Console.WriteLine(obj2.GetHashCode());


            #endregion

        }
        static int sum(int x, int y)
        {
            return x - y;
        }
    }
}
