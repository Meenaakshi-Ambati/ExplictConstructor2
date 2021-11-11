using System;

namespace ExplictInterface2
{
    interface I1
    {
        void InterfaceMethod();

    }
    interface I2
    {
        void InterfaceMethod();
    }

    class MyClass : I1, I2
    {
        public void InterfaceMethod()
        {
            Console.WriteLine("Interface Method");

        }

        void I2.InterfaceMethod()
        {
            Console.WriteLine(" I2 Interface Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass();
            myclass. InterfaceMethod();

            I2 i2 = myclass;
            i2.InterfaceMethod();
            
        }
    }
}
