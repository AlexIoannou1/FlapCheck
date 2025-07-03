
using System;

namespace FlapCheckApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== FlapCheck NDT Inspection App ===");
            Console.WriteLine("Console version - Mobile app structure prototype");
            Console.WriteLine("Note: Running in console mode due to environment limitations");
            Console.WriteLine();
            
            ShowMainMenu();
        }

        static void ShowMainMenu()
        {
            while (true)
            {
                Console.WriteLine("\nMain Menu:");
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
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void ShowDashboard()
        {
            Console.WriteLine("\n=== Dashboard ===");
            Console.WriteLine("- Quick access to start new inspection");
            Console.WriteLine("- Recent activity overview");
            Console.WriteLine("- System status");
            Console.WriteLine("- Active inspections: 3");
            Console.WriteLine("- Pending reports: 1");
            Console.WriteLine("- Calibration alerts: 0");
            Console.WriteLine("\nPress any key to return...");
            Console.ReadKey();
        }

        static void ShowInspections()
        {
            while (true)
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
                        Console.WriteLine("\n--- Repair Orders ---");
                        Console.WriteLine("Manage repair documentation and work orders");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("\n--- Worksheets ---");
                        Console.WriteLine("Handle inspection worksheets and procedures");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("\n--- NDT Reports ---");
                        Console.WriteLine("Generate and manage Non-Destructive Testing reports");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("\n--- Parts Management ---");
                        Console.WriteLine("Track and manage aircraft parts and components");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("\n--- Invoicing ---");
                        Console.WriteLine("Handle billing and invoice generation");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }

        static void ShowStock()
        {
            Console.WriteLine("\n=== Stock Management ===");
            Console.WriteLine("- Inventory tracking");
            Console.WriteLine("- Parts availability");
            Console.WriteLine("- Stock levels monitoring");
            Console.WriteLine("- Low stock alerts");
            Console.WriteLine("- Supplier management");
            Console.WriteLine("\nPress any key to return...");
            Console.ReadKey();
        }

        static void ShowNotifications()
        {
            Console.WriteLine("\n=== Notifications ===");
            Console.WriteLine("- Calibration check reminders");
            Console.WriteLine("- System alerts");
            Console.WriteLine("- Workflow notifications");
            Console.WriteLine("- Maintenance schedules");
            Console.WriteLine("- Compliance updates");
            Console.WriteLine("\nPress any key to return...");
            Console.ReadKey();
        }
    }
}
