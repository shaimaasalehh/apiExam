using countrycity.data;
using countrycity.model;
using Microsoft.AspNetCore.Identity;
using System.Data;

namespace countrycity.service
{
    public class countryservice : Icountryservice
    {
        private readonly context context;
  

        public countryservice(context _context)
        {

            context = _context;
          

        }
        public void create(CountryDTO CountryDTO)
        {

            var newcountry = new Country()
            {
                name = CountryDTO.name,
                code = CountryDTO.code



            };
            context.Countries.Add(newcountry);
            context.SaveChanges();









        }

        public List<CountryDTO> search(string? name)
        {
        var allcountries=context.Countries;
            var country =new List<CountryDTO>();
            foreach(var item in allcountries)
            {
                var coun = new CountryDTO();
                coun.id= item.id;
                coun.name= item.name;
                coun.code= item.code;
                country.Add(coun);


            }
            return country;
        }

    }
    public async Task<List<CityDTO>> get()
    {
        List<CityDTO> allcity = new List<CityDTO>();
        List<City> li = context.City.ToList();

        List<get> user = new List<CityDTO>
        {

            li.Add(new City()
            {
                id = item.Id,
                name = item.Name,
               
            });

        }

    }


