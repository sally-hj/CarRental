using CarRental.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;  // Important pour .Where()

namespace CarRental.Controllers
{
    public class CarController : Controller  // Ajoute la classe !
    {
        public IActionResult Index(string city = "", string type = "", string transmission = "")
        {
            // Simuler des données
            var cars = new List<Car>
            {
                new Car
                {
                    Id = 1,
                    Name = "Renault Clio",
                    FullName = "Renault Clio 2022",
                    Type = "Citadine",
                    PricePerDay = 250,
                    Seats = 5,
                    Transmission = "Automatique",
                    Fuel = "Essence",
                    IsAvailable = true,
                    Images = new List<string>
                    {
                        "https://media.drivingelectric.com/image/private/s--X-WVjvBW--/f_auto,t_content-image-full-desktop@1/v1605901368/Renault_Clio_HEV_014.jpg",
                        " https://images.ctfassets.net/3xid768u5joa/3gYz1F8qB5mrJzKm7vgXDl/00ec6b9235696ea99936b1629f3b243e/01._SCR-Renault-Clio-WhatIsIt.jpg",
                        "https://autofirstgarage.fr/wp-content/uploads/2025/07/Nouvelle-Renault-Clio-6-1ere-photo-pour-linterieur-de-la-citadine-768x512.jpg"
                    }
                },
                new Car
                {
                    Id = 2,
                    Name = "BMW X5",
                    FullName = "BMW X5 2023",
                    Type = "SUV",
                    PricePerDay = 500,
                    Seats = 7,
                    Transmission = "Automatique",
                    Fuel = "Diesel",
                    IsAvailable = true,
                    Images = new List<string>
                    {
                        "https://di-uploads-pod7.dealerinspire.com/sharpebmw/uploads/2023/07/X5_4.png",
                        "https://gtspirit.com/wp-content/uploads/2023/02/2023-BMW-X5-2.jpg",
                        "https://autotijd.be/images/bmw/2023/x5/facelift/bmw-x5-2023-04.jpg"
                    }
                },
                 new Car
                {
                    Id = 3,
                    Name = "Audi Rs",
                    FullName = "Audi RS6 C8",
                    Type = "Berline",
                    PricePerDay = 800,
                    Seats = 5,
                    Transmission = "Automatique",
                    Fuel = " Essence",
                    IsAvailable = true,
                    Images = new List<string>
                    {
                        "https://assets.carandclassic.com/uploads/cars/audi/C1839636/2020-audi-rs6-67b51078b515e.jpg?fit=fillmax&h=800&ixlib=php-4.1.0&q=85&w=800&s=536b2cd7e30503cab5455a2e43f24834",
                        "https://royalrental.co.uk/wp-content/uploads/2022/11/Audi-RS6-Avant-2.jpg",
                        "https://uploads.audi-mediacenter.com/system/production/media/117536/images/fab94b34de59dc3db317e82fd751bd374d45f2ef/A232794_blog.jpg?1698534992",
                        
                    }
                },
                new Car
                {
                    Id = 4,
                    Name = "Toyota Camry",
                    FullName = "Toyota Camry 2023",
                    Type = "Berline",
                    PricePerDay = 400,
                    Seats = 5,
                    Transmission = "Manuelle",
                    Fuel = "Essence",
                    IsAvailable = false,
                    Images = new List<string>
                    {
                        "https://www.pepperstoyota.com/static/brand-toyota/vehicle/2023/Toyota/Camry/MRP/04.jpg",
                        "https://dealerimages.dealereprocess.com/image/upload/3038205",
                        "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQG6bMYMBBc7q115L8v0-DmdrjxKvfpESCe3w&s"
                    }
                }
            };

            // Appliquer les filtres
            if (!string.IsNullOrEmpty(type))
                cars = cars.Where(c => c.Type.ToLower() == type.ToLower()).ToList();
                
            if (!string.IsNullOrEmpty(transmission))
                cars = cars.Where(c => c.Transmission.ToLower() == transmission.ToLower()).ToList();

            return View(cars);
        }
    }
}