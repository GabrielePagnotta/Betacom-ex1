using cicli;

Registry registro = new Registry();


List<Car> list = new List<Car>();

for (int i = 0; i < 22; i++)
{
Car CarRegistry = new Car();  
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
            Console.Clear();
            Console.WriteLine("what do you want to do here?");
            Console.WriteLine("1.register a car\n2.show all car registered\n3.search a car");
            int InputCar = Convert.ToInt32(Console.ReadLine());
                
            if (InputCar == 1)
            {

                int repeat = 1;
                CarRegistry.SerialNumber = i + repeat;
                Console.WriteLine("AA" + CarRegistry.SerialNumber);
                CarRegistry.Carasaking();
                list.Add(CarRegistry);
                Console.WriteLine("-----------------------------------");
                

            }else if(InputCar == 2)
            {
                foreach (Car item in list)
                {
                    Console.WriteLine(item.ToString());
                }
            }else if(InputCar == 3)
            {
                Console.Clear();
                Console.WriteLine("Enter the Brand's name to search:");
                string searchCar = Console.ReadLine();
                

                List<Car>lista = new List<Car>();
                
                

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




