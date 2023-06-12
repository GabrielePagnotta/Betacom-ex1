using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cicli.Files
{
    internal class Employee
    {
        string Id { get; set; }
        public string Fullname { get; set; }
        public string Category { get; set; }
        public string Task { get; set; }
        List<VacationEmployee> Vacations = new List<VacationEmployee>();

        public void GetEmployee()
        {
            List<Employee> employees = new List<Employee>();
            Console.WriteLine("seleziona un file:");
            string path = "C:\\Users\\Betacom\\source\\repos\\cicli\\Files\\";
            string file = Console.ReadLine();
            string pattern = Path.Combine(path,file);
            string[] showfile = File.ReadAllLines(pattern);
           
                
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

            List<VacationEmployee> Vacations = new List<VacationEmployee>();
             string path2 = "C:\\Users\\Betacom\\source\\repos\\cicli\\Files\\";
             string file2 = Console.ReadLine();
             string pattern2 = Path.Combine(path2,file2);
             string[] showfile2 = File.ReadAllLines(pattern2);

            foreach (var item in employees)
            {
                foreach (var item1 in showfile2)
                {
                    
                    if(item1.Split(";").Count() > 2)
                    {
                        if (item1.Split(";")[2].ToUpper() == item.Id.ToUpper())
                        {
                            Vacations.Add(new VacationEmployee
                            {
                                Data = item1.Split(";")[0],
                                Vacations = item1.Split(";")[1],
                                Code = item1.Split(";")[2]
                            });
                        }
                    }
                }
                
            }
            //da capire perchè non stampa in modo corretto
            foreach (Employee item in employees)
            {
                Console.Write($"Name:{item.Fullname}");
                Console.WriteLine();
                foreach (var item1 in Vacations)
                {
                    
                    Console.Write($"{item1.Data},{item1.Vacations}");
                    Console.WriteLine();
                    

                }
            }




        }
        


    }
}
