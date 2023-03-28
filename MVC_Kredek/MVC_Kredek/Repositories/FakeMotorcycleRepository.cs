using MVC_Kredek.Models;

namespace MVC_Kredek.Repositories
{
    public class FakeMotorcycleRepository : IMotorcycleRepository
    {
        private static readonly ICollection<Motorcycle> _motorcycles = new List<Motorcycle>()
        {
            new(1, "Honda CBR 1000RR", 99100.00M, 1000, "Sportowy motocykl Hondy produkowany od 2004 roku", "honda.jpg"),
            new(2, "Kawasaki Ninja 1000 SX", 77300.00M, 500, "Motocykl z serii Ninja japońskiego producenta Kawasaki sprzedawany od 2011 roku", "ninja.jpg"),
            new(3, "BMW S 1000 RR", 99100.00M, 800, "Niemiecki motocykl sportowy produkowany przez firmę BMW od 2009 roku.", "bmw.jpg"),
            new(4, "Yamaha YZF-R1", 99100.00M, 1300, "Japoński motocykl klasy superbike wyprodukowany przez Yamaha Motor Company", "yamaha.jpg")
        };

        public IEnumerable<Motorcycle> GetAll()
        {
            return _motorcycles.ToList();
        }

        public Motorcycle GetMotorcycle(int id)
        {
            return _motorcycles.First(m => m.Id == id);
        }
    }
}
