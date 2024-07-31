

namespace SampleDemo
{
    public class Model
    {
        public string CountryName { get; set; }
        public double TotalArea { get; set; }
        public string CountryFlags { get; set; }

        public Model(string countryName, double totalArea, string flags)
        {
            CountryName = countryName;
            TotalArea = totalArea;
            CountryFlags = flags;
        }
    }
}
