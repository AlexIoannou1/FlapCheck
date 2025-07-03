
namespace FlapCheckApp.Pages;

public partial class DashboardPage : ContentPage
{
    public DashboardPage()
    {
        InitializeComponent();
    }

    private async void OnStartInspectionClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//InspectionsPage");
    }
}
