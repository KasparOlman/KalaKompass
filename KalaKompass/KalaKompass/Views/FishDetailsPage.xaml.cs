using KalaKompass.Models;

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
        //External link to season pass
    }
}