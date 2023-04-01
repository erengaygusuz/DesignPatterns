﻿using DesignPatterns.TemplateMethod.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod.Concrete
{
    internal class DerivedB : Base
    {
        protected override bool Step1()
        {
            Console.WriteLine("Step1 is executed");

            return true;
        }

        protected override void Step2()
        {
            Console.WriteLine("Step2 is executed");
        }

        protected override bool Step3()
        {
            Console.WriteLine("Step3 is executed");

            return true;
        }

        protected override void Step4()
        {
            Console.WriteLine("Step4 is executed");
        }
    }
}
