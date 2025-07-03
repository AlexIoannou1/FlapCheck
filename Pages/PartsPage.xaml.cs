
using Microsoft.Maui.Controls;

namespace FlapCheckApp.Pages;

public partial class PartsPage : ContentPage
{
    public PartsPage()
    {
        InitializeComponent();
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}
