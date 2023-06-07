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
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }

        public List<string> lists = new List<string>();





        /// <summary>
        /// just the grpahic
        /// </summary>
        public void welcome()
        {
            //Welcome graphic
            Console.WriteLine("****************************************************************");
            Console.WriteLine("MAIN MENU");
            DateNow();
            Console.WriteLine("****************************************************************");

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

            lists.Add(Name);
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
                if (Lastname.Length <= 2)
                {
                    Console.WriteLine("Lastname must contain more than 2 characters");
                    continue;
                }
                else
                {
                    break;
                }
            } while (true);
            lists.Add(Lastname);
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
            lists.Add(Address);
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


            lists.Add(Age);
        }

        /// <summary>
        /// this method show the entire list created by the user input
        /// </summary>
        public void list()
        {
            Console.WriteLine("\n Here's your list");
            if (lists.Capacity != 0)
            {

                foreach (string s in lists)
                {

                    Console.WriteLine("*" + s);


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


        //Search methods
        public void SearchByAddress()
        {
            Console.WriteLine("Enter name to search:");
            string searchAddress = Console.ReadLine();

            List<string> foundAddress = lists.FindAll(n => n.Equals(searchAddress, StringComparison.OrdinalIgnoreCase));

            if (foundAddress.Count > 0)
            {
                Console.WriteLine("Address found");
                
            }
            else
            {
                Console.WriteLine("No Address found.");
            }

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine();
        }

        public void SearchByLastname()
        {
            Console.WriteLine("Enter name to search:");
            string searchLastname = Console.ReadLine();

            List<string> foundLastname = lists.FindAll(n => n.Contains(searchLastname));

            if (foundLastname.Count > 0)
            {
                Console.WriteLine("Lastname found");
                Console.WriteLine("--------------------");
                foreach (var lastname in foundLastname)
                {
                    Console.WriteLine(lastname);
                }

            }
            else
            {
                Console.WriteLine("No Ages found.");
            }

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine();
        }


    }
}
