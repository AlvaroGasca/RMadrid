using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

using RMadrid.ViewModels;

namespace RMadrid.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
    private void ComprarEntradas_Click(object sender, RoutedEventArgs e)
    {
        Frame.Navigate(typeof(EntradasPage));
    }
}
