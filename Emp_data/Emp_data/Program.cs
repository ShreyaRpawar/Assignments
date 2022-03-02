using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_data
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Emp_data employee = new Emp_data();
            Departments departments = new Departments();
            bool exit = true;
            char Input;
            while (exit = true)
            {
                Console.WriteLine("\n\nEnter 1 for Ascending order  Employee\n" +
                    "Enter 2 for Count Employee\n" +
                    "Enter 3 for sum of Employee by deptname \n" +
                    "Enter 4 for Max Salary per deptName\n" +
                    "Enter 5 for  Min Salary per deptName\n" +
                    "Enter 6 for Average per DeptName\n" +
                    "Enter 7 for  Designation Group \n" +
                    "Enter 8 for Display All employee those are Managers, Directors only\n " +
                    "Enter 9 to Print All employee Having Salary in Range 25000 to 75000\n" +
                    "Enter 10 to Print Employee with Second MAx Salary Per DeptName\n " +
                    "Enter 11 to Print Employee with Second Max Salary\n " +
                    "Enter 12 to  Calculate Tax for Each Employee as followa\n" +
                    "Enter  13 for join\n" +
                    "Enter 14 to exit");
                int Num = int.Parse(Console.ReadLine());
                switch (Num)
                {
                    case 1:
                        EmployeeAscending(ref employee);
                        break;
                    case 2:
                        DeptCount(ref employee);
                        break;
                    case 3:
                        DeptWiseSumSalary(ref employee);

                        break;
                    case 4:
                        DeptWiseMaxSalary(ref employee);
                        break;
                    case 5:
                        DeptWiseMinSalary(ref employee);
                        break;
                    case 6:
                        DeptWiseAvgSalary(ref employee);
                        break;
                    case 7:
                        DesigWiseGroup(ref employee);
                        break;
                    case 8:
                        DisplayEmployee(ref employee);
                        break;
                    case 9:
                        SalaryRange(ref employee);
                        break;
                    case 10:
                        secondMaxSalaryDeptWise(ref employee);
                        break;
                    case 11:
                        SecondMaxSalary(ref employee);
                        break;
                    case 12:
                        _Tax(ref employee);
                        break;
                    case 13:
                        Join(ref employee, ref departments);
                        break;

                    case 14:
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("Please select Valid Entry");
                        break;


                }

            }
        }

                static void EmployeeAscending(ref Emp_data emps)
                {
                    var res = from e in emps
                              orderby e.EmpName
                              select e;
                    foreach (var e in res)
                    {
                        Console.WriteLine($"{e.EmpName}");
                    }

                }

                static void DeptCount(ref Emp_data emps)
                {
                    var res1 = (from e in emps
                                group e by e.DeptName into deptgroup
                                select new
                                {
                                    DeptName = deptgroup.Key,
                                    DeptCount = deptgroup.Count()
                                });
                    foreach (var record in res1)
                    {
                        Console.WriteLine($"Group by ={record.DeptName} and count ={record.DeptCount}");
                    }
                }
                static void DeptWiseSumSalary(ref Emp_data emps)
                {
                    var res1 = (from e in emps
                                group e by e.DeptName into deptgroup
                                select new
                                {
                                    DeptName = deptgroup.Key,
                                    SumSalary = deptgroup.Sum(x => x.Salary)
                                });

                    foreach (var record in res1)
                    {
                        Console.WriteLine($"Group Key = {record.DeptName} and Sum of Salary {record.SumSalary}");
                    }
                }
                static void DeptWiseMaxSalary(ref Emp_data emps)
                {
                    var res1 = (from e in emps
                                group e by e.DeptName into deptgroup
                                select new
                                {
                                    DeptName = deptgroup.Key,
                                    MaxSalary = deptgroup.Max(x => x.Salary)
                                });

                    foreach (var record in res1)
                    {
                        Console.WriteLine($"Group Key = {record.DeptName} and Sum of Salary {record.MaxSalary}");
                    }
                }
                static void DeptWiseMinSalary(ref Emp_data emps)
                {
                    var res1 = (from e in emps
                                group e by e.DeptName into deptgroup
                                select new
                                {
                                    DeptName = deptgroup.Key,
                                    MinSalary = deptgroup.Min(x => x.Salary)
                                });

                    foreach (var record in res1)
                    {
                        Console.WriteLine($"Group Key = {record.DeptName} and Sum of Salary {record.MinSalary}");
                    }
                }
                static void DeptWiseAvgSalary(ref Emp_data emps)
                {
                    var res1 = (from e in emps
                                group e by e.DeptName into deptgroup
                                select new
                                {
                                    DeptName = deptgroup.Key,
                                    AvgSalary = deptgroup.Average(x => x.Salary)
                                });

                    foreach (var record in res1)
                    {
                        Console.WriteLine($"Group Key = {record.DeptName} and Sum of Salary {record.AvgSalary}");
                    }
                }
                static void DesigWiseGroup(ref Emp_data emps)
                {
                    var res1 = (from e in emps
                                group e by e.Designation into desiggroup
                                select new  // The Group Data is Stored in the Anonymous Type 
                                {
                                    DesigName = desiggroup.Key, // Key aka the Property on WHich the Group is created
                                    Records = desiggroup.ToList() // List of Records per Group
                                });

                    foreach (var record in res1)
                    {
                        Console.WriteLine($"Group Key = {record.DesigName}");

                    }
                }
                static void DisplayEmployee(ref Emp_data emps)
                {
                    var DisplEmp = emps.Where(e => e.Designation == "Manager" || e.Designation == "Director");


                    foreach (var record in DisplEmp)
                    {

                        Console.WriteLine($" {record.EmpName} = {record.Designation}");

                    }


                }
                static void SalaryRange(ref Emp_data emps)
                {
                    var rangeSal = emps.Where(e => e.Salary >= 25000 && e.Salary <= 75000)
                                       .Select(x => x);
                    foreach (var record in rangeSal)
                    {
                        Console.WriteLine($"{record.EmpName}");
                    }



                }
                static void secondMaxSalaryDeptWise(ref Emp_data emps)
                {
                    var ref1 = (from e in emps
                                group e by e.DeptName into deptgroup
                                select new
                                {
                                    DeptName = deptgroup.Key,
                                    SecondmaxSalary = deptgroup.OrderByDescending(x => x.Salary).Select(x => x.Salary).Distinct().Take(2).Skip(2 - 1).FirstOrDefault()

                                }); ;
                    foreach (var record in ref1)
                    {
                        Console.WriteLine($"{record.DeptName}={record.SecondmaxSalary}");
                    }
                }
                static void SecondMaxSalary(ref Emp_data emps)
                {
                    var employeeList = emps;
                    var rangeSal = emps.OrderByDescending(x => x.Salary).Select(x => x.Salary).Distinct().Take(2).Skip(2 - 1).FirstOrDefault();
                    foreach (var record in emps)
                    {
                        if (record.Salary == rangeSal)
                        {
                            Console.WriteLine($"{record.EmpName} = {record.Salary}");
                        }
                    }
                }
                static void _Tax(ref Emp_data emps)
                {
                    Console.WriteLine("Salary from >=20K to <=40K is 0.05%");
                    var tax1 = emps.Where(e => e.Salary >= 20000 && e.Salary <= 40000).Select(x => x);
                    foreach (var tax in tax1)
                    {
                        Console.WriteLine($"{tax.EmpName} , {tax.DeptName} , {tax.Salary - (tax.Salary * (.05 / 100))}");
                    }
                    Console.WriteLine("Salary from >40K to <=60K is 0.1%");
                    var tax2 = emps.Where(e => e.Salary >= 40000 && e.Salary <= 60000).Select(x => x);
                    foreach (var tax in tax2)
                    {
                        Console.WriteLine($"{tax.EmpName} , {tax.DeptName} , {tax.Salary - (tax.Salary * (.01 / 100))}");
                    }
                    Console.WriteLine("Salary <20K is 0 ");
                    var tax3 = emps.Where(e => e.Salary >= 20000 && e.Salary <= 40000).Select(x => x);
                    foreach (var tax in tax3)
                    {
                        Console.WriteLine($"{tax.EmpName} , {tax.DeptName} , {tax.Salary - (tax.Salary * (.05 / 100))}");
                    }
                    Console.WriteLine("Salary >60K is 0.15%");
                    var tax4 = emps.Where(e => e.Salary > 60000).Select(x => x);
                    foreach (var tax in tax4)
                    {
                        Console.WriteLine($"{tax.EmpName} , {tax.DeptName} , {tax.Salary - (tax.Salary * (.15 / 100))}");
                    }

                }
                static void Join(ref Emp_data emps, ref Departments dept)
                {
                    var join = from s in emps
                               join s1 in dept
                               on s.EmpNo equals s1.DeptNo
                               select new
                               {
                                   EmployeeNo = s.EmpNo,
                                   EmpName = s.EmpName,
                                   Designation = s.Designation,
                                   Depatment = s.DeptName,
                                   Location = s1.Location,
                                   salary = s.Salary


                               };
                    foreach (var record in join)
                    {
                        Console.WriteLine($"{record.EmployeeNo}  {record.EmpName}  {record.Designation} {record.Location} {record.Depatment}  {record.salary}");
                    }
                }


    }
        


}
    

    
    
