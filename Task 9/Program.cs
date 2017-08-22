using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyList er = DoublyList.MakeDoublyList(10);
            DoublyList.ShowDoublyList(er);
            Console.ReadLine();
        }
    }
}
