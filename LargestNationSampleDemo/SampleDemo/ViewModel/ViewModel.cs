using System.Collections.ObjectModel;
using System.Reflection;

namespace SampleDemo
{
    public class ViewModel
    {
        public List<Model> AreaDetails { get; set; }

        public ViewModel()
        {
            AreaDetails = new List<Model>();
            ReadCSVFile();
        }

        private void ReadCSVFile()
        {
            Assembly executingAssembly = typeof(App).GetTypeInfo().Assembly;
            Stream inputStream = executingAssembly.GetManifestResourceStream("SampleDemo.Resources.WorldLandDetails.csv");
            string line;
            ObservableCollection<string> lines = new ObservableCollection<string>();
            if (inputStream != null)
            {
                using StreamReader reader = new StreamReader(inputStream);
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
                lines.RemoveAt(0);
                foreach (var items in lines)
                {
                    string[] data = items.Split(',');
                    string countryName = data[0];
                    double totalArea = Convert.ToDouble(data[1]);
                    AreaDetails.Add(new Model(countryName, totalArea));
                }

            }

        }
    }
}
