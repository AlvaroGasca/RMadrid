using Microsoft.UI.Xaml.Controls;

using RMadrid.ViewModels;

namespace RMadrid.Views;

public sealed partial class TrofeosPage : Page
{
    public TrofeosViewModel ViewModel
    {
        get;
    }

    public TrofeosPage()
    {
        ViewModel = App.GetService<TrofeosViewModel>();
        InitializeComponent();
    }
}
