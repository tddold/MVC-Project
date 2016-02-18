namespace App.Data.Migrations
{
    using System;
    using System.Collections.Generic;

    using Models;

    public class SeedData
    {
        private static Random rand = new Random();

        private List<Category> categories;

        private List<User> users;

        public SeedData(List<User> users)
        {
            this.users = users;

            // Categories --------------------------------
            this.categories = new List<Category>();
            this.categories.Add(new Category()
            {
                Name = "Phones",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                ImagePath = "/Images/SeedImages/category/1.png"
            });
            this.categories.Add(new Category()
            {
                Name = "Cameras",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                ImagePath = "/Images/SeedImages/category/2.png"
            });
            this.categories.Add(new Category()
            {
                Name = "Personal computers",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                ImagePath = "/Images/SeedImages/category/3.png"
            });
            this.categories.Add(new Category()
            {
                Name = "Gaming consoles",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                ImagePath = "/Images/SeedImages/category/4.png"
            });
            this.categories.Add(new Category()
            {
                Name = "TV sets",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                ImagePath = "/Images/SeedImages/category/5.png"
            });

            // country -----------------------
            this.Countries = new List<Country>();
            this.Countries.Add(new Country { Name = "Bulgaria" });

            // cities -----------------------
            this.Cities = new List<City>();
            this.Cities.Add(new City() { Name = "Plovdiv" });
            this.Cities.Add(new City() { Name = "Sofia" });
            this.Cities.Add(new City() { Name = "Varna" });

            // Addresss -----------------------
            this.Addresss = new List<Address>();
            this.Addresss.Add(new Address()
            {
                Country = this.Countries[0],
                City = this.Cities[this.GetRandomNumber(0, this.Addresss.Count - 1)],
                Street = "Vasil Levski 2",
                Latitude = 42.145404,
                Longitude = 24.7480313
            });
            this.Addresss.Add(new Address()
            {
                Country = this.Countries[0],
                City = this.Cities[this.GetRandomNumber(0, this.Addresss.Count - 1)],
                Street = "Vasil Levski 2",
                Latitude = 42.145404,
                Longitude = 24.7480313
            });
            this.Addresss.Add(new Address()
            {
                Country = this.Countries[0],
                City = this.Cities[this.GetRandomNumber(0, this.Addresss.Count - 1)],
                Street = "Vasil Levski 2",
                Latitude = 42.145404,
                Longitude = 24.7480313
            });
            this.Addresss.Add(new Address()
            {
                Country = this.Countries[0],
                City = this.Cities[this.GetRandomNumber(0, this.Addresss.Count - 1)],
                Street = "Vasil Levski 2",
                Latitude = 42.145404,
                Longitude = 24.7480313
            });

            // Promotions -----------------------
            this.Promotions = new List<Promotion>();

            this.Promotions.Add(new Promotion()
            {
                Name = "First promotion",
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(30),
                ImagePath = "/Images/SeedImages/promo/3.jpg"
            });
            this.Promotions.Add(new Promotion()
            {
                Name = "Second promotion",
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(30),
                ImagePath = "/Images/SeedImages/promo/2.jpg"
            });
            this.Promotions.Add(new Promotion()
            {
                Name = "Third promotion",
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(30),
                ImagePath = "/Images/SeedImages/promo/3.jpg"
            });

            // Products -----------------------
            this.Products = new List<Product>();

            this.Products.Add(new Product()
            {
                Name = "Galaxy S6",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                //Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                Category = this.categories[0],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Samsung",
                Price = 1050,
                Quantity = 5,
                Whidth = 10,
                Heigth = 15,
                Depht = 4,
                Weight = 0.5,
                ImagePath = "/Images/SeedImages/products/Galaxy/1.png"
                //Images = new List<Image>() {
                //    new Image() { ImagePath = "/Images/SeedImages/products/Galaxy/1.png"},
                //    new Image() { ImagePath = "/Images/SeedImages/products/Galaxy/2.png" },
                //    new Image() { ImagePath = "/Images/SeedImages/products/Galaxy/3.png" }
                // }
            });
            this.Products.Add(new Product()
            {
                Name = "Galaxy Edge",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                //Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                Category = this.categories[0],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Samsung",
                Price = 1050,
                Quantity = 5,
                Whidth = 10,
                Heigth = 15,
                Depht = 4,
                Weight = 0.5,
                ImagePath = "/Images/SeedImages/products/Edge/1.jpg"
                //Images = new List<Image>()
                //{
                //    new Image() { ImagePath = "/Images/SeedImages/products/Edge/1.jpg" },
                //    new Image() { ImagePath = "/Images/SeedImages/products/Edge/2.jpg" },
                //    new Image() { ImagePath = "/Images/SeedImages/products/Edge/3.jpg" }
                //}
            });
            this.Products.Add(new Product()
            {
                Name = "XPERIA Z5",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                //Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                Category = this.categories[0],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Sony",
                Price = 1020,
                Quantity = 5,
                Whidth = 10,
                Heigth = 15,
                Depht = 4,
                Weight = 0.5,
                ImagePath = "/Images/SeedImages/products/Xperia/1.jpg"
                //Images = new List<Image>()
                //{
                //    new Image() { ImagePath = "/Images/SeedImages/products/Xperia/1.jpg" },
                //    new Image() { ImagePath = "/Images/SeedImages/products/Xperia/2.jpg" },
                //    new Image() { ImagePath = "/Images/SeedImages/products/Xperia/2.jpg" }
                //}
            });
            this.Products.Add(new Product()
            {
                Name = "iPhone 6S",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                //Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                Category = this.categories[0],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Apple",
                Price = 1350,
                Quantity = 5,
                Whidth = 10,
                Heigth = 15,
                Depht = 4,
                Weight = 0.5,
                ImagePath = "/Images/SeedImages/products/iPhone/1.png"
                //Images = new List<Image>()
                //{
                //    new Image() { ImagePath = "/Images/SeedImages/products/iPhone/1.png" },
                //    new Image() { ImagePath = "/Images/SeedImages/products/iPhone/2.png" },
                //    new Image() { ImagePath = "/Images/SeedImages/products/iPhone/3.png" }
                //}
            });
            this.Products.Add(new Product()
            {
                Name = "Microsoft Lumia 950 XL",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                //Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                Category = this.categories[0],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Nokia",
                Price = 1050,
                Quantity = 5,
                Whidth = 10,
                Heigth = 15,
                Depht = 4,
                Weight = 0.5,
                ImagePath = "/Images/SeedImages/products/Lumia/1.jpg"
                //Images = new List<Image>()
                //{
                //    new Image() { ImagePath = "/Images/SeedImages/products/Lumia/1.jpg" }
                //}
            });
            this.Products.Add(new Product()
            {
                Name = "D5200",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                //Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                Category = this.categories[1],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Nikon",
                Price = 1050,
                Quantity = 5,
                Whidth = 40,
                Heigth = 25,
                Depht = 15,
                Weight = 2,
                ImagePath = "/Images/SeedImages/products/D5200/1.jpg"
                //Images = new List<Image>()
                //{
                //    new Image() { ImagePath = "/Images/SeedImages/products/D5200/1.jpg" },
                //    new Image() { ImagePath = "/Images/SeedImages/products/D5200/2.jpg" },
                //    new Image() { ImagePath = "/Images/SeedImages/products/D5200/3.jpg" }
                //}
            });
            this.Products.Add(new Product()
            {
                Name = "D7200",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                //Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                Category = this.categories[1],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Nikon",
                Price = 1550,
                Quantity = 5,
                Whidth = 40,
                Heigth = 25,
                Depht = 15,
                Weight = 2,
                ImagePath = "/Images/SeedImages/products/D7200/1.jpg"
                //Images = new List<Image>()
                //{
                //    new Image() { ImagePath = "/Images/SeedImages/products/D7200/1.jpg" },
                //    new Image() { ImagePath = "/Images/SeedImages/products/D7200/2.jpg" },
                //    new Image() { ImagePath = "/Images/SeedImages/products/D7200/3.jpg" }
                //}
            });
            this.Products.Add(new Product()
            {
                Name = "D3200",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                //Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                Category = this.categories[1],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Nikon",
                Price = 1550,
                Quantity = 5,
                Whidth = 40,
                Heigth = 25,
                Depht = 15,
                Weight = 2,
                ImagePath = "/Images/SeedImages/products/D3200/1.jpg"
                //Images = new List<Image>()
                //{
                //    new Image { ImagePath = "/Images/SeedImages/products/D3200/1.jpg" },
                //    new Image { ImagePath = "/Images/SeedImages/products/D3200/2.jpg" },
                //    new Image { ImagePath = "/Images/SeedImages/products/D3200/3.jpg" }
                //}
            });
            this.Products.Add(new Product()
            {
                Name = "EOS-100D",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                //Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                Category = this.categories[1],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Canon",
                Price = 1550,
                Quantity = 5,
                Whidth = 40,
                Heigth = 25,
                Depht = 15,
                Weight = 2,
                ImagePath = "/Images/SeedImages/products/100d/1.jpg"
                //Images = new List<Image>()
                //{
                //    new Image { ImagePath = "/Images/SeedImages/products/100d/1.jpg" },
                //    new Image { ImagePath = "/Images/SeedImages/products/100d/2.jpg" },
                //    new Image { ImagePath = "/Images/SeedImages/products/100d/3.jpg" }
                //}
            });
            this.Products.Add(new Product()
            {
                Name = "EOS-5D Mark III",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                //Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                Category = this.categories[1],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Canon",
                Price = 1550,
                Quantity = 5,
                Whidth = 40,
                Heigth = 25,
                Depht = 15,
                Weight = 2,
                ImagePath = "/Images/SeedImages/products/5d/1.jpg"
                //Images = new List<Image>()
                //{
                //    new Image { ImagePath = "/Images/SeedImages/products/5d/1.jpg" },
                //    new Image { ImagePath = "/Images/SeedImages/products/5d/2.jpg" },
                //    new Image { ImagePath = "/Images/SeedImages/products/5d/3.jpg" }
                //}
            });
            this.Products.Add(new Product()
            {
                Name = "EOS-750D",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                //Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                Category = this.categories[1],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Canon",
                Price = 1550,
                Quantity = 5,
                Whidth = 40,
                Heigth = 25,
                Depht = 15,
                Weight = 2,
                ImagePath = "/Images/SeedImages/products/750d/1.jpg"
                //Images = new List<Image>()
                //{
                //    new Image { ImagePath = "/Images/SeedImages/products/750d/1.jpg" },
                //    new Image { ImagePath = "/Images/SeedImages/products/750d/2.jpg" },
                //    new Image { ImagePath = "/Images/SeedImages/products/750d/3.jpg" }
                //}
            });
            this.Products.Add(new Product()
            {
                Name = "SAL-A58",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                //Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                Category = this.categories[1],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Sony",
                Price = 1550,
                Quantity = 5,
                Whidth = 40,
                Heigth = 25,
                Depht = 15,
                Weight = 2,
                ImagePath = "/Images/SeedImages/products/a58/1.jpg"
                //Images = new List<Image>()
                //{
                //    new Image { ImagePath = "/Images/SeedImages/products/a58/1.jpg" },
                //    new Image { ImagePath = "/Images/SeedImages/products/a58/2.jpg" },
                //    new Image { ImagePath = "/Images/SeedImages/products/a58/2.jpg" }
                //}
            });
            this.Products.Add(new Product()
            {
                Name = "ILCA-77M2",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                //Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                Category = this.categories[1],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Sony",
                Price = 1550,
                Quantity = 5,
                Whidth = 40,
                Heigth = 25,
                Depht = 15,
                Weight = 2,
                ImagePath = "/Images/SeedImages/products/ilca77/1.jpg"
                //Images = new List<Image>()
                //{
                //    new Image { ImagePath = "/Images/SeedImages/products/ilca77/1.jpg" },
                //    new Image { ImagePath = "/Images/SeedImages/products/ilca77/2.jpg" },
                //    new Image { ImagePath = "/Images/SeedImages/products/ilca77/3.jpg" }
                //}
            });
            this.Products.Add(new Product()
            {
                Name = "KDL-48W705",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                //Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                Category = this.categories[4],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Sony",
                Price = 1250,
                Quantity = 5,
                Whidth = 140,
                Heigth = 80,
                Depht = 35,
                Weight = 20,
                ImagePath = "/Images/SeedImages/products/48W705/1.png"
                //Images = new List<Image>()
                //{
                //    new Image { ImagePath = "/Images/SeedImages/products/48W705/1.png" },
                //    new Image { ImagePath = "/Images/SeedImages/products/48W705/2.png" },
                //    new Image { ImagePath = "/Images/SeedImages/products/48W705/3.png" }
                //}
            });
            this.Products.Add(new Product()
            {
                Name = "KDL-43W809",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                //Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                Category = this.categories[4],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Sony",
                Price = 1250,
                Quantity = 5,
                Whidth = 140,
                Heigth = 80,
                Depht = 35,
                Weight = 20,
                ImagePath = "/Images/SeedImages/products/43W809/1.png"
                //Images = new List<Image>()
                //{
                //    new Image { ImagePath = "/Images/SeedImages/products/43W809/1.png" },
                //    new Image { ImagePath = "/Images/SeedImages/products/43W809/2.png" },
                //    new Image { ImagePath = "/Images/SeedImages/products/43W809/2.png" }
                //}
            });
            this.Products.Add(new Product()
            {
                Name = "KD-49X8309C",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                //Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                Category = this.categories[4],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Sony",
                Price = 1250,
                Quantity = 5,
                Whidth = 140,
                Heigth = 80,
                Depht = 35,
                Weight = 20,
                ImagePath = "/Images/SeedImages/products/49X8309C/1.png"
                //Images = new List<Image>()
                //{
                //    new Image { ImagePath = "/Images/SeedImages/products/49X8309C/1.png" },
                //    new Image { ImagePath = "/Images/SeedImages/products/49X8309C/2.png" }
                //}
            });
            this.Products.Add(new Product()
            {
                Name = "KD-43X8307C",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                //Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                Category = this.categories[4],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Sony",
                Price = 1250,
                Quantity = 5,
                Whidth = 140,
                Heigth = 80,
                Depht = 35,
                Weight = 20,
                ImagePath = "/Images/SeedImages/products/43X8307C/1.png"
                //Images = new List<Image>()
                //{
                //    new Image { ImagePath = "/Images/SeedImages/products/43X8307C/1.png" },
                //    new Image { ImagePath = "/Images/SeedImages/products/43X8307C/2.png" },
                //    new Image { ImagePath = "/Images/SeedImages/products/43X8307C/3.png" },
                //}
            });
            this.Products.Add(new Product()
            {
                Name = "KD-55S8005C",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                //Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                Category = this.categories[4],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Sony",
                Price = 1250,
                Quantity = 5,
                Whidth = 140,
                Heigth = 80,
                Depht = 35,
                Weight = 20,
                ImagePath = "/Images/SeedImages/products/55S8005C/1.png"
                //Images = new List<Image>()
                //{
                //    new Image { ImagePath = "/Images/SeedImages/products/55S8005C/1.png" },
                //    new Image { ImagePath = "/Images/SeedImages/products/55S8005C/2.png" },
                //    new Image { ImagePath = "/Images/SeedImages/products/55S8005C/3.png" }
                //}
            });
            this.Products.Add(new Product()
            {
                Name = "KDL-50W809C",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                //Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                Category = this.categories[4],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Sony",
                Price = 1250,
                Quantity = 5,
                Whidth = 140,
                Heigth = 80,
                Depht = 35,
                Weight = 20,
                ImagePath = "/Images/SeedImages/products/50W809C/1.png"
                //Images = new List<Image>()
                //{
                //    new Image { ImagePath = "/Images/SeedImages/products/50W809C/1.png" },
                //    new Image { ImagePath = "/Images/SeedImages/products/50W809C/2.png" },
                //    new Image { ImagePath = "/Images/SeedImages/products/50W809C/3.png" }
                //}
            });
            this.Products.Add(new Product()
            {
                Name = "KD-49X8005C",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                //Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                Category = this.categories[4],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Sony",
                Price = 1250,
                Quantity = 5,
                Whidth = 140,
                Heigth = 80,
                Depht = 35,
                Weight = 20,
                ImagePath = "/Images/SeedImages/products/49X8005C/1.png"
                //Images = new List<Image>()
                //{
                //    new Image { ImagePath = "/Images/SeedImages/products/49X8005C/1.png" },
                //    new Image { ImagePath = "/Images/SeedImages/products/49X8005C/2.png" },
                //    new Image { ImagePath = "/Images/SeedImages/products/49X8005C/3.png" }
                //}
            });
            this.Products.Add(new Product()
            {
                Name = "Playstation 4",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                //Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                Category = this.categories[3],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Sony",
                Price = 800,
                Quantity = 5,
                Whidth = 50,
                Heigth = 40,
                Depht = 15,
                Weight = 5,
                ImagePath = "/Images/SeedImages/products/PS4/1.jpg"
                //Images = new List<Image>()
                //{
                //    new Image { ImagePath = "/Images/SeedImages/products/PS4/1.jpg" },
                //    new Image { ImagePath = "/Images/SeedImages/products/PS4/2.jpg" },
                //    new Image { ImagePath = "/Images/SeedImages/products/PS4/3.jpg" }
                //}
            });
            this.Products.Add(new Product()
            {
                Name = "Playstation Vita",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                //Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                Category = this.categories[3],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Sony",
                Price = 800,
                Quantity = 5,
                Whidth = 15,
                Heigth = 10,
                Depht = 5,
                Weight = 0.5,
                ImagePath = "/Images/SeedImages/products/VITA/1.jpg"
                //Images = new List<Image>()
                //{
                //    new Image { ImagePath = "/Images/SeedImages/products/VITA/1.jpg" },
                //    new Image { ImagePath = "/Images/SeedImages/products/VITA/2.jpg" },
                //    new Image { ImagePath = "/Images/SeedImages/products/VITA/3.jpg" },
                //}
            });
            this.Products.Add(new Product()
            {
                Name = "MacBook Pro",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                //Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                Category = this.categories[2],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Apple",
                Price = 800,
                Quantity = 5,
                Whidth = 15,
                Heigth = 10,
                Depht = 5,
                Weight = 0.5,
                ImagePath = "/Images/SeedImages/products/MacBook/1.png"
                //Images = new List<Image>()
                //{
                //    new Image { ImagePath = "/Images/SeedImages/products/MacBook/1.png" },
                //    new Image { ImagePath = "/Images/SeedImages/products/MacBook/2.png" },
                //    new Image { ImagePath = "/Images/SeedImages/products/MacBook/3.png" },
                //}
            });
        }

        public List<Product> Products { get; set; }

        public List<Promotion> Promotions { get; set; }

        public List<Country> Countries { get; set; }

        public List<City> Cities { get; set; }

        public List<Address> Addresss { get; set; }

        public User Admin { get; set; }

        private int GetRandomNumber(int min, int max)
        {
            return rand.Next(min, max + 1);
        }
    }
}
