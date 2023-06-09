using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace cicli.Files
{
    public class FileManager
    {
        public void GetImport(string path,string filename,List<Car>listacar) 
        {
            string[] arraycolor = { "Black", "Yellow", "Blue", "Green" };
            Random rnd = new Random();
            int Random = rnd.Next(0, 3);
            string randomcolor = arraycolor[Random++];
            string directory = path + filename;
            
            string[] file = File.ReadAllLines(directory);
            
            foreach (string line in file)
            {
                Console.WriteLine(file);
                string[] split = line.Split(':');
                listacar.Add(new Car
                {
                    FinalSerial = split[0],
                    Brand = split[1],
                    Model = split[2],
                    EngineType = split[3],
                    Displacement = split[4],
                    Color = randomcolor
                });
            }
            foreach (var item in listacar)
            {
                Console.WriteLine(item);
            }
        }

        public void GetImport(List<Car>listacar)
        {
            
            string askList;
            string path = $"C:\\Users\\Betacom\\source\\repos\\cicli\\Files\\carsTest.txt";
            string[] bon = File.ReadAllLines(path);


            foreach (var item in bon)
            {
                string[] listsplitted = item.Split(':');
              
                    listacar.Add(new Car
                    {
                        FinalSerial = listsplitted[0],
                        Brand = listsplitted[1],
                        Model= listsplitted[2],
                        EngineType = listsplitted[3],
                        Displacement = listsplitted[4]

                    });
                
            }
            foreach (var item in listacar)
            {
                Console.WriteLine($"Serial Number:{item.FinalSerial}, Brand:{item.Brand}, Model:{item.Model}, Enginetype:{item.EngineType}, Displacement:{item.Displacement}");
            }
            // C:\Users\Betacom\source\repos\cicli\Files\carsTest.txt

        }

       
    }
}
