using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp_data employee = new Emp_data();
            Fileop fileoperations = new Fileop();
            fileoperations.CalculateTax(employee);
        }
    }
}
