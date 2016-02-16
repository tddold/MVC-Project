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

            this.categories = new List<Category>();
            this.categories.Add(new Category() { Name = "Phones" });
            this.categories.Add(new Category() { Name = "Cameras" });
            this.categories.Add(new Category() { Name = "Personal computers" });
            this.categories.Add(new Category() { Name = "Gaming consoles" });
            this.categories.Add(new Category() { Name = "TV sets" });

            var country = new Country() { Name = "Bulgaria" };

            var cities = new List<City> { new City() { Name = "Plovdiv" }, new City() { Name = "Sofia" }, new City() { Name = "Varna" } };

            this.Addresss = new List<Address>();
            this.Addresss.Add(new Address() { Country = country, City = cities[this.GetRandomNumber(0, this.Addresss.Count - 1)], Street = "Vasil Levski 2", Latitude = 42.145404, Longitude = 24.7480313 });
            this.Addresss.Add(new Address() { Country = country, City = cities[this.GetRandomNumber(0, this.Addresss.Count - 1)], Street = "Vasil Levski 2", Latitude = 42.145404, Longitude = 24.7480313 });
            this.Addresss.Add(new Address() { Country = country, City = cities[this.GetRandomNumber(0, this.Addresss.Count - 1)], Street = "Vasil Levski 2", Latitude = 42.145404, Longitude = 24.7480313 });
            this.Addresss.Add(new Address() { Country = country, City = cities[this.GetRandomNumber(0, this.Addresss.Count - 1)], Street = "Vasil Levski 2", Latitude = 42.145404, Longitude = 24.7480313 });

            this.Products = new List<Product>();

            this.Products.Add(new Product()
            {
                Name = "Galaxy S6",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Samsung",
                Price = 1050,
                Quantity = 5,
                Whidth = 10,
                Heigth = 15,
                Depht = 4,
                Weight = 0.5,
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/1.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/2.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/3.jpg" } }
            });
            this.Products.Add(new Product()
            {
                Name = "Galaxy Edge",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Samsung",
                Price = 1050,
                Quantity = 5,
                Whidth = 10,
                Heigth = 15,
                Depht = 4,
                Weight = 0.5,
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/1.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/2.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/3.jpg" } }
            });
            this.Products.Add(new Product()
            {
                Name = "XPERIA Z5",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Sony",
                Price = 1020,
                Quantity = 5,
                Whidth = 10,
                Heigth = 15,
                Depht = 4,
                Weight = 0.5,
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/1.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/2.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/3.jpg" } }
            });
            this.Products.Add(new Product()
            {
                Name = "iPhone 6S",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Apple",
                Price = 1350,
                Quantity = 5,
                Whidth = 10,
                Heigth = 15,
                Depht = 4,
                Weight = 0.5,
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/1.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/2.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/3.jpg" } }
            });
            this.Products.Add(new Product()
            {
                Name = "Lumia 750",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Nokia",
                Price = 1050,
                Quantity = 5,
                Whidth = 10,
                Heigth = 15,
                Depht = 4,
                Weight = 0.5,
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/1.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/2.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/3.jpg" } }
            });
            this.Products.Add(new Product()
            {
                Name = "D5200",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Nikon",
                Price = 1050,
                Quantity = 5,
                Whidth = 40,
                Heigth = 25,
                Depht = 15,
                Weight = 2,
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/1.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/2.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/3.jpg" } }
            });
            this.Products.Add(new Product()
            {
                Name = "D7200",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Nikon",
                Price = 1550,
                Quantity = 5,
                Whidth = 40,
                Heigth = 25,
                Depht = 15,
                Weight = 2,
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/1.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/2.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/3.jpg" } }
            });
            this.Products.Add(new Product()
            {
                Name = "D800",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Nikon",
                Price = 1550,
                Quantity = 5,
                Whidth = 40,
                Heigth = 25,
                Depht = 15,
                Weight = 2,
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/1.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/2.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/3.jpg" } }
            });
            this.Products.Add(new Product()
            {
                Name = "EOS-7D",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Canon",
                Price = 1550,
                Quantity = 5,
                Whidth = 40,
                Heigth = 25,
                Depht = 15,
                Weight = 2,
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/1.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/2.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/3.jpg" } }
            });
            this.Products.Add(new Product()
            {
                Name = "EOS-5D Mark II",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Canon",
                Price = 1550,
                Quantity = 5,
                Whidth = 40,
                Heigth = 25,
                Depht = 15,
                Weight = 2,
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/1.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/2.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/3.jpg" } }
            });
            this.Products.Add(new Product()
            {
                Name = "EOS-750D",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Canon",
                Price = 1550,
                Quantity = 5,
                Whidth = 40,
                Heigth = 25,
                Depht = 15,
                Weight = 2,
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/1.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/2.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/3.jpg" } }
            });
            this.Products.Add(new Product()
            {
                Name = "SAL-A58",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Sony",
                Price = 1550,
                Quantity = 5,
                Whidth = 40,
                Heigth = 25,
                Depht = 15,
                Weight = 2,
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/1.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/2.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/3.jpg" } }
            });
            this.Products.Add(new Product()
            {
                Name = "ILCA-77M2",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Sony",
                Price = 1550,
                Quantity = 5,
                Whidth = 40,
                Heigth = 25,
                Depht = 15,
                Weight = 2,
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/1.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/2.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/3.jpg" } }
            });
            this.Products.Add(new Product()
            {
                Name = "KDL-48W705",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Sony",
                Price = 1250,
                Quantity = 5,
                Whidth = 140,
                Heigth = 80,
                Depht = 35,
                Weight = 20,
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/1.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/2.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/3.jpg" } }
            });
            this.Products.Add(new Product()
            {
                Name = "KDL-43W809",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Sony",
                Price = 1250,
                Quantity = 5,
                Whidth = 140,
                Heigth = 80,
                Depht = 35,
                Weight = 20,
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/1.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/2.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/3.jpg" } }
            });
            this.Products.Add(new Product()
            {
                Name = "KD-49X8309C",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Sony",
                Price = 1250,
                Quantity = 5,
                Whidth = 140,
                Heigth = 80,
                Depht = 35,
                Weight = 20,
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/1.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/2.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/3.jpg" } }
            });
            this.Products.Add(new Product()
            {
                Name = "KD-43X8307C",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Sony",
                Price = 1250,
                Quantity = 5,
                Whidth = 140,
                Heigth = 80,
                Depht = 35,
                Weight = 20,
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/1.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/2.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/3.jpg" } }
            });
            this.Products.Add(new Product()
            {
                Name = "KD-55S8005C",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Sony",
                Price = 1250,
                Quantity = 5,
                Whidth = 140,
                Heigth = 80,
                Depht = 35,
                Weight = 20,
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/1.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/2.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/3.jpg" } }
            });
            this.Products.Add(new Product()
            {
                Name = "KDL-50W809C",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Sony",
                Price = 1250,
                Quantity = 5,
                Whidth = 140,
                Heigth = 80,
                Depht = 35,
                Weight = 20,
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/1.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/2.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/3.jpg" } }
            });
            this.Products.Add(new Product()
            {
                Name = "KD-49X8005C",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Sony",
                Price = 1250,
                Quantity = 5,
                Whidth = 140,
                Heigth = 80,
                Depht = 35,
                Weight = 20,
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/1.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/2.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/3.jpg" } }
            });
            this.Products.Add(new Product()
            {
                Name = "Playstation 4",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Sony",
                Price = 800,
                Quantity = 5,
                Whidth = 50,
                Heigth = 40,
                Depht = 15,
                Weight = 5,
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/1.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/2.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/3.jpg" } }
            });
            this.Products.Add(new Product()
            {
                Name = "Playstation Vita",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ShortDecription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s .",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Manufacturer = "Sony",
                Price = 800,
                Quantity = 5,
                Whidth = 15,
                Heigth = 10,
                Depht = 5,
                Weight = 0.5,
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/1.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/2.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/3.jpg" } }
            });
        }

        public List<Product> Products { get; set; }

        public List<Address> Addresss { get; set; }

        public User Admin { get; set; }

        private int GetRandomNumber(int min, int max)
        {
            return rand.Next(min, max + 1);
        }
    }
}
