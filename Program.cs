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
            registro.InputName();
            registro.InputLastname();
            registro.InputAddress();
            registro.InputAge();


        }
        

    }else if (input == 2)
    {
        registro.list();

    }
    else if(input == 3)
    {
        
        Console.WriteLine("select one field:");
        Console.WriteLine("1.Name \n2.Age");
        string inputsearch = Console.ReadLine();
        if(inputsearch == "1")
        {

            registro.SearchByName();
        }
        else if(inputsearch == "2") 
        {
            registro.SearchByAge();
        }
        
         
    }
    else if(input == 4)
    {
        Console.WriteLine("quitting program...");
        break;
    }
        Console.WriteLine("please insert a valid number");
    
}




