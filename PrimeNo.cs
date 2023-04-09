//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AssignmentDay6
//{
//    internal class PrimeNumber
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("provide input number:");
//            int input = int.Parse(Console.ReadLine());
//            if (input <= 1)
//            {
//                Console.WriteLine("Invaild number");
//            }
//            else
//            {
//                int flag = 0;
//                for (int i = 2; i < input; i++)
//                {
//                    if (input % i == 0)
//                    {
//                        Console.WriteLine("{0} is not prime");
//                        flag = 1;
//                        break;
//                    }
//                }
//                if (flag == 0)
//                {
//                    Console.WriteLine("{0} is prime");
//                }
//            }
//        }
//    }

//}
