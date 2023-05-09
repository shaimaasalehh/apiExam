using countrycity.data;
using countrycity.model;

namespace countrycity.service
{
    public class cityservice
    {
        private readonly context context;

        public cityservice(context _context)
        {
            context = _context;
        }


        public void create(CityDTO cityDTO)
        {

            var newcity = new City()
            {
                name = cityDTO.name,
                country_id = cityDTO.country_id,




            };
            context.Cities.Add(newcity);
            context.SaveChanges();

        }
    }
}
