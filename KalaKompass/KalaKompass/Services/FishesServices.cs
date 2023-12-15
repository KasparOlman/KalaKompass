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
                Name = "Haug",
                HeroImage = "haug.png",
                Description = "Mercury is the smallest planet in the Solar ",
                Habitat = "Sea",
                Diet = "Food",
                Season = "Mondays",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://science.nasa.gov/_ipx/w_2048&f_webp/https://smd-cms.nasa.gov/wp-content/uploads/2023/05/pia19422-mercury.jpg"
                }

            },
        };




        public static List<Fish> GetFeaturedFishes()
        {
            var random = new Random();
            var randomizedFishes = fishes.OrderBy(item => random.Next());

            return randomizedFishes.Take(2).ToList();
        }

        public static List<Fish> GetAllFishes()
            => fishes;
    }
}

