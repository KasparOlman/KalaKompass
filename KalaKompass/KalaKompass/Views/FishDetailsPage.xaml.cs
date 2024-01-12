using KalaKompass.Models;
using Microsoft.Maui;

namespace KalaKompass.Views;

public partial class FishDetailsPage : ContentPage
{

    public FishDetailsPage(Fish fish)
    {
        InitializeComponent();

        this.BindingContext = fish;
    }

    async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    async void FavouriteButton_Clicked(object sender, EventArgs e)
    {
        //Fav fish
    }

    async void FishingSeason_Clicked(object sender, EventArgs e)
    {
        try
        {
            // Specify the external link
            var uri = new Uri("https://kalaluba.ee");

            // Open the default browser with the specified URI
            await Launcher.OpenAsync(uri);
        }
        catch (Exception ex)
        {
            // Handle exceptions, e.g., if the URI is invalid
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    private async void OnNavigateButtonClicked(object sender, EventArgs e)
    {
        // Navigate to FishingPassPage when the button is clicked
        await Navigation.PushAsync(new FishingPassPage());
    }

}