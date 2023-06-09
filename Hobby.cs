using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cicli
{
    public class Hobby
    {
        public int Id { get; set; }
        public string HobbyName { get; set; }
        public string CFRegistry { get; set; }
    public void GetHobbies()
    {
        Console.WriteLine("do you have any hobbies?");
        Console.WriteLine("1.yes");
        Console.WriteLine("2.no"); 
        int choice = Convert.ToInt32(Console.ReadLine());

            if(choice == 1)
            {
                Id = 1;
                Id++;
                Console.WriteLine("Name of the hobby");
                HobbyName = Console.ReadLine();
                
            }
            
    }
    }

}
