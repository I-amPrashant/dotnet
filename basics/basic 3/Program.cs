using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_3
{


    internal class Program
    {
        static void Main(string[] args)
        {
            //ARRAYS AND STRINGS
            //DECLARING ARRAY
            //string[] str1;//using string keyword
            //String[] str2;//using string class object

            //string[] str3 = new string[5];//declaring with size

            ////INITIALIZE ARRAY 
            //str1 = new string[] { "apple" };//intialized empty array str1
            //str3 = new string[5] { "apple", "apple", "", "apple", "banana", };//must be of length


            ////  ACCESSING ARRAY ELEMENTS
            //Console.WriteLine(str1[0]);
            //Console.WriteLine(str3[4]);

            //String[] str = new String[] { "apple", "banana", "kera" };
            //foreach (var item in str)
            //{
            //    Console.WriteLine(item + "\n");
            //}

            //MULTIDIMENSION ARRAY 
            //int[,] array2d = new int[,] { { 2, 3, 3 }, { 1, 2, 3 }};
            //for(int i = 0; i < 3; i++)
            //{
            //    for(int j=0;j< 3; j++)
            //    {
            //        Console.WriteLine( array2d[i,j] );
            //    }
            //}


            //JAGGED ARRAY (array of arrays)
            int[][] jag = new int[3][];
            jag[0] = new int[2];
            jag[0][0] = 11;
            jag[0][1] = 12;
            jag[1] = new int[1] { 11 };
            jag[2] = new int[3] { 14, 15, 16 };
            for (int i = 0; i < jag.Length; i++)
            {
                int[] innerArray = jag[i];
                for (int a = 0; a < innerArray.Length; a++)
                {
                    Console.WriteLine(innerArray[a] + " ");
                }
            }
            Console.Read();
        }
    }
}
