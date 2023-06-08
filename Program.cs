using cicli;

Registry registro = new Registry();


List<Car> list = new List<Car>();

for (int i = 0; i < 22; i++)
{
Car CarRegistry = new Car();  
    Console.Clear();
    registro.welcome();
    Console.WriteLine("1.Register \n2.View\n3.Search\n4.Exit\n5.Car");
    Console.WriteLine("");
    Console.WriteLine("please, select a number:");
    try
    {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == 1)
        {

            registro.InputName();
            registro.InputLastname();
            registro.InputAddress();
            registro.InputAge();
            Console.WriteLine("\n Do you want to continue? Y/N \n");
            string output = Console.ReadLine();
            if (output == "y" || output == "Y")
            {

                do
                {

                    registro.InputName();
                    registro.InputLastname();
                    registro.InputAddress();
                    registro.InputAge();
                    Console.WriteLine("\n Do you want to continue? Y/N \n");
                    string output2 = Console.ReadLine();
                    if (output2 == "y" || output2 == "Y")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                } while (true);


            }


        }
        else if (input == 2)
        {
            registro.list();

        }
        else if (input == 3)
        {

            Console.WriteLine("select one field:");
            Console.WriteLine("1.Address \n2.Lastname\nOr press other key to go back");
            string inputsearch = Console.ReadLine();
            Console.Clear();
            if (inputsearch == "1")
            {
                Console.WriteLine("Search by Address");
                Console.WriteLine("------------------------");
                registro.SearchByAddress();
            }
            else if (inputsearch == "2")
            {
                Console.WriteLine("Search by Lastname");
                Console.WriteLine("------------------------");
                registro.SearchByLastname();
            }


        }
        else if (input == 4)
        {
            Console.WriteLine("Quitting program...");
            break;
        }
        else if (input == 5)
        {
            //Car section

            Console.Clear();
            Console.WriteLine("What do you want to do here?");
            Console.WriteLine("1.register a car\n2.show all car registered\n3.search a car");
            int InputCar = Convert.ToInt32(Console.ReadLine());
                
            if (InputCar == 1)
            {
                //creating a random and incremental serial number
                Random rnd = new Random();
                int Random = rnd.Next(0, 6);
                string[] SerialLetter = { "A", "B", "C", "D","E","F","G" };
                int repeat = 1;
                int SerialNumber = i + repeat;

                CarRegistry.FinalSerial = SerialLetter[Random + 1]+ SerialLetter[Random] + SerialNumber;
                Console.WriteLine(CarRegistry.FinalSerial);
                //Console.WriteLine("AA" + CarRegistry.SerialNumber);

                //program ask user the necessary informations about the car 
                CarRegistry.Carasaking();
                list.Add(CarRegistry);
                Console.WriteLine("-----------------------------------");
                

            }else if(InputCar == 2)
            {
                //section to show the all information inserted
                Console.Clear();
                Console.WriteLine("CARS LIST:");
                Console.WriteLine("*****************************************");

                foreach (Car item in list)
                {
                    Console.WriteLine(item.ToString());
                }

                if(list.Count == 0)
                {
                    Console.WriteLine("No Cars in list");
                }
                Console.WriteLine("press any key to return back");
                Console.ReadKey();

            }
            else if(InputCar == 3)
            {
                //search by brand's name section
                Console.Clear();

                //input to search 
                Console.WriteLine("Enter the Brand's name to search:");
                string searchCar = Console.ReadLine();
                

                List<Car>lista = new List<Car>();
                
                
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

        }
    }
    catch (Exception)
    {
        Console.Clear();
        Console.WriteLine("** please insert a number **");

    }



}




