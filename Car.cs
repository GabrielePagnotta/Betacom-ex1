using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cicli
{
    public class Car
    {
        public object FinalSerial { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string EngineType { get; set; }
        public string Displacement { get; set; }
        public string Color { get; set; }
        .
        public enum CarEngine
        {
            Diesel = 1,
            Gasoline,
            Hybrid,
            Electric
            
        }
        public void Carasaking()
        {
            //asking Brand's name
            do
            {
                Console.WriteLine("name of the brand:");
                Brand = Console.ReadLine();
                if (string.IsNullOrEmpty(Brand))
                {
                    Console.WriteLine("Brand can not be empty");
                    continue;
                }
                else
                {
                    break;
                }
            } while (true);


            //asking Model's name
            do
            {

                Console.WriteLine("Car model's name:");
                Model = Console.ReadLine();
                if (string.IsNullOrEmpty(Model))
                {
                    Console.WriteLine("Model can not be empty");
                    continue;
                }
                else
                {
                    break;
                }
            } while (true);

            //asking Enginetype

            do
            {

                Console.WriteLine("Enginetype: Diesel,Gasoline,Hybrid,Electric");
                 string engineinput = Console.ReadLine();
                
                    EngineType = engineinput;
                    break;
                
                
            } while (true);

            //asking Displacement
            do
            {

                Console.WriteLine("Displacement:");
                Displacement = Console.ReadLine();
                if (!Displacement.Contains('.'))
                {
                    Console.WriteLine("You forgot the dot");
                    continue;
                }
                else if (string.IsNullOrEmpty(Model))
                {
                    Console.WriteLine("Model can not be empty");
                    continue;
                }
                else
                {
                    break;
                }

            } while (true);
            //asking color
            do
            {
                List<string> colors =new List<string>{ "Black", "black", "Pink", "pink", "Blue", "blue", "Purple", "purple", "Gray", "gray", "Red", "red", "Green", "green", "Yellow", "yellow" };
                Console.WriteLine("What is the color of the car?");
                Color = Console.ReadLine();

                colors.FindAll(color => color.Contains(Color));
                if(colors.Contains(Color))
                {
                    
                    break;
                }
                else
                {
                    Console.WriteLine("colore non trovato");
                }

            } while (true);
            Console.WriteLine("Car successfully registered press any key to return to menu");
            Console.ReadKey();

        }


        public override string ToString()
        {
            Console.Clear();
            return $"SerialNumber: {FinalSerial},Brand:{Brand}, Manufacturer: {EngineType}, Model: {Model}, Displacement:{Displacement}cc, Color:{Color}";
        }
    }
}
