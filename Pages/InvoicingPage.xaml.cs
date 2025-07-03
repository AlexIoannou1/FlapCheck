
namespace FlapCheckApp.Pages;

public partial class InvoicingPage : ContentPage
{
    public InvoicingPage()
    {
        InitializeComponent();
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}
