
namespace FlapCheckApp.Pages;

public partial class NDTReportPage : ContentPage
{
    public NDTReportPage()
    {
        InitializeComponent();
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}
