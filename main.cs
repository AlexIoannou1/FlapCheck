
using System;

namespace FlapCheckApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== FlapCheck NDT Inspection App ===");
            Console.WriteLine("Mobile app structure prototype");
            Console.WriteLine("Note: Running in console mode due to environment limitations");
            Console.WriteLine();
            
            ShowMainMenu();
        }

        static void ShowMainMenu()
        {
            while (true)
            {
                Console.WriteLine("Main Menu:");
                Console.WriteLine("1. Dashboard");
                Console.WriteLine("2. Inspections");
                Console.WriteLine("3. Stock");
                Console.WriteLine("4. Notifications");
                Console.WriteLine("5. Exit");
                Console.Write("Select option: ");

                var input = Console.ReadLine();
                
                switch (input)
                {
                    case "1":
                        ShowDashboard();
                        break;
                    case "2":
                        ShowInspections();
                        break;
                    case "3":
                        ShowStock();
                        break;
                    case "4":
                        ShowNotifications();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
                Console.WriteLine();
            }
        }

        static void ShowDashboard()
        {
            Console.WriteLine("\n=== Dashboard ===");
            Console.WriteLine("- Quick access to start new inspection");
            Console.WriteLine("- Recent activity overview");
            Console.WriteLine("- System status");
            Console.WriteLine("Press any key to return...");
            Console.ReadKey();
        }

        static void ShowInspections()
        {
            Console.WriteLine("\n=== Inspections Module ===");
            Console.WriteLine("Available options:");
            Console.WriteLine("1. Repair Orders");
            Console.WriteLine("2. Worksheets");
            Console.WriteLine("3. NDT Reports");
            Console.WriteLine("4. Parts Management");
            Console.WriteLine("5. Invoicing");
            Console.WriteLine("6. Back to main menu");
            
            Console.Write("Select option: ");
            var input = Console.ReadLine();
            
            switch (input)
            {
                case "1":
                    Console.WriteLine("Repair Orders page - Manage repair documentation");
                    break;
                case "2":
                    Console.WriteLine("Worksheets page - Handle inspection worksheets");
                    break;
                case "3":
                    Console.WriteLine("NDT Reports page - Generate and manage NDT reports");
                    break;
                case "4":
                    Console.WriteLine("Parts page - Track and manage parts");
                    break;
                case "5":
                    Console.WriteLine("Invoicing page - Handle billing and invoices");
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
            
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void ShowStock()
        {
            Console.WriteLine("\n=== Stock Management ===");
            Console.WriteLine("- Inventory tracking");
            Console.WriteLine("- Parts availability");
            Console.WriteLine("- Stock levels monitoring");
            Console.WriteLine("Press any key to return...");
            Console.ReadKey();
        }

        static void ShowNotifications()
        {
            Console.WriteLine("\n=== Notifications ===");
            Console.WriteLine("- Calibration check reminders");
            Console.WriteLine("- System alerts");
            Console.WriteLine("- Workflow notifications");
            Console.WriteLine("Press any key to return...");
            Console.ReadKey();
        }
    }
}
