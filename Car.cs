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
        
        public enum CarEngine
        {
            Diesel = 1,
            Gasoline,
            Hybrid,
            Electric
            
        }

        public void CarMenu()
        {
            Console.Clear();
            Console.WriteLine("What do you want to do here?");
            Console.WriteLine("1.register a car\n2.show all car registered\n3.search a car\n4.Import cars");
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

        public void AskColor()
        {
            do
            {
                List<string> colors = new List<string> { "Black", "black", "Pink", "pink", "Blue", "blue", "Purple", "purple", "Gray", "gray", "Red", "red", "Green", "green", "Yellow", "yellow" };
                Console.WriteLine("What is the color of the car?");
                Color = Console.ReadLine();

                colors.FindAll(color => color.Contains(Color));
                if (colors.Contains(Color))
                {

                    break;
                }
                else
                {
                    Console.WriteLine("colore non trovato");
                }

            } while (true);
        }

        public void AskDisplacement()
        {
            do
            {

                Console.WriteLine("Displacement:");
                Displacement = Console.ReadLine();
                if (!Displacement.Contains('.'))
                {
                    Console.WriteLine("You forgot the dot");
                    continue;
                }
                else if (string.IsNullOrEmpty(Displacement))
                {
                    Console.WriteLine("Displacement can not be empty");
                    continue;
                }
                else
                {
                    break;
                }

            } while (true);
        }

        public void AskEngine()
        {
            do
            {

                Console.WriteLine("Enginetype: Diesel,Gasoline,Hybrid,Electric");
                string engineinput = Console.ReadLine();

                EngineType = engineinput;
                break;


            } while (true);
        }

        public void AskModel()
        {
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
        }

        public void AskBrand()
        {
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

        }

        public void SearchCarByBrand(List<Car>list)
        {
            //search by brand's name section
            Console.Clear();

            //input to search
            Console.WriteLine("Enter the Brand's name to search:");
            string searchCar = Console.ReadLine();


            List<Car> lista = new List<Car>();


            //checking if the input contains any elements in the list
            if (!string.IsNullOrEmpty(searchCar))
            {
                lista = list.FindAll(elem => elem.Brand.Contains(searchCar));
            }
            foreach (var auto in lista)
            {
                Console.WriteLine(auto.ToString());
            }



            Console.WriteLine("Press any key to return.");
            Console.ReadKey();
            Console.WriteLine();
        }

        public void searchCar(List<Car>list)
        {
            Console.Clear();
            Console.WriteLine("CARS LIST:");
            Console.WriteLine("*****************************************");

            foreach (Car item in list)
            {
                Console.WriteLine(item.ToString());
            }

            if (list.Count == 0)
            {
                Console.WriteLine("No Cars in list");
            }
            Console.WriteLine("press any key to return back");
            Console.ReadKey();
            
        }

        public void SerialNumber()
        {
            string[] SerialLetter = { "A", "B", "C", "D", "E", "F", "G" };
            for (int i = 0; i < SerialLetter.Length; i++)
            {

            Random rnd = new Random();
            int Random = rnd.Next(0, 6);
            int repeat = 1;
            int SerialNumber = i + repeat;

            FinalSerial = SerialLetter[Random + 1] + SerialLetter[Random] + SerialNumber;
            }
            Console.WriteLine(FinalSerial);
        }


        public override string ToString()
        {
            Console.Clear();
            return $"SerialNumber: {FinalSerial},Brand:{Brand}, Manufacturer: {EngineType}, Model: {Model}, Displacement:{Displacement}cc, Color:{Color}";
        }
    }
}



