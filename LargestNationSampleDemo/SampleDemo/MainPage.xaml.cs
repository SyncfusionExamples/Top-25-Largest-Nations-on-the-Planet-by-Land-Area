using System.Globalization;

using Syncfusion.Maui.Charts;

namespace SampleDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
    }

    public class CountryFlagsConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is string countryName)
            {
                switch (countryName)
                {
                    case "Russia":
                        return "russia.png";
                    case "Canada":
                        return "canada.png";
                    case "China":
                        return "china.png";
                    case "United States":
                        return "usa.png";
                    case "Brazil":
                        return "brazil.png";
                    case "Australia":
                        return "australia.png";
                    case "India":
                        return "india.png";
                    case "Argentina":
                        return "argentina.png";
                    case "Kazakhstan":
                        return "kazakhstan.png";
                    case "Algeria":
                        return "algeria.png";
                    case "DR Congo":
                        return "drcongo.png";
                    case "Greenland":
                        return "greenland.png";
                    case "Saudi Arabia":
                        return "saudiarabia.png";
                    case "Mexico":
                        return "mexico.png";
                    case "Indonesia":
                        return "indonesia.png";
                    case "Sudan":
                        return "sudan.png";
                    case "Libya":
                        return "libya.png";
                    case "Iran":
                        return "iran.png";
                    case "Mongolia":
                        return "mongolia.png";
                    case "Peru":
                        return "peru.png";
                    case "Chad":
                        return "chad.png";
                    case "Niger":
                        return "niger.png";
                    case "Angola":
                        return "angola.png";
                    case "Mali":
                        return "mali.png";
                    case "South Africa":
                        return "southafrica.png";

                }

            }
            return "";
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return string.Empty;
        }
    }
}