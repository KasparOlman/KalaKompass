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
        //lstPopularFishes.ItemsSource = FishesServices.GetFeaturedFishes();
        lstAllFishes.ItemsSource = FishesServices.GetAllFishes();
    }

    async void MapPage_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MapPage());
    }


    async void ApiPic_Clicked(System.Object sender, System.EventArgs e)
    {

    }

    async void GridArea_Tapped(System.Object sender, System.EventArgs e)
    {

    }

    async void Fishes_SelectionChanged(object sender, SelectionChangedEventArgs e)
    //async void Planets_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        await Navigation.PushAsync(new FishDetailsPage(e.CurrentSelection.First() as Fish));
    }

    private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
        // Convert the search text to lowercase
        string searchTextLower = e.NewTextValue.ToLower();

        // Filter the fishes based on the lowercase search text
        var filteredFishes = FishesServices.GetAllFishes().Where(s => s.Name.ToLower().StartsWith(searchTextLower)).ToList();

        // Update the list view with the filtered results
        lstAllFishes.ItemsSource = filteredFishes;
    }


}