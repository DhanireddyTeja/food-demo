using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStores
{
    class Display
    {
        public void displaydata()
        {
            try
            {
                foreach (var item in Program.list)
                {
                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.City);
                    Console.WriteLine(item.State);
                    Console.WriteLine(item.Pvt);
                    Console.WriteLine("\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
