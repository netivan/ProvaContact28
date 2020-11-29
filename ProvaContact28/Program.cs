using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaContact28
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact co = new Contact();
            co.SSN = "198201114-5548";
            co.Firstname = "Pedro";
            co.Lastname = "santana";

            SQLService.CreateContact(co);


            List<Contact> contats = new List<Contact>();

           contats= SQLService.ReadAllContact();

            

            // Console.WriteLine(SQLService.ReadContact(1));

            foreach (var c in contats)
                Console.WriteLine(c);

          
            Console.ReadLine();



        }
    }
}
