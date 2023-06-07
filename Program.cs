using cicli;

Registry registro = new Registry();


for (int i = 0; i < 22; i++)
{
    registro.welcome();
    Console.WriteLine("1.Register \n2.View\n3.Search\n4.Exit");
    Console.WriteLine("");
    Console.WriteLine("please, select number:");
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
        Console.WriteLine("1.Address \n2.Lastname");
        string inputsearch = Console.ReadLine();
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
    else
    {

        Console.WriteLine("please insert a valid number");
    }

}




