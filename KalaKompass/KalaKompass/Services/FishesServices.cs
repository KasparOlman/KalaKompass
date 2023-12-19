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
                Name = "LATIKAS",
                HeroImage = "mercury.png",
                Subtitle = "",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Description = "skdjskfjdkf",
                Images = new()
                {
                    "",
                }
            },

            new()
            {
                Name = "AHVEN",
                HeroImage = "jupiter.png",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),

            },
              new()
            {
                Name = "KILU",
                HeroImage = "jupiter.png",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),

            },
                new()
            {
                Name = "RÄIM",
                HeroImage = "jupiter.png",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),

            },
                new()
                 {
                Name = "LÕHE",
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
