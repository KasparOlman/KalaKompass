namespace KalaKompass.Views;

public partial class StartPage : ContentPage
{
    public StartPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (this.AnimationIsRunning("TransitionAnimation"))
        {
            return;
        }

        var parentAnimation = new Animation();

        //Fish Animation

        //Intro Box
        parentAnimation.Add(0.7, 1, new Animation(v =>/* intro image*/Opacity = v, 0, 1, Easing.CubicIn));

        parentAnimation.Commit(this, "TransitionAnimation", 16, 3000, null, null);
    }

    async void ExploreNow_Clicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new FishesPage());
}