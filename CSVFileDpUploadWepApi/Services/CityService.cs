using CSVFileDpUploadWepApi.Model;
using CsvHelper;
using System.Globalization;

namespace CSVFileDpUploadWepApi.Services
{
    public class CityService
    {
        private AppDbContext _context;

        public CityService(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Cities> GetAllCities(Stream file)
        {
            var reader = new StreamReader(file);
            var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            var records = csv.GetRecords<Cities>();

            foreach (var record in records)
            {

                var _citysRecord = new Cities();

                _citysRecord.id = record.id;
                _citysRecord.city = record.city;
                _citysRecord.city_ascii = record.city_ascii;
                _citysRecord.lat = record.lat;
                _citysRecord.lng = record.lng;
                _citysRecord.country = record.country;
                _citysRecord.iso2 = record.iso2;
                _citysRecord.iso3 = record.iso3;
                _citysRecord.admin_name = record.admin_name;
                _citysRecord.capital = record.capital;
                _citysRecord.population = record.population;



                _context.cities.Add(_citysRecord);
                _context.SaveChanges();
            }
            return records;
        }
    }
}
