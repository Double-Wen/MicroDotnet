using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp81
{

    class Program
    {
        //进行测试
        static void Main(string[] args)
        {
            MyLinkedList<int> lst = new MyLinkedList<int>();
            Console.WriteLine(lst.Count);
            Random rd = new Random();
            for (int i = 0; i < 10; i++)
            {
                lst.AddToTail(rd.Next(100));
            }
            lst.AddToHead(100);
            lst.AddToTail(100);
            Console.WriteLine(lst);
            Console.WriteLine(lst.Count);
            Console.WriteLine(lst.Contains(100));

            MyLinkedList<int> list = new MyLinkedList<int>(1, 8, 9, 43, 22);
            Console.WriteLine(list);
            Console.ReadLine();
        }
        //泛型类，代表链表中的节点
        public class Node<T>
        {
            public T Value { get; set; }
            public Node<T> Next { get; set; }
            public Node(T value)
            {
                Value = value;
                Next = null;
            }
        }
        //泛型接口，定义了列表上可执行的操作
        public interface IMyList<T>
        {
            void AddToHead(T value);
            void AddToTail(T value);
            int Count { get; }
            bool Contains(T value);
        }
        //MyLinkedList类，单向链表
        public class MyLinkedList<T> : IMyList<T>
        {
            private Node<T> head;
            public Node<T> Head { get; set; }

            //实现接口中定义的功能
            public void AddToHead(T value)
            {
                Node<T> p = new Node<T>(value);
                if (head == null)
                {
                    head = p;
                    return;
                }
                p.Next = head.Next;
                head.Next = p;

            }
            public void AddToTail(T value)
            {
                Node<T> p = new Node<T>(value);
                Node<T> q = new Node<T>(default);
                if (head == null)
                {
                    head = p;
                    return;
                }
                q = head;
                while (q.Next != null)
                {
                    q = q.Next;
                }
                q.Next = p;
            }
            public int Count
            {
                get
                {
                    return count;
                }

            }
            public bool Contains(T value)
            {
                Node<T> p = new Node<T>(default);
                p = head;
                while ((p.Next != null) && (!p.Value.Equals(value)))
                {
                    p = p.Next;
                }
                if (p.Next == null || head == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            //无参构造方法
            public MyLinkedList()
            {
                head = null;
            }
            //有参构造方法（支持任意数量参数）
            public MyLinkedList(params T[] value)
            {

                Node<T> q = new Node<T>(value[0]);
                head = q;
                for (int i = 1; i < value.Length; i++)
                {
                    Node<T> p = new Node<T>(value[i]);
                    if (head == null)
                    {
                        head = p;
                    }
                    q = head;
                    while (q.Next != null)
                    {
                        q = q.Next;
                    }
                    q.Next = p;
                }
            }
            int count = 0;
            //重写ToString方法（生成类似1--> 8--> 9--> 43--> 22-->的字符串）
            public override string ToString()
            {
                Node<T> q = new Node<T>(default);
                StringBuilder s = new StringBuilder();
                q = head;
                while (q.Next != null)
                {
                    s.Append((q.Value).ToString() + "-->");
                    q = q.Next;
                    count++;
                }
                if (q != null)
                    count++;
                s.Append((q.Value).ToString() + "-->");
                return s.ToString();
            }
        }
    }

}

