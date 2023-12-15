using KalaKompass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalaKompass.Services
{
    class FishesServices
    {
        private static List<Fish> fishes = new()
        {
            new()
            {
                Name = " KALA",
                HeroImage = "mercury.png",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Description = "skdjskfjdkf"
            },

            new()
            {
                Name = " KALA",
                HeroImage = "jupiter.png",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),

            },
              new()
            {
                Name = " KALA",
                HeroImage = "jupiter.png",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),

            },
                new()
            {
                Name = " KALA",
                HeroImage = "jupiter.png",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),

            },
                new()
                 {
                Name = " KALA",
                HeroImage = "jupiter.png",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),


            }
        };


        public static List<Fish> GetFeaturedFishes()
        {
            var random = new Random();
            var randomizedPlanets = fishes.OrderBy(item => random.Next());

            return randomizedPlanets.Take(2).ToList();
        }

        public static List<Fish> GetAllFishes()
            => fishes;
    }
}
