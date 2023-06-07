using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cicli
{
    internal class Car
    {
        public int SerialNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string EngineType { get; set; }
        public string Displacement { get; set; }
        
      
        public void Carasaking()
        {
            Console.WriteLine("name of the brand:");
            Brand = Console.ReadLine();
            Console.WriteLine("Car model's name:");
            Model = Console.ReadLine();
            Console.WriteLine("Enginetype:");
            EngineType = Console.ReadLine();
            Console.WriteLine("Displacement:");
            Displacement =Console.ReadLine();
            Console.WriteLine("Car successfully registered press ani key to retun to menu");
            Console.ReadKey();

        }

        
        public override string ToString()
        {
            return $"SerialNumber: AA{SerialNumber},Brand:{Brand}, Manufacturer: {EngineType}, Model: {Model}, Displacement:{Displacement}cc";
        }
    }
}
