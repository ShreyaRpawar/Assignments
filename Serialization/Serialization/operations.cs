using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    internal class operations
    {
        Emp_data fileoperations = new Emp_data();
        string path = @"C:\New folder (2)";

        public object Emp { get; private set; }

        public void CreateFile(Serial emp, double HRA, double TA, double DA, double gross, double tax, int netSalary, int Filename)
        {


            string filePath = $"{path}\\{Filename}";
            


            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate);
            byte[] content = new UTF8Encoding(true).GetBytes(
                               $"-------------------------Salary Slip--------------------------\n" +
                               $"| EmpNo: {emp.EmpNo}            EmpName: {emp.EmpName}       |\n" +
                               $"| DeptName: {emp.DeptName}   designation: {emp.designation}  |\n" +
                               $"|____________________________________________________________|\n" +
                               $"|Income (Rs.)                  | Deduction (Rs.)             |\n" +
                               $"|------------------------------------------------------------|\n" +
                               $"|Basic Salary: {emp.Salary}    |                             |\n" +
                               $"|HRA:         {HRA}            |                             |\n" +
                               $"|TA:           {TA}            |                             |\n" +
                               $"|DA:            {DA}           |                             |\n" +
                               $"|------------------------------------------------------------|\n" +
                               $"|Gross:                        |          {gross}            |\n" +
                               $"|------------------------------------------------------------|\n" +
                               $"|Total tax                     |  Tax: {tax}                 |\n" +
                               $"|------------------------------------------------------------|\n" +
                               $"|NetSalary:                    |      {netSalary}            |\n" +
                               $"|------------------------------------------------------------|\n" +
                               $"|NetSalary in Words:{Fileop.NumberToWords(netSalary)}only|\n"+
                               $"--------------------------------------------------------------");

            formatter.Serialize(fs, content);
            fs.Close();




        }
    }
}

    

