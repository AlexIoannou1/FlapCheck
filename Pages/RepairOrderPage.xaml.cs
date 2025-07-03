
namespace FlapCheckApp.Pages;

public partial class RepairOrderPage : ContentPage
{
    public RepairOrderPage()
    {
        InitializeComponent();
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}
