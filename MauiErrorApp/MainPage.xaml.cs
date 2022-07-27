namespace MauiErrorApp;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel model)
    {
        InitializeComponent();
        BindingContext = model;
    }
}