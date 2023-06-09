using cicli;

Registry registro = new Registry();


List<Car> list = new List<Car>();
List<Registry> lists = new List<Registry>();

for (int i = 0; i < 22; i++)
{
    Car CarRegistry = new Car();  
    Hobby hb = new Hobby();
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
            registro.CF=Guid.NewGuid().ToString();
            hb.GetHobbies();
            hb.CFRegistry = registro.CF;
            registro.Hobbys.Add(hb);
            lists.Add(registro);
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
                    lists.Add(registro);
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
            Console.WriteLine("\n Here's your list");
            if (lists.Capacity != 0)
            {

                foreach (Registry s in lists)
                {

                    Console.WriteLine("*" + s.ToString());


                }
            }
            else
            {
                Console.WriteLine("info not found");
            }

            Console.WriteLine("press any key to return back");
            Console.ReadKey();
            Console.WriteLine();

        }
        else if (input == 3)
        {

            Console.WriteLine("select one field:");
            Console.WriteLine("1.Address \n2.Lastname\n3.Hobby\nOr press other key to go back");
            string inputsearch = Console.ReadLine();
            Console.Clear();
            if (inputsearch == "1")
            {
                Console.WriteLine("Search by Address");
                Console.WriteLine("------------------------");
                Console.WriteLine("Enter name to search:");
                string searchAddress = Console.ReadLine();

                List<Registry> foundAddress = new List<Registry>();

                foundAddress = lists.FindAll(h => h.Address.Contains(searchAddress));
                if (foundAddress.Count > 0)
                {
                    foreach (var address in foundAddress)
                    {
                        Console.WriteLine(address);
                    }

                }
                else
                {
                    Console.WriteLine("No Address found.");
                }

                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.WriteLine();
            }
            else if (inputsearch == "2")
            {
                Console.WriteLine("Search by Lastname");
                Console.WriteLine("------------------------");
                Console.WriteLine("Enter name to search:");
                string searchLastname = Console.ReadLine();

                List<Registry> foundLastname = new List<Registry>();

                foundLastname = lists.FindAll(a => a.Lastname.Contains(searchLastname));
                if (foundLastname.Count>0)
                {
                    
                    foreach (var lastname in foundLastname)
                    {
                        Console.WriteLine(lastname.ToString());
                    }

                }
                else
                {
                    Console.WriteLine("No Lastnames found.");
                }

                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.WriteLine();
            }else if(inputsearch == "3")
            {
                Console.WriteLine("Enter hobby to search:");
                string searchhobby = Console.ReadLine();
                
                 registro.Hobbys.FindAll(g => g.HobbyName.Contains(searchhobby));
                if (registro.Hobbys.Count > 0)
                {
                    foreach (var gg in lists)
                    {
                        foreach (var item in gg.Hobbys)
                        {
                            Console.WriteLine($"Name:{gg.Name},Lastname:{gg.Lastname},Hobby:{item.HobbyName},CF:{item.CFRegistry}");
                        }
                    }
                    
                }else { Console.WriteLine("nothing found"); }
                Console.ReadKey();
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




