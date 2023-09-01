using FarmRepositoryPattern.BusinessLayer;
using FarmRepositoryPattern.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmRepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of FarmBusiness
            FarmBusiness customerBusiness = new FarmBusiness(new FarmRepository());
            bool isRunning = true;
            // Main loop for user interaction.
            while (isRunning)
            {
                try
                {
                    Console.WriteLine("Please Type 'L' for List, 'A' for Add, 'U' for Update, 'D' for Delete, 'S' for Search,'C' for Clear, 'X' for Exit.");
                    string command = Console.ReadLine();
                    if (command == "L")
                    {
                        // List all farms
                        List<Farm> _listCustomer = customerBusiness.Get();
                        Console.WriteLine("List of Customer:");
                        Console.WriteLine("ID   |   Name    |   Address");
                        foreach (Farm _customer in _listCustomer)
                        {
                            Console.WriteLine(_customer.Id + "  |   " + _customer.Name + "  |   " + _customer.Address);
                        }
                    }
                    else if (command == "S")
                    {
                        // Search for a farm by ID
                        Console.WriteLine("Input a id to find a customer:");
                        string id = Console.ReadLine();
                        Farm aCstomer = customerBusiness.Get(Convert.ToInt32(id));
                        Console.WriteLine(aCstomer.Id + ". " + aCstomer.Name + " -- " + aCstomer.Address);
                    }
                    else if (command == "A")
                    {
                        // Add a new farm
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a address:");
                        string address = Console.ReadLine();
                        Farm aCustomer = new Farm();
                        aCustomer.Id = Convert.ToInt32(id);
                        aCustomer.Name = name;
                        aCustomer.Address = address;
                        bool isExecuted = customerBusiness.Add(aCustomer);
                        if (isExecuted)
                        {
                            Console.WriteLine("Added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to add.");
                        }
                    }
                    else if (command == "U")
                    {
                        // Update an existing farm
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a address:");
                        string address = Console.ReadLine();
                        Farm aCustomer = new Farm();
                        aCustomer.Id = Convert.ToInt32(id);
                        aCustomer.Name = name;
                        aCustomer.Address = address;
                        bool isExecuted = customerBusiness.Update(aCustomer);
                        if (isExecuted)
                        {
                            Console.WriteLine("Updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to update.");
                        }
                    }
                    else if (command == "D")
                    {
                        // Delete a farm based on ID
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        bool isExecuted = customerBusiness.Delete(Convert.ToInt32(id));
                        if (isExecuted)
                        {
                            Console.WriteLine("Deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to delete.");
                        }
                    }
                    else if (command == "C")
                    {
                        Console.Clear();
                    }
                    else if (command == "X")
                    {
                        isRunning = false;
                    }
                    else
                    {
                        Console.WriteLine("Command not found.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
