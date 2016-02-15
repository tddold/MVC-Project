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
            this.categories.Add(new Category() { Name = "Music" });
            this.categories.Add(new Category() { Name = "Theatre" });
            this.categories.Add(new Category() { Name = "Cinema" });
            this.categories.Add(new Category() { Name = "Sport" });
            this.categories.Add(new Category() { Name = "Leasure" });
            this.categories.Add(new Category() { Name = "Science" });
            this.categories.Add(new Category() { Name = "Weather" });

            var country = new Country() { Name = "Bulgaria" };

            var cities = new List<City> { new City() { Name = "Plovdiv" }, new City() { Name = "Sofia" }, new City() { Name = "Varna" } };

            this.Addresss = new List<Address>();
            this.Addresss.Add(new Address() { Country = country, City = cities[this.GetRandomNumber(0, this.Addresss.Count - 1)], Street = "Otec Paisii 2", Latitude = 42.145404, Longitude = 24.7480313 });
            this.Addresss.Add(new Address() { Country = country, City = cities[this.GetRandomNumber(0, this.Addresss.Count - 1)], Street = "Otec Paisii 2", Latitude = 42.145404, Longitude = 24.7480313 });
            this.Addresss.Add(new Address() { Country = country, City = cities[this.GetRandomNumber(0, this.Addresss.Count - 1)], Street = "Otec Paisii 2", Latitude = 42.145404, Longitude = 24.7480313 });
            this.Addresss.Add(new Address() { Country = country, City = cities[this.GetRandomNumber(0, this.Addresss.Count - 1)], Street = "Otec Paisii 2", Latitude = 42.145404, Longitude = 24.7480313 });

            this.Products = new List<Product>();

            this.Products.Add(new Product()
            {
                Name = "What is Lorem Ipsum?",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/bg1.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/bg3.jpg" } }
            });
            this.Products.Add(new Product()
            {
                Name = "What is Lorem Ipsum?",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/bg2.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/bg3.jpg" } }
            });
            this.Products.Add(new Product()
            {
                Name = "What im Ipsuem Ipsum?",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/bg3.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/bg2.jpg" } }
            });
            this.Products.Add(new Product()
            {
                Name = "What ism Ipsum?",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/bg1.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/bg3.jpg" } }
            });
            this.Products.Add(new Product()
            {
                Name = "What isssing hiddenm?",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/bg1.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/bg3.jpg" } }
            });
            this.Products.Add(new Product()
            {
                Name = "What at is Lor Ipsum?",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/bg1.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/bg3.jpg" } }
            });
            this.Products.Add(new Product()
            {
                Name = "Whem Ipsum?",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/bg1.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/bg3.jpg" } }
            });
            this.Products.Add(new Product()
            {
                Name = "em Ipsum has beenrem Ipsum?",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/bg1.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/bg3.jpg" } }
            });
            this.Products.Add(new Product()
            {
                Name = "em Ipsum has been?",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&amp;amp;amp;#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Category = this.categories[this.GetRandomNumber(0, this.categories.Count - 1)],
                CreatedOn = DateTime.Now.AddDays(rand.Next(-5, 5)),
                Images = new List<Image>() { new Image() { ImagePath = "/Content/Images/SeedImages/bg1.jpg" }, new Image() { ImagePath = "/Content/Images/SeedImages/bg3.jpg" } }
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
