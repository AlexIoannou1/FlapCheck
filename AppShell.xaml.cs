
using Microsoft.Maui.Controls;

namespace FlapCheckApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Register routes for detailed pages
        Routing.RegisterRoute(nameof(Pages.RepairOrderPage), typeof(Pages.RepairOrderPage));
        Routing.RegisterRoute(nameof(Pages.WorksheetPage), typeof(Pages.WorksheetPage));
        Routing.RegisterRoute(nameof(Pages.NDTReportPage), typeof(Pages.NDTReportPage));
        Routing.RegisterRoute(nameof(Pages.PartsPage), typeof(Pages.PartsPage));
        Routing.RegisterRoute(nameof(Pages.InvoicingPage), typeof(Pages.InvoicingPage));
    }
}
