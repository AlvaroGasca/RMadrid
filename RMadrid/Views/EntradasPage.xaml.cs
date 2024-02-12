using Microsoft.UI;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using RMadrid.ViewModels;

namespace RMadrid.Views;

public sealed partial class EntradasPage : Page
{
    public Boolean hayError = true;
    
    public EntradasViewModel ViewModel
    {
        get;
    }

    public EntradasPage()
    {
        ViewModel = App.GetService<EntradasViewModel>();
        InitializeComponent();
    }

    private async void Button_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        ContentDialogResult r = await formulario.ShowAsync();
    }

    private void n_TextChanged(object sender, TextChangedEventArgs e)
    {
        TextBox? textbox = sender as TextBox;

        if(textbox != null)
        {
            if(String.IsNullOrEmpty(textbox.Text)) {
                textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                error.Text = "Los campos deben estar rellenos";
            }
            else
            {
                textbox.BorderBrush = new SolidColorBrush(Colors.Transparent);
                error.Text = String.Empty;
            }
        }
    }
}
