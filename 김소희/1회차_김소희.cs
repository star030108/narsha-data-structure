using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190921
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("Hello world");

            string str1 = "Hello, world";

            string[] split = str1.Split(',');

            Console.WriteLine(split[0]);
            Console.WriteLine(split[1]);

            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);

            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);
            Console.WriteLine(list[2]);*/

            Random random = new Random();

            string text = Console.ReadLine();
            string[] splited = text.Split(' ');

            while(IsDuplicated(splited))
            {
                Console.WriteLine("다시 입력해주세요");

                text = Console.ReadLine();
                splited = text.Split(' ');
            }

            string[] randNum = new string[6];

            for (int i = 0; i < randNum.Length; i++)
            {
                Console.WriteLine(randNum[i] = random.Next(1, 45).ToString());
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine(getDupCount(splited, randNum));

        }

        static bool IsDuplicated(string[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static int getDupCount(string[] param1, string[] param2)
        {
            int count = 0;
            for(int i = 0; i < 6; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    if (param1[i].Equals(param2[j]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
