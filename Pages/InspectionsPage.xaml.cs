
using System;

namespace FlapCheckApp.Pages
{
    // Console version of InspectionsPage - functionality moved to main.cs
    public class InspectionsPage
    {
        public static void ShowInspectionsMenu()
        {
            Console.WriteLine("\n=== Inspections Module ===");
            Console.WriteLine("Available options:");
            Console.WriteLine("1. Repair Orders");
            Console.WriteLine("2. Worksheets");
            Console.WriteLine("3. NDT Reports");
            Console.WriteLine("4. Parts Management");
            Console.WriteLine("5. Invoicing");
        }
    }
}
