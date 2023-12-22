using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace KalaKompassi.Views
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

            var parentAnimation = new Animation();

            // Fish Animation
            var shuffledFish = GetShuffledFish();
            foreach (var fish in shuffledFish)
            {
                parentAnimation.Add(0, 1, new Animation(v => AnimateFish(fish, v), 0, 1));
            }

            // Intro Box
            parentAnimation.Add(0.7, 1, new Animation(v => imgIntro.Opacity = v, 1, 1, Easing.CubicIn));

            // Set up looped animation
            parentAnimation.Commit(this, "TransitionAnimation", 16, 300, finished: (v, c) => LoopAnimation(shuffledFish));
        }

        async Task AnimateFish(Image image, double value)
        {
            // Translate the image horizontally to the left
            image.TranslationX = -value * 1000; // Adjust the value for the desired swimming effect

            // Add a sinusoidal motion to the vertical position for a more natural swim
            double amplitude = 50; // Adjust the amplitude for the desired height of the swim
            double frequency = 2; // Adjust the frequency for the speed of the swim
            image.TranslationY = amplitude * Math.Sin(2 * Math.PI * frequency * value);

            // Change opacity
            image.Opacity = 1;

            // Check if the fish is off-screen and reset its position
            if (image.TranslationX < -1000)
            {
                ResetFishPosition(image);
            }
        }

        async void LoopAnimation(Image[] fishArray)
        {
            while (true)
            {
                await Task.Delay(6000); // Wait before the animation restarts
                ResetFishPositions(fishArray);
                await AnimateFishLoop(fishArray); // Start the animation again
            }
        }

        async Task AnimateFishLoop(Image[] fishArray)
        {
            var parentAnimation = new Animation();

            var shuffledFish = GetShuffledFish();
            foreach (var fish in shuffledFish)
            {
                parentAnimation.Add(0, 1, new Animation(v => AnimateFish(fish, v), 0, 1));
            }

            parentAnimation.Commit(this, "TransitionAnimation", 16, 3000, finished: (v, c) => ResetFishPositions(fishArray));
        }

        void ResetFishPositions(Image[] fishArray)
        {
            foreach (var fish in fishArray)
            {
                ResetFishPosition(fish);
            }
        }

        void ResetFishPosition(Image fish)
        {
            fish.TranslationX = this.Width; // Start from the right side of the screen
            fish.TranslationY = random.Next((int)this.Height); // Random vertical position
            fish.Opacity = 1;
        }

        Image[] GetShuffledFish()
        {
            var fish = new Image[] { imgKoha, imgAhven, imgHaug, imgLatikas }; // Add other fish images as needed
            return fish.OrderBy(x => random.Next()).ToArray();
        }



    }
}