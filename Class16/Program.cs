using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class16
{
    class Program
    {
        static int x;
        static int y;

        static void Main(string[] args)
        {
            #region Exercise 1
            //List<int[]> foo = new List<int[]>();
            //int[] arr = { 23976, 7645 };
            //int[] arr2 = { 123, 456 };
            //foo.Add(arr2);
            //int x = foo[0][1];
            //Console.WriteLine(x);

            //List<int> list = new List<int> { 89, 5, 1, 2, 5, 2, 89, 23, 3, 90 };

            //Console.WriteLine(GetMostFrequentNumber(list));
            #endregion

            Console.ReadKey(true);
        }

        static int GetMostFrequentNumber(List<int> list)
        {
            int x = 0;
            int y = 0;

            List<int[]> listOfArrays = new List<int[]>();

            for (int i = 0; i < list.Count; i++)
            {
                int[] arr1 = new int[2];
                arr1[0] = list[i];
                arr1[1] = 0;
                listOfArrays.Add(arr1);
            }

            int counter = 0;
            for (int i = 0; i < listOfArrays.Count; i++)
            {
                for (int j = 0; j < listOfArrays.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        x++;
                    }
                }
                listOfArrays[i][1] = x;

                if (x > counter)
                {
                    counter = x;
                }
                x = 0;
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (listOfArrays[i][1] == counter)
                {
                    y = listOfArrays[i][0];
                }
            }

            return y;
        }

        static void PrintList(List<int> list)
        {
            Console.Write("List: [");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
                if (i < list.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }
    }
}
