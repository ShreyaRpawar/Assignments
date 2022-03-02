using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
        internal class Fileop
        {
            public void CalculateTax(IEnumerable<Serial> emp)
            {
                operations FileOperations = new operations();
                var tax = from e in emp
                          group e by e.designation into desigtn
                          select new
                          {
                              designation = desigtn.Key,
                              Record = desigtn.ToList()
                          };

                foreach (var item in tax)
                {
                    foreach (var record in item.Record)
                    {
                        double HRA = 0;
                        double TS = 0;
                        double DA = 0;
                        double gross = 0;
                        double Tax = 0;
                        int netSalary = 0;

                        if (record.designation == "Manager")
                        {
                            HRA = (record.Salary * .1);
                            TS = (record.Salary * .15);
                            DA = (record.Salary * .15);
                        }

                        if (record.designation == "Director")
                        {
                            HRA = (record.Salary * .2);
                            TS = (record.Salary * .3);
                            DA = (record.Salary * .4);
                        }
                        gross = HRA + TS + DA + record.Salary;

                        if (record.Salary > 500000 && record.Salary <= 1000000)
                        {
                            Tax = gross * .2;

                        }
                        if (record.Salary > 1000000 && record.Salary <= 2000000)
                        {
                            Tax = gross * .25;

                        }
                        if (record.Salary > 2000000)
                        {
                            Tax = gross * .3;
                        }

                        int Filename = record.EmpNo;
                        netSalary = (int)(gross - Tax);
                        FileOperations.CreateFile(record, HRA, TS, DA, gross, Tax, netSalary, Filename);


                    }
                }


            }
            public static string NumberToWords(int number)
            {
                if (number == 0)
                    return "zero";
                if (number < 0)
                    return "minus " + NumberToWords(Math.Abs(number));
                string words = "";

                if ((number / 100000) > 0)
                {
                    words += NumberToWords(number / 100000) + " lacs ";
                    number %= 100000;
                }
                if ((number / 1000) > 0)
                {
                    words += NumberToWords(number / 1000) + " thousand ";
                    number %= 1000;
                }
                if ((number / 100) > 0)
                {
                    words += NumberToWords(number / 100) + " hundred ";
                    number %= 100;
                }
                if (number > 0)
                {
                    if (words != "")
                        words += "and ";
                    String[] unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                    String[] tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
                    if (number < 20)
                        words += unitsMap[number];
                    else
                    {
                        words += tensMap[number / 10];
                        if ((number % 10) > 0)
                            words += "-" + unitsMap[number % 10];
                    }
                }
                return words;
            }
        }
    }

