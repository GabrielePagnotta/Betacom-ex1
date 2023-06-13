using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;

namespace cicli.Files
{
    internal class Employee
    {
        string Id { get; set; }
        public string Fullname { get; set; }
        public string Category { get; set; }
        public string Task { get; set; }
        public List<VacationEmployee> Vacations { get; set; }

        public void GetEmployee()
        {
            List<Employee> employees = new List<Employee>();
            
            string path = "C:\\Users\\Betacom\\source\\repos\\cicli\\Files\\";
            string file = ConfigurationManager.AppSettings["File"];
            string pattern = Path.Combine(path,file);
            ClassLibrary1.Class1.Read(pattern);
            string[]showfile = File.ReadAllLines(pattern);

            foreach (var elem in showfile)
            {
                employees.Add(new Employee
                {
                    Id = elem.Split(";")[0],
                    Fullname = elem.Split(";")[1],
                    Category = elem.Split(";")[2],
                    Task = elem.Split(";")[3],
                    Vacations = new List<VacationEmployee>()
                });

            }


            
            string file2 = "EmployeesActivities.txt";
            string pattern2 = Path.Combine(path, file2);
            string[] showfile2 = File.ReadAllLines(pattern2);
            foreach (Employee emp in employees)
            {
                emp.Vacations = new List<VacationEmployee>();

                foreach (var item in showfile2)
                {

                    if (item.Split(';').Count() > 2)
                    {
                        if (item.Split(';')[2] == emp.Id)
                        {
                            emp.Vacations.Add(new VacationEmployee
                            {
                                Data = item.Split(';')[0],
                                Vacations = item.Split(';')[1],
                                Code = item.Split(";")[2]
                            });
                        }
                    }
               

                }
            }

            foreach (Employee item in employees)
            {
                Console.WriteLine();
                Console.Write($"Name:{item.Fullname}");
                Console.WriteLine();
                JsonSerializer.Serialize(employees, new JsonSerializerOptions { WriteIndented = true });
                if (item.Vacations.Count() > 0)
                {
                    foreach (var item1 in item.Vacations)
                    {
                        Console.Write($"{item1.Data},{item1.Vacations}");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("nothing found");
                }


                string JJ = JsonSerializer.Serialize(employees, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("C:\\Users\\Betacom\\source\\repos\\cicli\\Files\\JSONOutput.txt", JJ);


            }




        }



    }
}