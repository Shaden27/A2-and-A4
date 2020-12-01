using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
{
    class Class1
    {
        protected virtual void func()
        {
            Console.WriteLine("HEllo Func 1");
        }
    }
    class Class2:Class1
    {
        protected override void func()
        {
            Console.WriteLine("HEllo Func 2");
        }
    }
    abstract class abs
    {
        protected abstract void func();
    } 
}
