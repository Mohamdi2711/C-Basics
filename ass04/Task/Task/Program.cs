namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array - Methods
            //int[] Arr = { 1, 2, 5, 2, 3, 8, 4, 9, 7, 6, 8 };
            //Array.Sort(Arr);
            //Array.Reverse(Arr);
            //Array.Clear(Arr,2,5);
            //Console.WriteLine(Array.IndexOf(Arr, 2));
            //Console.WriteLine(Array.LastIndexOf(Arr,10));

            //int[] array1 = { 1, 2, 3, 4 };
            //int[] array2 = { 1, 2, 3, 4 };
            //int[] array3 = array1;

            //string name01 = "Ali";
            //string name02 = "Ali ";

            //Console.WriteLine(string.Equals(name01,name02));

            ////Console.WriteLine(Array.Equals(array1, array2)); //f
            ////Console.WriteLine(Array.Equals(array1, array3)); //t

            //Array.Resize(ref Arr, 15);


            //int[] arr01 = { 1, 2, 3, 4,5,6 ,7,8};
            //int[] arr02 = new int[6]; //0,0,0,0,0,0

            ////Array.Copy(arr01, arr02, 6);
            //Array.ConstrainedCopy(arr01, 1, arr02, 0, 7);

            //foreach (int i in arr02)
            //{
            //    Console.WriteLine(i);
            //}
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
                
            //Array.Copy(Arr01,Arr02,Arr01.Length);

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

        }
    }
}
