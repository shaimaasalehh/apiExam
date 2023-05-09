using countrycity.model;

namespace countrycity.service
{
    public interface Icountryservice
    {

        void create(CountryDTO countryDTO);

        List<CountryDTO> search(string? name);
    }
}
