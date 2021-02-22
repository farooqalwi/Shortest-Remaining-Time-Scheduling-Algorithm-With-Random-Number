using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shortest_Remaining_Time_Scheduling_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //for better output use https://repl.it/@FarooqAlwi/Shortest-Remaining-Time-Scheduling-Algorithm-With-Random-Num#main.cs

            List<int[]> list = new List<int[]>();

            for (int i = 0; i < 3; i++)
            {
                list.Add(arrayGen());
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"Array {i + 1}: ");
                for (int j = 0; j < list[i].Length; j++)
                {
                    Console.Write(list[i][j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n..............Shortest Remaining Time..............\n");

            int[] psw = { 0, 0, 0 }; //psw = present status work
            int[] completed = { list[0].Length, list[1].Length, list[2].Length };   //completed tasks

            Console.WriteLine($"Array 1: { list[0][psw[0]]}");
            psw[0]++;

            bool flag = true;

            do
            {
                if (psw[0] < completed[0] && ((list[0].Length - psw[0]) <= (list[1].Length - psw[1]) || (psw[1] == completed[1])) && ((list[0].Length - psw[0]) <= (list[2].Length - psw[2]) || (psw[2] == completed[2])))
                {
                    Console.WriteLine($"Array 1: { list[0][psw[0]]}");
                    psw[0]++;
                }
                else if (psw[1] < completed[1] && ((list[1].Length - psw[1]) <= (list[0].Length - psw[0]) || (psw[0] == completed[0])) && (((list[1].Length - psw[1]) <= (list[2].Length - psw[2]) || (psw[2] == completed[2]))))
                {
                    Console.WriteLine($"Array 2: { list[1][psw[1]]}");
                    psw[1]++;
                }
                else if (psw[2] < completed[2] && ((list[2].Length - psw[2]) <= (list[0].Length - psw[0]) || (psw[0] == completed[0])) && ((list[2].Length - psw[2]) <= (list[1].Length - psw[1]) || (psw[1] == completed[1])))
                {
                    Console.WriteLine($"Array 3: { list[2][psw[2]]}");
                    psw[2]++;
                }
                else
                {
                    Console.WriteLine("\n..............Desired Output Found..............\n");
                    flag = false;
                }

            } while (flag);
        }

        public static int[] arrayGen()
        {
            int[] array = new int[(new Random().Next(8) + 3)];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(100);
            }

            return array;
        }
    }
}
