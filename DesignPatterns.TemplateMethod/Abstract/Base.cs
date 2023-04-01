using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod.Abstract
{
    internal abstract class Base
    {
        public void TemplateMethod()
        {
            if (Step1())
            {
                Step2();
            }

            else
            {
                Console.WriteLine("Step1 is not executed");

                if (Step3())
                {
                    Step4();
                }

                else
                {
                    Console.WriteLine("Step4 is not executed");
                }
            }
        }

        protected virtual bool Step1()
        {
            return true;
        }

        protected abstract void Step2();

        protected virtual bool Step3()
        {
            return false;
        }

        protected abstract void Step4();
    }
}
