﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dxf_creating_description_for_nesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Entity.DxfReader reader = new Entity.DxfReader();
            reader.loadDxfFile();
            Console.ReadKey();
        }
    }
}
