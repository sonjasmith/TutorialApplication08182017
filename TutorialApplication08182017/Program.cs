using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialApplication08182017
{
    class Program
    {
        static void Main(string[] args)
        {
            //After paying $5.12 for a salad, Norachai has $27.10. How much did he have before buying the salad?
            float salad = 5.12f;
            float totalNow = 27.10f;
            Console.WriteLine(totalNow + salad);

            //If Monty has $16.72 and Larry has $4.12, how much money do they have together?
            float monty = 16.72f;
            float larry = 4.12f;
            //Console.WriteLine(larry + monty);

            int middleNum = (72 / 3);
            int smallNum = (middleNum - 1);
            int largeNum = (middleNum + 1);
           // Console.WriteLine(smallNum);
           // Console.WriteLine(middleNum);
           // Console.WriteLine(largeNum);

            int middle_Num = (288 / 3);
            int small_Num = (middle_Num - 1);
            int large_Num = (middle_Num + 1);
            Console.WriteLine(small_Num);
            Console.WriteLine(middle_Num);
            Console.WriteLine(large_Num);
        }
    }
}