using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session6
{
    public class Collection
    {
        private static int[] intArr = new int[5];
        private static List<int> intList = new List<int>();

        public static void Print()
        {
            intArr[0] = 1;
            intArr[1] = 2;
            intArr[2] = 3;
            intArr[3] = 4;
            intArr[4] = 5;

            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
            intList.Add(5);
            intList.Add(6);
            intList.Add(7);

            for (int i = 0; i < intArr.Length; i++)
            {
                Console.WriteLine("Array " + intArr[i]);
            }

            for (int i = 0; i < intList.Count;i++)
            {
                Console.WriteLine("List " + intList[i]);
            }
            Console.WriteLine();
            // int removed = intList.RemoveAll(m => m % 2 == 0);
           // int removed = intList.RemoveAll(m => predict(m));

            // var newList = intList.Where(m => m %2 == 0).ToList();
            var newList = intList.Where(m => m % 2==0).ToList();

            for (int i = 0; i < newList.Count; i++)
            {
                Console.WriteLine("List " + newList[i]);
            }
        }

        public static bool predict(int num)
        {
            return num % 2 == 0;
        }
    }
}
