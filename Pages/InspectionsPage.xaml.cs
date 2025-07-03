
namespace FlapCheckApp.Pages;

public partial class InspectionsPage : ContentPage
{
    public InspectionsPage()
    {
        InitializeComponent();
    }

    private async void OnRepairOrderClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(RepairOrderPage));
    }

    private async void OnWorksheetClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(WorksheetPage));
    }

    private async void OnNDTReportClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(NDTReportPage));
    }

    private async void OnPartsClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(PartsPage));
    }

    private async void OnInvoicingClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(InvoicingPage));
    }
}
