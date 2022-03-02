using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    internal class Emp_data : List<Serial>
    {
        public Emp_data()

        {
            Add(new Serial() { EmpNo = 101, EmpName = "Mahesh",     DeptName = "IT", Salary = 50000, designation = "Manager" });
            Add(new Serial() { EmpNo = 102, EmpName = "Tejas",      DeptName = "HR", Salary = 12000, designation = "manager" });
            Add(new Serial() { EmpNo = 103, EmpName = "Nandu",      DeptName = "SL", Salary = 13000, designation = "Salesperson" });
            Add(new Serial() { EmpNo = 104, EmpName = "Anil",       DeptName = "IT", Salary = 45000, designation = "developer" });
            Add(new Serial() { EmpNo = 105, EmpName = "Jaywant",    DeptName = "HR", Salary = 10000, designation = "staff" });
            Add(new Serial() { EmpNo = 106, EmpName = "Abhay",      DeptName = "SL", Salary = 59000, designation = "clerk" });
            Add(new Serial() { EmpNo = 107, EmpName = "Anil",       DeptName = "IT", Salary = 8000,  designation = "engineer" });
            Add(new Serial() { EmpNo = 108, EmpName = "Shyam",      DeptName = "HR", Salary = 75000, designation = "director" });
            Add(new Serial() { EmpNo = 109, EmpName = "Vikram",     DeptName = "SL", Salary = 6000,  designation = "clerk" });
            Add(new Serial() { EmpNo = 110, EmpName = "Suprotim",   DeptName = "IT", Salary = 55000, designation = "project_manager" });
            Add(new Serial() { EmpNo = 111, EmpName = "Abhijeet",   DeptName = "IT", Salary = 11000, designation = "intern" });
            Add(new Serial() { EmpNo = 112, EmpName = "Abhinav",    DeptName = "HR", Salary = 50000, designation = "manager" });
            Add(new Serial() { EmpNo = 113, EmpName = "Abhishek",   DeptName = "SL", Salary = 13000, designation = "Salesperson" });
            Add(new Serial() { EmpNo = 114, EmpName = "Annu",       DeptName = "IT", Salary = 45000, designation = "developer" });
            Add(new Serial() { EmpNo = 115, EmpName = "Ankita",     DeptName = "HR", Salary = 10000, designation = "staff" });
            Add(new Serial() { EmpNo = 116, EmpName = "Atharva",    DeptName = "SL", Salary = 59000, designation = "clerk" });
            Add(new Serial() { EmpNo = 117, EmpName = "Baibhav",    DeptName = "IT", Salary = 8000, designation = "project_manager" });
            Add(new Serial() { EmpNo = 118, EmpName = "Bharti",     DeptName = "HR", Salary = 75000, designation = "intern" });
            Add(new Serial() { EmpNo = 119, EmpName = "Bhavana" ,   DeptName = "SL", Salary = 6000, designation = "intern" });
            Add(new Serial() { EmpNo = 120, EmpName = "Eren",       DeptName = "IT", Salary = 8000, designation = "intern" });
            Add(new Serial() { EmpNo = 121, EmpName = "Shilpa",     DeptName = "IT", Salary = 5000, designation = "manager" });
            Add(new Serial() { EmpNo = 122, EmpName = "Rohan",      DeptName = "IT", Salary = 11000, designation = "developer" });
            Add(new Serial() { EmpNo = 123, EmpName = "Raj",        DeptName = "HR", Salary = 12000, designation = "Salesperson" });
            Add(new Serial() { EmpNo = 123, EmpName = "Arijeet",    DeptName = "HR", Salary = 12000, designation = "staff" });
            Add(new Serial() { EmpNo = 123, EmpName = "Trunav",     DeptName = "HR", Salary = 12000, designation = "clerk" });
            Add(new Serial() { EmpNo = 124, EmpName = "Priya",      DeptName = "SL", Salary = 13000, designation = "project_manager" });
            Add(new Serial() { EmpNo = 126, EmpName = "Shubhangi",  DeptName = "IT", Salary = 45000, designation = "project_manager" });
            Add(new Serial() { EmpNo = 127, EmpName = "Shubham",    DeptName = "HR", Salary = 10000, designation = "intern" });
            Add(new Serial() { EmpNo = 128, EmpName = "Sailee",     DeptName = "SL", Salary = 59000, designation = "project_manager" });
            Add(new Serial() { EmpNo = 129, EmpName = "Riya",       DeptName = "IT", Salary = 8000, designation = "clerk" });
            Add(new Serial() { EmpNo = 130, EmpName = "Rimmy",      DeptName = "HR", Salary = 75000, designation = "intern" });
            Add(new Serial() { EmpNo = 131, EmpName = "Madhu",      DeptName = "SL", Salary = 6000, designation = "manager" });
            Add(new Serial() { EmpNo = 132, EmpName = "Divya",      DeptName = "IT", Salary = 55000, designation = "developer" });
            Add(new Serial() { EmpNo = 133, EmpName = "Deepika",    DeptName = "IT", Salary = 11000, designation = "Salesperson" });
            Add(new Serial() { EmpNo = 134, EmpName = "Manoj",      DeptName = "HR", Salary = 12000, designation = "clerk" });
            Add(new Serial() { EmpNo = 135, EmpName = "Nandini",    DeptName = "SL", Salary = 13000, designation = "project_manager" });
            Add(new Serial() { EmpNo = 136, EmpName = "Jaya",       DeptName = "IT", Salary = 45000, designation = "intern" });
            Add(new Serial() { EmpNo = 137, EmpName = "Ayushi",     DeptName = "HR", Salary = 10000, designation = "project_manager" });
            Add(new Serial() { EmpNo = 138, EmpName = "Shweta",     DeptName = "SL", Salary = 59000, designation = "developer" });
            Add(new Serial() { EmpNo = 139, EmpName = "Neha",       DeptName = "IT", Salary = 8000, designation = "clerk" });
            Add(new Serial() { EmpNo = 140, EmpName = "Dhriti",     DeptName = "HR", Salary = 7000, designation = "intern" });
            Add(new Serial() { EmpNo = 141, EmpName = "Shraddha",   DeptName = "SL", Salary = 6000, designation = "manager" });
            Add(new Serial() { EmpNo = 142, EmpName = "Lisa",       DeptName = "IT", Salary = 55000, designation = "developer" });
            Add(new Serial() { EmpNo = 143, EmpName = "Twinkle",    DeptName = "IT", Salary = 11000, designation = "Salesperson" });
            Add(new Serial() { EmpNo = 144, EmpName = "Nirali",     DeptName = "HR", Salary = 12000, designation = "staff" });
            Add(new Serial() { EmpNo = 145, EmpName = "Aditi",      DeptName = "SL", Salary = 13000, designation = "clerk" });
            Add(new Serial() { EmpNo = 146, EmpName = "Tia",        DeptName = "IT", Salary = 45000, designation = "project_manager" });
            Add(new Serial() { EmpNo = 147, EmpName = "Tania",      DeptName = "HR", Salary = 10000, designation = "intern" });
            Add(new Serial() { EmpNo = 148, EmpName = "Anushka",    DeptName = "SL", Salary = 59000, designation = "project_manager" });
            Add(new Serial() { EmpNo = 149, EmpName = "Afreen",     DeptName = "IT", Salary = 8000, designation = "clerk" });
            Add(new Serial() { EmpNo = 150, EmpName = "Saima",      DeptName = "HR", Salary = 75000, designation = "intern" });
        
            }
        }
    }
