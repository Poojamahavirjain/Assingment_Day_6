//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AssignmentDay6
//{
//    internal class PerfectNo
//    {
//        public static int Find_Factors(int input)
//        {
//            int sum = 0;
//            for (int i = 1; i < input; i++)
//            {
//                if (input % i == 0)
//                {
//                    sum = sum + i;
//                }
//            }
//            return sum;

//        }
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Provide input value");
//            int input = int.Parse(Console.ReadLine());
//            int result = Find_Factors(input);
//            if (input == result)
//            {
//                Console.WriteLine($"{input}it is a perfect no");
//            }
//            else
//            {
//                Console.WriteLine($"{input}it is a not perfect no");
//            }
//        }

//    }
//}