using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            Console.WriteLine("1. List Node");
            Console.WriteLine("InsertAfter, InsertBefore\n");
            DListNode list = new DListNode(30);
            list.InsertAfter(50);
            list.InsertAfter(40);
            list.InsertBefore(10);
            list.InsertBefore(20);
            ResultNodeList(list);

            // 2
            Console.WriteLine("\n///////////////////////////////////////////////");
            Console.WriteLine("\n2. Linked List");
            Console.WriteLine("Append, Prepend, RemoveHead, RemoveTail\n");
            DLinkList linklist = new DLinkList();
            linklist.Append(30);
            linklist.Append(40);
            linklist.Append(50);
            linklist.Prepend(20);
            linklist.Prepend(10);
            Console.WriteLine("Head is " + linklist.m_head.m_data + " and Tail is " + linklist.m_tail.m_data + "\n");
            linklist.RemoveHead();
            linklist.RemoveTail();
            ResultNodeLinkList(linklist);
            CheckNullonRemoveNode(linklist);

            // 3
            Console.WriteLine("\n///////////////////////////////////////////////");
            Console.WriteLine("\n3. Iterators");
            Console.WriteLine("Insert, Remove\n");
            Console.WriteLine("The List Contains\n");
            DListIterator itr = linklist.GetIterator();
            DListNode node = linklist.m_head;

            linklist.Insert(itr, 25);
            linklist.Remove(itr, node);

            ResultIterator(itr);

            Console.ReadLine();
        }

        private static void ResultNodeLinkList(DLinkList linklist)
        {
            Console.WriteLine("Result\n");

            DListNode itr = linklist.m_head;
            for (int i = 1; i <= linklist.m_count; i++)
            {
                Console.WriteLine(itr.m_data);
                itr = itr.m_next;
                if (itr == null) break;
            }

            Console.WriteLine("\n");

            itr = linklist.m_tail;
            for (int i = 1; i <= linklist.m_count; i++)
            {
                Console.WriteLine(itr.m_data);
                itr = itr.m_previous;
                if (itr == null) break;
            }
        }

        private static void CheckNullonRemoveNode(DLinkList linklist)
        {
            Console.WriteLine("\nCheck NULL On Remove Node\n");

            if (linklist.m_head.m_previous.m_data == null)
            {
                Console.WriteLine("m_previous of Head Node : NULL");
            }

            if (linklist.m_tail.m_next.m_data == null)
            {
                Console.WriteLine("m_next of Tail Node : NULL");
            }
        }

        private static void ResultIterator(DListIterator itr)
        {
            for (itr.Start(); itr.Valid(); itr.Forth())
            {
                Console.WriteLine(itr.Item());
            }
            itr.Start();
        }

        private static void ResultNodeList(DListNode list)
        {
            Console.WriteLine("Result\n");
            DListNode itr = list.m_previous.m_previous;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(itr.m_data);
                itr = itr.m_next;
                if (itr == null) break;
            }

            Console.WriteLine("\n");

            itr = list.m_next.m_next;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(itr.m_data);
                itr = itr.m_previous;
                if (itr == null) break;
            }
        }
    }
}
