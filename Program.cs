using System;

namespace DemoCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Read();
            //Console.WriteLine("Hello World!");
            // string s = "123";
            //int y = Int32.Parse(s);
            //int y ;
            // Int32.TryParse(s,out y);
            // y = Convert.ToInt32(s);
            //Console.WriteLine("y + 1 = " + (y + 1));
            //Console.WriteLine("y + 1 = {0}", y + 1);
            //int x =1, y = 2;
            //Console.WriteLine("{0} + {1} = {2}", x, y , x+y);
            // string arr[] = new string [4];
            // string[] arr = new string [] {"A","B","C"};

            // foreach(string i in arr)
            // {
            //foreach dung lai khi gap phan tu rong
            //     Console.WriteLine(i);
            // }

            // string[,] arr = new string[2,3];
            // string [,] arr = {{"a","b","c"},
            //                     {"c","d","e"}};

            // string [][] arr = new string [3][];
            // arr[0] = new string [] {"A","B","C"};
            // arr[1] = new string [] {"A","B","C","D"};
            // arr[2] = new string [] {"A","B"};

            // foreach (string[] s in arr)
            // {
            //     foreach (string i in s)
            //     Console.WriteLine(i);
            // }

            /*  SV s1 = new SV();
              SV s2 = new SV("1","NVA", 18);
              SV s3 = new SV(s1);*/

            /* SV s = new SV {
                 MSSV = "1",
                 Name = "NVA",
                 Age = 18
             };
             Console.WriteLine(s.ToString());*/

            /*Console.WriteLine(s1.Show());
            Console.WriteLine(s2.Show());
            Console.WriteLine(s3.Show());*/
            QLSV db = new QLSV();
            db.CreateDB();
            SV s = new SV
            {
                MSSV = "3",
                Name = "NVC",
                Age = 18
            };
            db.Remove(s);
            /* SV s = new SV {
                 MSSV = "3",
                 Name = "NVC",
                 Age = 18
             };*/
            //db.Update(s,2);
            // Console.WriteLine(db.IndexOf(s));
            db.Sort();
            db.Show();
        }
    }
}
