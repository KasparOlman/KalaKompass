using KalaKompass.Models;
using KalaKompass.Services;

namespace KalaKompass.Views;

public partial class FishesPage : ContentPage
{
	public FishesPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        

        //need tuleb luua fishespage.xaml juures, muidu annavad errotit.
        //lstPopularFish.ItemsSource = FishesServices.GetFeaturedFish();
        //lstAllFish.ItemsSource = FishesServices.GetAllFish();
    }

    async void ApiPic_Clicked(System.Object sender, System.EventArgs e)
    {

    }

    async void GridArea_Tapped(System.Object sender, System.EventArgs e)
    {

    }

    async void Planets_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        await Navigation.PushAsync(new FishDetailsPage(e.CurrentSelection.First() as Fish));
    }
}