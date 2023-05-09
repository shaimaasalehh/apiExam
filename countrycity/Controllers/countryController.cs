using countrycity.model;
using countrycity.service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace countrycity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class countryController : ControllerBase
    {
        private readonly Icountryservice countryservice;

        public countryController( Icountryservice _countryservice )
        {
            
          countryservice = _countryservice;
           
        }
        [HttpPost]
        public void create(CountryDTO countryDTO)
        {

            countryservice.create(countryDTO);
        }

        [HttpGet]
        
        public List<CountryDTO> search(string? name)
        {
            return countryservice.search(name);

        }





    }
}
