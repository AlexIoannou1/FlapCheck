
namespace FlapCheckApp.Pages;

public partial class WorksheetPage : ContentPage
{
    public WorksheetPage()
    {
        InitializeComponent();
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}
