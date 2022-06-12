using System;

namespace ConsoleApp72
{
    class Program
    {
       

        static void Main(string[] args)
        {
            string result = "";
            Department departmentt = new Department();
           
            Console.WriteLine("department adin daxil edin");
            departmentt.D_Name = Console.ReadLine();
            Console.WriteLine("max isci sayin  daxil edin");
            departmentt.EmployeeLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("umumi budceni daxil edin");
            departmentt.Budget = int.Parse(Console.ReadLine());
            Console.WriteLine("departmentin iscilerinin en az nece il tecrubesi var?");
            departmentt.RequiredExperience = int.Parse(Console.ReadLine());
            do
            {
                if (departmentt.EmployeeLimit > departmentt.Employees.Length)
                {
                        Employee employe = new Employee();
                        Console.WriteLine("ad daxil edin");
                        employe.Name = Console.ReadLine();
                        Console.WriteLine("soyad daxil edin");
                        employe.Surname = Console.ReadLine();
                        Console.WriteLine(" maas daxil edin");
                        employe.Salary = int.Parse(Console.ReadLine());
                        Console.WriteLine(" iscinin nece il tecrubesi var ?");
                        employe.Experience = int.Parse(Console.ReadLine());
                    if (departmentt.RequiredExperience > employe.Experience)
                    {
                        Console.WriteLine("bu iscinin is tecrubesi bizim departmente uygun deyil");
                        departmentt.Cancelworker(employe);
                    }
                   
                    departmentt.AddEmployee(employe);
                     Console.WriteLine("Isci elave etmek isteyirsinizmi?");
                        result = Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("maks sayda isci var");
                    break;
                }
             }
            while (result == "yes");
            
           
            Console.WriteLine("Isciler departmente elave edildi");
            foreach (var item in departmentt.Employees)
            {

                Console.WriteLine($"{item.Name}****{item.Surname}*****{item.Salary}******{item.Experience}"); 
            }
            Console.Write("Departamentin umumi budcesinin ortalamasi");
            departmentt.GetSalaryAverage();

        }
       

    }
}


