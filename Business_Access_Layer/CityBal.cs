using Data_Access_Layer;
 
using Data_Access_Layer.Repository.Entities;

namespace Business_Access_Layer
{
    public class CityBal
    {
        private CityDal _dal;
        public CityBal() { 
        _dal = new CityDal();
        }

        public List<City> GetCitys()
        {
            return _dal.GetCities();
        }

        public City GetCityById(int id)
        {
            // filter
            // search
            // modify the request in BAL
            return _dal.GetCityById(id);
        }
        public City AddCity(City City)
        {
            return _dal.AddCity(City);
        }

    }
}