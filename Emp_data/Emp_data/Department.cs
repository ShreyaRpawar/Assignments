using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_data
{
    internal class Department
    {
        public int DeptNo { get; set; }
        public string DeptName { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }

    }

    internal class Departments : List<Department>
    {
        public Departments()
        {
            Add(new Department() { DeptNo = 101, DeptName = "IT", Location = "Pune", Capacity = 50 });
            Add(new Department() { DeptNo = 102, DeptName = "IT", Location = "Mumbai", Capacity = 50 });
            Add(new Department() { DeptNo = 103, DeptName = "SL", Location = "Nagpur", Capacity = 50 });
            Add(new Department() { DeptNo = 104, DeptName = "IT", Location = "Pune", Capacity = 50 });
            Add(new Department() { DeptNo = 105, DeptName = "HR", Location = "Mumbai", Capacity = 50 });
            Add(new Department() { DeptNo = 106, DeptName = "HR", Location = "Pimpri", Capacity = 50 });
            Add(new Department() { DeptNo = 107, DeptName = "IT", Location = "Pune", Capacity = 50 });
            Add(new Department() { DeptNo = 108, DeptName = "SL", Location = "Mumbai", Capacity = 50 });
            Add(new Department() { DeptNo = 109, DeptName = "SL", Location = "Pimpri", Capacity = 50 });
            Add(new Department() { DeptNo = 110, DeptName = "IT", Location = "Pune", Capacity = 50 });
        }

    }
}


