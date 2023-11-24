using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _06November_13Pract
{
    public class Program
    {
        static void Exmpl01()//коллекция
        {
            ArrayList list = new ArrayList();
            object test = 55;//boxing
            int x = (int)test;//unboxing

            list.Add(5);//boxing
            list.Add(true);
            list.Add("Test");

            foreach (int item in list)
            {
                int xx = (int)item;
            }
        }
        //queue(очередь)
        static void Exmpl02()
        {
            Queue qe = new Queue();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                qe.Enqueue(i);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(qe.Dequeue());
            }
            Console.WriteLine("Очередь\n");
            foreach (var item in qe)
            {
                Console.WriteLine(item);
            }
        }
        static void Exmpl03()
        {
            Stack stack = new Stack();
            stack.Push("1");
            stack.Push("2");
            stack.Push("3");
            stack.Push("4");

            Console.WriteLine("Очередь\n");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
        static void Exmpl04()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            for (int i = 0; i < 10; i++)
            {
                dic.Add(1, testc.ToString());
            }
        }
        static void Exmpl05()
        {

        }

    }
}
