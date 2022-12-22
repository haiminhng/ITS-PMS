using Interface;
using Models.Models;
using Models.Models.utilities;
using Newtonsoft.Json;
using System;
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

        public async Task<double> GetDistance(Adressen adresse)
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

            string responseContent = await _webClient.DownloadStringTaskAsync(URL);
            DistanceResponse dr = JsonConvert.DeserializeObject<DistanceResponse>(responseContent);
            return dr.rows[0].elements[0].distance.value;
            /*
            HttpResponseMessage response = await _client.GetAsync(URL);
            if (response.IsSuccessStatusCode) {
                String responseContent = await response.Content.ReadAsStringAsync();
                DistanceResponse dr = JsonConvert.DeserializeObject<DistanceResponse>(responseContent);
                //string result = dr.rows[0].elements[0].distance.text;
                return dr.rows[0].elements[0].distance.value;
            
        }
            else
            {
                throw new Exception("Fehler beim Aufrufen der Google Maps-API");
            }
            */

        }

        public async Task<TimeSpan> GetDriveTime(Adressen adresse)
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

            string responseContent = await _webClient.DownloadStringTaskAsync(URL);
            DistanceResponse dr = JsonConvert.DeserializeObject<DistanceResponse>(responseContent);
            return TimeSpan.FromSeconds(dr.rows[0].elements[0].duration.value);

            /*
            HttpResponseMessage response = await _client.GetAsync(URL);
            if (response.IsSuccessStatusCode)
            {
                String responseContent = await response.Content.ReadAsStringAsync();
            DistanceResponse dr = JsonConvert.DeserializeObject<DistanceResponse>(responseContent);
            //string result = dr.rows[0].elements[0].duration.text;
            return TimeSpan.FromSeconds(dr.rows[0].elements[0].duration.value);
           
            }
            else
            {
                throw new Exception("Fehler beim Aufrufen der Google Maps-API");
            }
             */
        }
    }
}