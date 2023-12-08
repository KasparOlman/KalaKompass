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

