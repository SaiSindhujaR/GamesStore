using API.Entities;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace API.Data
{
    public static class DataInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var Products = new List<Product>
            {
                new Product
                {
                    Name = "Star Wars Jedi: Survivor",
                    Description="The story of Cal Kestis continues in Star Wars Jedi: Survivor™, a third person galaxy-spanning action-adventure game from Respawn Entertainment, developed in collaboration with Lucasfilm Games. This narratively-driven, single player title picks up five years after the events of Star Wars Jedi: Fallen Order™ and follows Cal’s increasingly desperate fight as the galaxy descends further into darkness. Pushed to the edges of the galaxy by the Empire, Cal will find himself surrounded by threats new and familiar. As one of the last surviving Jedi Knights, Cal is driven to make a stand during the galaxy’s darkest times - but how far is he willing to go to protect himself, his crew, and the legacy of the Jedi Order?",
                    Price=109,
                    Category="PlayStation",
                    PictureUrl="/Images/Products/starwarJedi.jpg",
                    QuantityInStock=10
                },
                new Product
                {
                    Name = "Crime Boss: Rockay City",
                    Description="Crime Boss: Rockay City is an organized crime game combining first-person shooter action and turf wars, playable solo or with friends. Take on the role of Travis Baker – a man with his sights set on becoming the new King of Rockay City, one crime at a time…",
                    Price=70,
                    Category="PlayStation",
                    PictureUrl="/Images/Products/CrimeBoss.jpg",
                    QuantityInStock=10
                },
                new Product
                {
                    Name = "Hogwarts Legacy",
                    Description="Hogwarts Legacy is an immersive, open-world action RPG set in the world first introduced in the Harry Potter books. Embark on a journey through familiar and new locations as you explore and discover fantastic beasts, customize your character and craft potions, master spell casting, upgrade talents and become the wizard you want to be.",
                    Price=100,
                    Category="PlayStation",
                    PictureUrl="/Images/Products/Hogwarts.jpg",
                    QuantityInStock=10
                },
                new Product
                {
                    Name = "Starfield",
                    Description="In this next-generation role-playing game set amongst the stars, create any character you want and explore with unparalleled freedom as you embark on an epic journey to answer humanity’s greatest mystery.",
                    Price=120,
                    Category="XBox",
                    PictureUrl="/Images/Products/Starfield.jpg",
                    QuantityInStock=10
                },
                new Product
                {
                    Name = "Halo 5: Guardians",
                    Description="In this next-generation role-playing game set amongst the stars, create any character you want and explore with unparalleled freedom as you embark on an epic journey to answer humanity’s greatest mystery.",
                    Price=80,
                    Category="XBox",
                    PictureUrl="/Images/Products/Halos.jpg",
                    QuantityInStock=10
                },
            };

            foreach (var item in Products)
            {
                context.Products.Add(item);
            }

            context.SaveChanges();
        }
    }
}