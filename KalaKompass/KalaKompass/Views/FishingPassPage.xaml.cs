namespace KalaKompass.Views;

public partial class FishingPassPage : ContentPage
{
	public FishingPassPage()
	{
		InitializeComponent();
	}

    async void FishingPass_Clicked(object sender, EventArgs e)
    {
        try
        {
            // Specify the external link
            var uri = new Uri("https://kalaluba.ee/fishingCard");

            // Open the default browser with the specified URI
            await Launcher.OpenAsync(uri);
        }
        catch (Exception ex)
        {
            // Handle exceptions, e.g., if the URI is invalid
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    async void HobbyPass_Clicked(object sender, EventArgs e)
    {
        try
        {
            // Specify the external link
            var uri = new Uri("https://kalaluba.ee/hobbyFishingPermit");

            // Open the default browser with the specified URI
            await Launcher.OpenAsync(uri);
        }
        catch (Exception ex)
        {
            // Handle exceptions, e.g., if the URI is invalid
            Console.WriteLine($"Error: {ex.Message}");
        }
    }


}

