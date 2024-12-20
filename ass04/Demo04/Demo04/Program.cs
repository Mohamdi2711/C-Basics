using System.Text;

namespace Demo04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Loop Statments
            ////Not prefer in maintenance 
            //Console.WriteLine(1+"M");
            //Console.WriteLine(2+"M");
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{i}  M");
            //}
            #endregion

            #region For - Foreach
            //int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //for (int i = 0; i < Num.Length; i++)
            //{
            //    if(Num[i] == 5)
            //    {
            //        continue;
            //    }
            //    if (Num[i] == 9)
            //    { 
            //        break;
            //    }
            //   // Num[i] += 10;
            //    Console.WriteLine(Num[i] /* +10 */);
            //}


            //Class impliement interface IEnumerable
            //foreach (int i in Num)
            //{   
            //    //Num += 10   //Invalid
            //    Console.WriteLine(i + 10);
            //}
            #endregion

            #region While - Do While
            //int Number = 1;
            //bool flag = false;
            //do 
            //{  
            //       Console.Write("Enter Even Number : ");
            //    // Number = int.Parse(Console.ReadLine());  
            //   flag = int.TryParse(Console.ReadLine(), out Number);
            //} while (Number %2 == 1 || !flag );



            //while (Number %2 !=0 || !flag )
            //{
            //    Console.Write("Enter Even Number : ");
            //    flag = int.TryParse(Console.ReadLine(), out Number);
            //}
            //    Console.WriteLine($"{Number} is Even ");
            #endregion

            #region String
            // Class ==> Reference Type
            // Immutable Data Type [Value Can't Be Changed]
            // Array Of Chars (A L I)

            //string Name;
            ////Name = new string("Mohamed");
            //Name = "Mohamed";

            //string Name01 = "Ali";
            //string Name02 = "Ali";

            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 HC : {Name01.GetHashCode()}"); 
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name01 HC : {Name02.GetHashCode()}");

            //string Name01 = "Ali";
            //string Name02 = "Mohamed";

            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 HC : {Name01.GetHashCode()}");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name01 HC : {Name02.GetHashCode()}");

            //Console.Clear();

            //Name02 = Name01;

            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 HC : {Name01.GetHashCode()}");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name01 HC : {Name02.GetHashCode()}");

            //Name01 = "Ahmed"; 
            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 HC : {Name01.GetHashCode()}");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name01 HC : {Name02.GetHashCode()}");

            //string Masseage = "Hello ";
            //Console.WriteLine(Masseage);
            //Console.WriteLine(Masseage.GetHashCode());
            //Masseage += "Route";
            //Console.WriteLine(Masseage);
            //Console.WriteLine(Masseage.GetHashCode());
            #endregion

            #region StringBuilder
            //StringBuilder Message;
            ////Message = "Ali"; //Invalid
            //Message = new StringBuilder("Hello");
            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());
            //Message.Append("Route");
            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());
            #endregion

            #region StringBuilder Methods
            //StringBuilder Message = new StringBuilder("Welcome");

            //Message.Append(" To ");
            //Message.AppendLine(" Route");
            //Message.Append("Mohamed");

            //Message.Remove(0, 7);

            //Message.Insert(0, "Hello");

            //int Age = 20;
            //string Name = "Mohamed";
            //Message.AppendFormat("Name : {0} , Age : {1}", Name , Age);

            //Message.AppendJoin("/", Name ,  Age);
            //Console.WriteLine(Message);

            #endregion

            #region Array 1 D
            //int[] Number = new int[3] {1,2,3} ; // 4*3 = 12 byte
            //int[] Number = new int [] {1,2,3} ;
            //int[] Number = { 1, 2, 3 };

            //int[] Number = new int[3];
            //Number[0] = 1;
            //Number[1] = 2;
            //Number[2] = 3;

            //for (int i = 0; i < Number.Length; i++)
            //{
            //    Console.Write($"Enter Element Number {i+1} : ");
            //    bool flag = int.TryParse(Console.ReadLine(), out Number[i]);
            //    while (!flag)
            //    {
            //        Console.Write($"Enter Element Number {i + 1} : ");
            //        flag = int.TryParse(Console.ReadLine(), out Number[i]);
            //    }
            //}
            //Console.WriteLine("************************");
            //for (int i = 0; i < Number.Length; i++)
            //{
            //    Console.WriteLine(Number[i]);
            //}

            #endregion
            

        }
    }
}
