using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 奇偶判斷
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一串以逗號分隔的整數數字字串");
            string[] input = Console.ReadLine().Split(',');

            var odd = input.Where(x => int.Parse(x) % 2 == 1).OrderBy(x => x);
            var even = input.Where(x => int.Parse(x) % 2 == 0).OrderBy(x => x);

            Console.WriteLine("奇數 : " + string.Join(",", odd));
            Console.WriteLine("偶數 : " + string.Join(",", even));







        }
    }
}
