using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cicli
{
    class Registry
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public string CF { get; set; }
        public List<Hobby> Hobbys { get; set; } = new List<Hobby>();

        
        


        /// <summary>
        /// just the grpahic
        /// </summary>
        public void welcome()
        {
            //Welcome graphic
            Console.Clear();
            Console.WriteLine("****************************************************************");
            Console.WriteLine("MAIN MENU");
            DateNow();
            Console.WriteLine("****************************************************************");
            Console.WriteLine("1.Register \n2.View\n3.Search\n4.Exit\n5.Car\n6.Import Employee");
            Console.WriteLine("");
            Console.WriteLine("please, select a number:");

        }

        /// <summary>
        /// input name that user must insert
        /// </summary>
        public void InputName()
        {
            //input name

            do
            {

                Console.WriteLine("Insert Name");

                Name = Console.ReadLine();

                if (Name.Length <= 2)
                {
                    Console.WriteLine("Name must contain more than 2 characters");
                    continue;
                }
                else
                {
                    break;
                }
            } while (true);

            
        }

        /// <summary>
        /// input lastname that user must insert
        /// </summary>
        public void InputLastname()
        {
            do
            {

                Console.WriteLine("Insert Lastname");

                Lastname = Console.ReadLine();
               
                if (Lastname.Length <= 2 )
                {
                    Console.WriteLine("Lastname must contain more than 2 characters");
                    continue;
                }
                else
                {
                    break;
                }
            } while (true);
            
        }

        /// <summary>
        /// input address that user must insert
        /// </summary>
        public void InputAddress()
        {
            //input address

            do
            {

                Console.WriteLine("Insert Address");

                Address = Console.ReadLine();
                if (Address.Length <= 2)
                {
                    Console.WriteLine("Address must contain more than 2 characters");
                    continue;
                }
                else
                {
                    break;
                }
            } while (true);
           
        }

        /// <summary>
        /// input age that user must insert
        /// </summary>
        public void InputAge()
        {
            //input age
            do
            {

                Console.WriteLine("Insert age");
                Age = Console.ReadLine();
                int inegers;

                if (!int.TryParse(Age, out inegers))

                {
                    Console.WriteLine("Letters are not allowed");
                    continue;
                }
                else
                {
                    break;
                }
            } while (true);


            
        }
        

        /// <summary>
        /// Method to show the real data with greetings
        /// </summary>
        public void DateNow()
        {
            string time = DateTime.Now.ToString("hh:mm:ss");
            int Date = DateTime.Now.Hour;
            Console.WriteLine(time);

            if (Date > 0 && Date <= 12)
            {
                Console.WriteLine("Good morning user");
            }
            else
            {
                Console.WriteLine("Good Afternoon user");
            }

        }

        public void RegistryList(List<Registry> lists)
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

        public void SearchByAddress(List<Registry> lists)
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

        public void SearchByLastname(List<Registry> lists)
        {

            Console.WriteLine("Search by Lastname");
            Console.WriteLine("------------------------");
            Console.WriteLine("Enter name to search:");
            string searchLastname = Console.ReadLine();

            List<Registry> foundLastname = new List<Registry>();

            foundLastname = lists.FindAll(a => a.Lastname.Contains(searchLastname));
            if (foundLastname.Count > 0)
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
        }
        public void SearchByHobbies(List<Hobby> Hobbys,List<Registry>lists)
        {
            Console.WriteLine("Enter hobby to search:");
            string searchhobby = Console.ReadLine();

            Hobbys.FindAll(g => g.HobbyName.Contains(searchhobby));
            if (Hobbys.Count > 0)
            {
                foreach (var gg in lists)
                {
                    foreach (var item in gg.Hobbys)
                    {
                        Console.WriteLine($"Name:{gg.Name},Lastname:{gg.Lastname},Hobby:{item.HobbyName},CF:{item.CFRegistry}");
                    }
                }

            }
            else { Console.WriteLine("nothing found"); }
            Console.ReadKey();
        }


        public override string ToString()
        {
            
            return $"name:{Name}, Lastname:{Lastname},Address:{Address}, Age:{Age} CF:{CF}";
        }





    }
}
