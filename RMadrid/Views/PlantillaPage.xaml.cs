using Microsoft.UI.Xaml.Controls;

using RMadrid.ViewModels;

namespace RMadrid.Views;

public sealed partial class PlantillaPage : Page
{
    public PlantillaViewModel ViewModel
    {
        get;
    }

    public PlantillaPage()
    {
        ViewModel = App.GetService<PlantillaViewModel>();
        InitializeComponent();
    }
}
