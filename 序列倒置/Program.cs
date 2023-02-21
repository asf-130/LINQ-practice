using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 序列倒置
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一串以逗號分隔的字串");
            string input = Console.ReadLine();
            List<string> list = input.Split(',').ToList();

            list.Reverse();
            
            Console.WriteLine(string.Join(",", list));

            
            
        }
    }
}
