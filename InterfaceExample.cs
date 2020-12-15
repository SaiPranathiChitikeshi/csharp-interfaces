using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    interface IEmployee {
        string getDepartmnent();
        double getSalary();
    }
    class InterfaceExample : IEmployee
    {       
        public string getDepartmnent()
        {
            return "IT";
        }

        public double getSalary()
        {
            return 1234.90;
        }
    }
}
