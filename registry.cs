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
        public string CF { get; set; }
        public List<Hobby> Hobbys { get; set; } = new List<Hobby>();

        
        


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


        public override string ToString()
        {
            
            return $"name:{Name}, Lastname:{Lastname},Address:{Address}, Age:{Age} CF:{CF}";
        }





    }
}
