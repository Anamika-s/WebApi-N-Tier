 

using Data_Access_Layer.Repository;
using Data_Access_Layer.Repository.Entities;

namespace Data_Access_Layer
{
    public class CityDal
    {
        private StudentDbContext _context;
        public CityDal() { 
        _context = new StudentDbContext();
        }

        public List<City> GetCities()
        {
            return _context.Cities.ToList();
        }

        public City GetCityById(int id)
        {
            return _context.Cities.FirstOrDefault(x => x.Id == id);
        }
        public City AddCity(City city)
        {
            _context.Cities.Add(city);
            _context.SaveChanges();
            return city;
        }


    }
}