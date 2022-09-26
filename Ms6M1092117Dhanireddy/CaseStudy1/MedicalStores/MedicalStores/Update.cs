using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStores
{
    class Update
    {
        public void UpdateDetails()
        {
            Console.WriteLine("Enter Name:");
            string Name = Console.ReadLine();

        Console.WriteLine("Enter City :");
            string City = Console.ReadLine();
      

        Console.WriteLine("Enter State :");
            string State = Console.ReadLine();

        Console.WriteLine("Enter Pvt :");
            string Pvt= Console.ReadLine();
       

        Medical obj = new Medical(Name, City, State, Pvt);
        

        }
}
}
