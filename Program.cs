﻿using System.Collections.Generic;

namespace LinkedListNew
{
    internal class Program
    {
        static void Main(string[] args)
           
        {
            LinkedList l_Object = new LinkedList();

            l_Object.add(56);
            l_Object.add(30);
            l_Object.add(70);
            l_Object.RemoveLastNode();
            l_Object.display();
        }
    }
}