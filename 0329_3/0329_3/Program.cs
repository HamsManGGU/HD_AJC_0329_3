using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0329_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. 1~ 20까지 수중에서 홀수 값의 합을 출력하세요
            int sum = 0;
            for(int i = 1; i <= 20; i++)
            {
                sum = (i%2) == 1 ? sum + i : sum;
            }
            Console.WriteLine($"1부터 20까지 홀수의 합은 {sum}");
        }
    }
}
