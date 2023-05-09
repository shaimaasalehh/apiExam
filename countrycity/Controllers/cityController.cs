using countrycity.model;
using countrycity.service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace countrycity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class cityController : ControllerBase
    {
        private readonly Icitysrvice cityservice;

        public cityController(Icitysrvice _cityservice)
        {
            cityservice = _cityservice;
        }



        [HttpPost]
        public void create(CityDTO cityDTO)
        {

            cityservice.create(cityDTO);
        }

    




    }
}

