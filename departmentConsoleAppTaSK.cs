using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp72
{
    class Department
    {
        public string D_Name { get; set; }
        public int EmployeeLimit { get; set; }
        public int Budget { get; set; }
        public Employee[] Employees;
      
        public int RequiredExperience { get; set; }

        public bool IsBachelorDegreeRequired { get; set; }
        public Department()
        {
            Employees = new Employee[0];
        }
        public void AddEmployee(Employee employer)
        {


            Array.Resize(ref Employees, Employees.Length + 1);
            Employees[Employees.Length - 1] = employer;
        }
        public void GetSalaryAverage()
        {
            double getsalary;
            getsalary = Budget / Employees.Length;
            Console.WriteLine(getsalary);

        }
        public void Cancelworker(Employee employerr)
        {
            int index = 0;
            for (int i = index; i < Employees.Length; i++)
            {
                index++;
                Employees[i] = Employees[i - 1];
                Array.Resize(ref Employees, Employees.Length + 1);
                Employees[Employees.Length - 1] = employerr;
            }

        }
    }
        }

    
    
   

