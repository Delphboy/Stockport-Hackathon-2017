using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using APIXULib;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Stockport_Hackathon
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string key = "1ffd6b91d1f14dbe93394522170403";
            IRepository repo = new Repository();
            var GetCityForecastWeatherResult = repo.GetWeatherData(key, GetBy.CityName, "paris", Days.Three);
            var GetByLatLongForecastWeatherResult = repo.GetWeatherDataByLatLong(key, "30.2669444", "-97.7427778", Days.Three);
            var GetByIPForecastWeatherResult = repo.GetWeatherDataByAutoIP(key, Days.Three);


            var GetCityCurrentWeatherResult = repo.GetWeatherData(key, GetBy.CityName, "paris");
            var GetByLatLongCurrentWeatherResult = repo.GetWeatherDataByLatLong(key, "30.2669444", "-97.7427778");
            var GetByIPCurrentWeatherResult = repo.GetWeatherDataByAutoIP(key);

        }
    }
}
