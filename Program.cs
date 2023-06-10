using cicli;
using cicli.Files;
using System.Drawing;
using System.IO;
using System.Reflection;

Registry registro = new Registry();


List<Car> list = new List<Car>();
List<Registry> lists = new List<Registry>();
List<string> FileList = new List<string>();
List<Car> listacar = new List<Car>();

for (int i = 0; i < 22; i++)

{
    Car CarRegistry = new Car();
    Hobby hb = new Hobby();
    FileManager fileManager = new FileManager();


    registro.welcome();


    int input = Convert.ToInt32(Console.ReadLine());

    switch (input)
    {
        case 1:
            do
            {
                registro.InputName();
                registro.InputLastname();
                registro.InputAddress();
                registro.InputAge();
                registro.CF = Guid.NewGuid().ToString();
                hb.GetHobbies();
                hb.CFRegistry = registro.CF;
                registro.Hobbys.Add(hb);
                lists.Add(registro);
                Console.WriteLine("\n Do you want to continue? Y/N \n");
                string output = Console.ReadLine();
                if (output == "y" || output == "Y")
                {
                    continue;

                }
                else
                {
                    break;
                }
            } while (true);
            break;
        case 2:
            registro.RegistryList(lists);
            break;
        case 3:
            Console.WriteLine("select one field:");
            Console.WriteLine("1.Address \n2.Lastname\n3.Hobby\nOr press other key to go back");
            string inputsearch = Console.ReadLine();
            Console.Clear();
            if (inputsearch == "1")
            {
                registro.SearchByAddress(lists);
            }
            else if (inputsearch == "2")
            {
                registro.SearchByLastname(lists);
            }
            else if (inputsearch == "3")
            {
                registro.SearchByHobbies(registro.Hobbys, lists);
            }
            break;
        case 4:
            Console.WriteLine("Quitting program...");
            break;
        case 5:

            //Car section

            CarRegistry.CarMenu();
            int InputCar = Convert.ToInt32(Console.ReadLine());

            switch (InputCar)
            {
                case 1:
                    //creating a random and incremental serial number
                    CarRegistry.SerialNumber();

                    //asking Brand's name
                    CarRegistry.AskBrand();
                    //asking Model's name
                    CarRegistry.AskModel();
                    //asking Enginetype
                    CarRegistry.AskEngine();
                    //asking Displacement
                    CarRegistry.AskDisplacement();
                    //asking color
                    CarRegistry.AskColor();


                    Console.WriteLine("Car successfully registered press any key to return to menu");
                    Console.ReadKey();
                    list.Add(CarRegistry);
                    Console.WriteLine("-----------------------------------");
                    continue;

                case 2:
                    CarRegistry.searchCar(list);
                    break;
                case 3:
                    //This method search the car by the Brand's name
                    CarRegistry.SearchCarByBrand(list);
                    break;
                case 4:
                    fileManager.GetImport("C:\\Users\\gabri\\Source\\Repos\\Betacom-ex1\\Files\\", "carsTest.txt", list);

                    //C:\\Users\\Betacom\\source\\repos\\cicli\\Files\\
                    Console.ReadKey();
                    break;
            }
            
            break;
    }
    break;
}