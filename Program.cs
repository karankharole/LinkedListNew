﻿using System.Collections.Generic;

namespace LinkedListNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(70);
            list.Display();
            list.InsertAtParticularPosition(2, 30);
            list.Display();

        }
    }
}