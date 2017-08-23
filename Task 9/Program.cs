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
            Console.WriteLine("Введите количество элементов в списке");
            int N = 0;
            bool ok;            
            do
            {
                ok = int.TryParse(Console.ReadLine(), out N);
                if (!ok) Console.WriteLine("Неправильный ввод. Ожидалось натуральное число. Пожалуйста, повторите ввод");
            }
            while (!ok);

            DoublyList er = DoublyList.MakeDoublyList(N);
            DoublyList.ShowDoublyList(er);

            // Поиск элементов
            // По номеру
            Console.WriteLine("Введите номер элемента для поиска");
            int num = 0;
            do
            {
                ok = int.TryParse(Console.ReadLine(), out num);
                if (!ok) Console.WriteLine("Неправильный ввод. Ожидалось натуральное число. Пожалуйста, повторите ввод");
            }
            while (!ok);

            DoublyList foundEl = DoublyList.SearchElemNum(er, num);
            Console.WriteLine(foundEl);

            // По данным
            Console.WriteLine("Введите данные элемента для поиска");
            double data = 0;
            do
            {
                ok = double.TryParse(Console.ReadLine(), out data);
                if (!ok) Console.WriteLine("Неправильный ввод. Ожидалось вещественное число. Пожалуйста, повторите ввод");
            }
            while (!ok);

            foundEl = DoublyList.SearchElemData(er, data);
            Console.WriteLine(foundEl);


            // Удаление элементов
            // По номеру
            Console.WriteLine("Введите номер элемента для удаления");
            num = 0;
            do
            {
                ok = int.TryParse(Console.ReadLine(), out num);
                if (!ok) Console.WriteLine("Неправильный ввод. Ожидалось натуральное число. Пожалуйста, повторите ввод");
            }
            while (!ok);

            er = DoublyList.DeleteElemNum(er, num);
            DoublyList.ShowDoublyList(er);

            // По данным
            Console.WriteLine("Введите данные элемента для удаления");
            data = 0;
            do
            {
                ok = double.TryParse(Console.ReadLine(), out data);
                if (!ok) Console.WriteLine("Неправильный ввод. Ожидалось вещественное число. Пожалуйста, повторите ввод");
            }
            while (!ok);

            er = DoublyList.DeleteElemData(er, data);
            DoublyList.ShowDoublyList(er);


            Console.ReadLine();
        }
    }
}
