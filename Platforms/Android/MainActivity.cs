using Android.App;
using Android.Content.PM;
using Microsoft.Maui;

namespace FlapCheckApp;

[Activity(
    Theme = "@style/Maui.SplashTheme",
    MainLauncher = true,                         // ⬅ tells Android to run this activity
    ConfigurationChanges =
        ConfigChanges.ScreenSize |
        ConfigChanges.Orientation |
        ConfigChanges.UiMode |
        ConfigChanges.ScreenLayout |
        ConfigChanges.SmallestScreenSize |
        ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
}
