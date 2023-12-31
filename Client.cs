﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeStructure
{
     class Client
    {
        public void ClientCode(Component leaf) 
        {
            Console.WriteLine($"Result: {leaf.Operation()}\n");
        }
        public void ClientCode2(Component component1, Component component2)
        {
            if (component1.IsComposite()) 
            {
                component1.Add(component2);
            }
            Console.WriteLine($"RESULT: {component1.Operation()}\n");
        }
    }
}
