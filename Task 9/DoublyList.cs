using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class DoublyList
    {
        public int number;
        public int data;
        public DoublyList next, prev;

        public DoublyList()
        {
            number = 0;
            data = 0;
            next = null;
            prev = null;
        }
        public DoublyList(int num, int data)
        {
            number = num;
            this.data = data;
            next = null;
            prev = null;
        }
        public override string ToString()
        {
            return "(" + number + ") " + data + " ";
        }

        /// <summary>
        /// Формирование одного элемента списка
        /// </summary>
        /// <param name="d">Информационное поле текущего элемента</param>
        /// <returns>Заполненный элемент</returns>
        public static DoublyList MakeDoubly(int num, int d)
        {
            DoublyList p = new DoublyList(num, d);
            return p;
        }

        /// <summary>
        /// Заполнение двунаправленного списка
        /// </summary>
        /// <param name="size">Размер списка</param>
        /// <returns>Заполненный список</returns>
        public static DoublyList MakeDoublyList(int size)
        {
            Console.WriteLine("Введите элемент");
            int info = int.Parse(Console.ReadLine());
            DoublyList beg = MakeDoubly(1, info);
            DoublyList end = beg;
                        
            for (int i = 2; i <= size; i++)
            {
                Console.WriteLine("Введите элемент");
                info = int.Parse(Console.ReadLine());
                DoublyList p = MakeDoubly(i,info);
                if (info > 0)
                {
                    p.next = beg;
                    beg.prev = p;
                    beg = p;
                }
                else if (info < 0)
                {
                    end.next = p;
                    p.prev = end;
                    end = p;
                }
                else
                {
                    DoublyList t = end;
                    while (t.data < 0 && t.prev != null)
                        t = t.prev;
                    if (t.prev == null)
                    {
                        end.next = p;
                        p.prev = end;
                        end = p;
                    }
                    else if (t == beg)
                    {
                        p.next = beg;
                        beg.prev = p;
                        beg = p;
                    }
                    else
                    {
                        t.next.prev = p;
                        p.next = t.next;
                        p.prev = t;
                        t.next = p;                      
                    }
                }
            }
            return beg;
        }

        /// <summary>
        /// Добавление элемента в список
        /// </summary>
        /// <param name="BegDoubly">Двунапрвленный список</param>
        /// <param name="number">Номер позиции для добавления элемента</param>
        //public static void AddElement(ref DoublyList BegDoubly, int number)
        //{
        //    Console.WriteLine("Введите элемент");
        //    string info = Console.ReadLine();
        //    DoublyList newel = MakeDoubly(info);
        //    if (BegDoubly == null)
        //        BegDoubly = newel;
        //    else
        //    if (number == 1)
        //    {
        //        newel.next = BegDoubly;
        //        BegDoubly.pred = newel;
        //        BegDoubly = newel;
        //    }
        //    else
        //    {
        //        DoublyList p = BegDoubly;
        //        for (int i = 1; i < number - 1; i++)
        //            BegDoubly = BegDoubly.next;
        //        BegDoubly.next.pred = newel;
        //        newel.next = BegDoubly.next;
        //        newel.pred = BegDoubly;
        //        BegDoubly.next = newel;
        //        for (int i = number - 2; i > 0; i--)
        //            BegDoubly = BegDoubly.pred;
        //    }
        //}

        /// <summary>
        /// Вывод списка
        /// </summary>
        /// <param name="BegDoubly">Двунаправленный список</param>
        public static void ShowDoublyList(DoublyList BegDoubly)
        {
            if (BegDoubly == null)
            {
                Console.WriteLine("Список пуст");
                return;
            }
            DoublyList p = BegDoubly;
            while (p != null)
            {
                Console.Write("{0}", p);
                p = p.next;
            }
            Console.WriteLine();
        }
    }

}
