

namespace SampleDemo
{
    public class Model
    {
        public string CountryName { get; set; }
        public double TotalArea { get; set; }
       
        public Model(string countryName, double totalArea)
        {
            CountryName = countryName;
            TotalArea = totalArea;
        }
    }
}
