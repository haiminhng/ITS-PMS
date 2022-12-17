using Interface;
using Models.Models;
using Models.Models.utilities;
using Newtonsoft.Json;
using System.Net;

namespace Framework
{
    public class GoogleService : IGoogleService
    {

        private HttpClient _client = new HttpClient();

        private WebClient _webClient = new WebClient();
        private string _baseUrl = "https://maps.googleapis.com/maps/api/distancematrix/json";

        private string _origins = "it.schule " +
                                 "Breitwiesenstraße 20-22, " +
                                 "70565 Stuttgart";

        private string _mode = "driving";
        private string _units = "metric";
        private string _region = "de";
        private string _languague = "de";
        private string _apiKey = "AIzaSyBkAR1XJQ0myJZ-mG2tiOKZfZ8J46kJiSg";

        public async Task<string> GetDistance(Adressen adresse)
        {
            string URL = _baseUrl
                         + "?destinations=" + adresse.Strasse + " " + adresse.Hausnr + ", " + adresse.Plz + " " +
                         adresse.Ort + ", " + adresse.Land
                         + "&origins=" + _origins
                         + "&units=" + _units
                         + "&mode=" + _mode
                         + "&region=" + _region
                         + "&key=" + _apiKey
                         + "&language=" + _languague;

            HttpResponseMessage response = await _client.GetAsync(URL);
            String responseContent = await response.Content.ReadAsStringAsync();
            DistanceResponse dr = JsonConvert.DeserializeObject<DistanceResponse>(responseContent);
            string result = dr.rows[0].elements[0].distance.text;
            return result;

        }

        public async Task<string> GetDriveTime(Adressen adresse)
        {
            string URL = _baseUrl
                         + "?destinations=" + adresse.Strasse + " " + adresse.Hausnr + ", " + adresse.Plz + " " +
                         adresse.Ort + ", " + adresse.Land
                         + "&origins=" + _origins
                         + "&units=" + _units
                         + "&mode=" + _mode
                         + "&region=" + _region
                         + "&key=" + _apiKey
                         + "&language=" + _languague;

            HttpResponseMessage response = await _client.GetAsync(URL);
            String responseContent = await response.Content.ReadAsStringAsync();
            DistanceResponse dr = JsonConvert.DeserializeObject<DistanceResponse>(responseContent);
            string result = dr.rows[0].elements[0].duration.text;
            return result;
        }
    }
}