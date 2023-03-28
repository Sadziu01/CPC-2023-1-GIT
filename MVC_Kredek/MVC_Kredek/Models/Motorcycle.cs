namespace MVC_Kredek.Models
{
    public class Motorcycle
    {
        public Motorcycle(int id, string name, decimal price, int mileage, string description, string image)
        {
            Id = id;
            Name = name;
            Price = price;
            Mileage = mileage;
            Description = description;
            Image = image;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Mileage { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
