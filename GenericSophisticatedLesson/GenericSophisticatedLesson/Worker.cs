﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSophisticatedLesson
{
    public class Worker: Employee
    {
        public string Nickname { get; set; }

        public void DoWork()
        {
            Console.WriteLine($"{Nickname} делает свою простую работу");
        }
    }
}
