using countrycity.model;
using System.ComponentModel.DataAnnotations.Schema;

namespace countrycity.data
{
    [Table("cities")]
    public class City
    {



        public int id { get; set; }
        public string name { get; set; }

        [ForeignKey("Country")]
        public int country_id { get; set; }
        public CountryDTO? Country { get; set; }



    }
}
