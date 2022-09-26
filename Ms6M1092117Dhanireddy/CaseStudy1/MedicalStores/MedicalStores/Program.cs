using System;
using System.Collections.Generic;

namespace MedicalStores
{
    class Program
    {
        public static List<Medical> list = new List<Medical>();

        public static object MedicalDetails { get; private set; }


        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Press 1 for Add details of Medical ");
                    Console.WriteLine("Press 2 for Display details of Medical ");
                    Console.WriteLine("Press 3 for Update details of Medical ");
                    string num = Console.ReadLine();
                    int n = Convert.ToInt32(num);
                    if (n == 1)
                    {
                        Console.WriteLine("Create details are :");
                        CreateData data = new CreateData();
                        data.Createdata();
                    }
                    if (n == 2)
                    {
                        Console.WriteLine("Total details are :");
                        Display display = new Display();
                        display.displaydata();
                    }
                    if (n == 3)
                    {
                        Console.WriteLine("Total details are :");
                        Update update = new Update();
                        update.UpdateDetails();

                    }



                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
