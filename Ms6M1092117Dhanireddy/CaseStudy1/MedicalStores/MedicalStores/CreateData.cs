using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStores
{
    class CreateData
    {
        public List<Medical> list = new List<Medical>();
        public void Createdata()
        {
            Console.WriteLine("Enter a number how many Medical want to");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)

                try
                {
                    Console.WriteLine("Enter details of Medical!");
                    Console.WriteLine("Enter Name");
                    string Name= Console.ReadLine();
                    

                    Console.WriteLine("Enter City");
                    string City = Console.ReadLine();

                    Console.WriteLine("Enter State ");
                    string State = Console.ReadLine();
                   

                    Console.WriteLine("Enter Pvt");
                    string Pvt = Console.ReadLine();


                    Medical medical = new Medical(Name,City,State,Pvt);
                    Program.list.Add(medical);
                    Console.WriteLine();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
        }
    }
}
