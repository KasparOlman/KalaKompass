using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace KalaKompass.Views
{
    public partial class StartPage : ContentPage
    {
        private Random random = new Random();

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

            this.BatchBegin(); // Batch the rendering for optimization

            var fishAnimation = new Animation();

            // Planets Animation
            foreach (var fish in GetShuffledFish())
            {
                fishAnimation.Add(0, 1, new Animation(v => AnimateFish(fish, v), 0, 1));
            }

            // Intro Box
            fishAnimation.Add(0.7, 1, new Animation(v => imgIntro.Opacity = v, 0, 1, Easing.CubicIn));

            // Set up looped animation
            fishAnimation.Commit(this, "TransitionAnimation", 50, 3000, finished: (v, c) => LoopAnimation());

            this.BatchCommit(); // End the rendering batch
        }

        async Task AnimateFish(Image image, double value)
        {
            switch (image.AutomationId)
            {
                case "Haug":
                    // Apply specific animation for Haug
                    await image.TranslateTo((random.NextDouble() > 0.5 ? 1 : -1) * value * 400, 0, 3000, Easing.SinInOut);
                    await image.RotateTo((random.NextDouble() > 0.5 ? 1 : -1) * value * 180, 3000, Easing.SinInOut);
                    break;

                case "Koha":
                    // Apply specific animation for Koha
                    await image.TranslateTo((random.NextDouble() > 0.5 ? 1 : -1) * value * 150, 0, 3000, Easing.SinInOut);
                    await image.RotateTo((random.NextDouble() > 0.5 ? 1 : -1) * value * 90, 3000, Easing.SinOut);
                    break;

                case "Ahven":
                    // Apply specific animation for Ahven
                    await image.TranslateTo((random.NextDouble() > 0.5 ? 1 : -1) * value * 300, 200, 3000, Easing.SinInOut);
                    await image.RotateTo((random.NextDouble() > 0.5 ? 1 : -1) * value * 360, 3000, Easing.SinInOut);
                    break;

                case "Latikas":
                    // Apply specific animation for Latikas
                    await image.TranslateTo((random.NextDouble() > 0.5 ? 1 : -1) * value * 200, 0, 3000, Easing.SinOut);
                    await image.RotateTo((random.NextDouble() > 0.5 ? 1 : -1) * value * 270, 3000, Easing.BounceIn);
                    break;

                default:
                    // Default animation for other fish
                    await image.TranslateTo((random.NextDouble() > 0.5 ? 1 : -1) * value * 100, 0, 3000, Easing.SinInOut);
                    break;
            }

            // Change opacity
            image.Opacity = 1;
        }


        async void FishesView_Clicked(object sender, EventArgs e)
        {
            // Handle Explore Now button click
            await Navigation.PushAsync(new FishesPage());
        }

        async void LoopAnimation()
        {
            await Task.Delay(3000); // Optional delay before restarting the animation
            OnAppearing(); // Restart the animation
        }

        Image[] GetShuffledFish()
        {
            var fish = new Image[] { imgAhven, imgHaug, imgKoha, imgLatikas };
            return fish.OrderBy(x => random.Next()).ToArray();
        }
    }
}
