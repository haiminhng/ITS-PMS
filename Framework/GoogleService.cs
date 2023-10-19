using Interface;
using Models.Models;
using Models.Models.utilities;
using Newtonsoft.Json;
using System.Net;

namespace Framework
{
    public class GoogleService : IGoogleService
    {

        private WebClient _webClient = new WebClient();

        private string _baseUrl = "https://maps.googleapis.com/maps/api/distancematrix/json";

        private string _origins = "it.schule " +
                                 "Breitwiesenstraße 20-22, " +
                                 "70565 Stuttgart";

        private string _modeDriving = "driving";
        private string _modeTransist = "transit";

        private string _units = "metric";
        private string _region = "de";
        private string _languague = "de";
        private string _apiKey = "GOOGLE DISTANCE MATRIX API";

        public async Task<double> GetDistance(Adressen adresse)
        {
            string URL = _baseUrl
                         + "?destinations=" + adresse.Strasse + " " + adresse.Hausnr + ", " + adresse.Plz + " " +
                         adresse.Ort + ", " + adresse.Land
                         + "&origins=" + _origins
                         + "&units=" + _units
                         + "&mode=" + _modeDriving
                         + "&region=" + _region
                         + "&key=" + _apiKey
                         + "&language=" + _languague;

            string responseContent = await _webClient.DownloadStringTaskAsync(URL);
            DistanceResponse dr = JsonConvert.DeserializeObject<DistanceResponse>(responseContent);
            if (dr == null || dr.rows == null || dr.rows.Length == 0 || dr.rows[0].elements == null || dr.rows[0].elements.Length == 0 || dr.rows[0].elements[0].distance == null)
            {
                return 0;
            }

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
                         + "&mode=" + _modeDriving
                         + "&region=" + _region
                         + "&key=" + _apiKey
                         + "&language=" + _languague;

            string responseContent = await _webClient.DownloadStringTaskAsync(URL);
            DistanceResponse dr = JsonConvert.DeserializeObject<DistanceResponse>(responseContent);
            if (dr == null || dr.rows == null || dr.rows.Length == 0 || dr.rows[0].elements == null || dr.rows[0].elements.Length == 0 || dr.rows[0].elements[0].duration == null)
            {
                return TimeSpan.FromSeconds(0);
            }

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

        public async Task<TimeSpan> GetTravelTime(Adressen adresse)
        {
                string URL = _baseUrl
                                    + "?destinations=" + adresse.Strasse + " " + adresse.Hausnr + ", " + adresse.Plz + " " +
                                    adresse.Ort + ", " + adresse.Land
                                    + "&origins=" + _origins
                                    + "&units=" + _units
                                    + "&mode=" + _modeTransist
                                    + "&region=" + _region
                                    + "&key=" + _apiKey
                                    + "&language=" + _languague;

            string responseContent = await _webClient.DownloadStringTaskAsync(URL);
            DistanceResponse dr = JsonConvert.DeserializeObject<DistanceResponse>(responseContent);
            if (dr == null || dr.rows == null || dr.rows.Length == 0 || dr.rows[0].elements == null || dr.rows[0].elements.Length == 0 || dr.rows[0].elements[0].duration == null)
            {
                return TimeSpan.FromSeconds(0);
            }

            return TimeSpan.FromSeconds(dr.rows[0].elements[0].duration.value);
        }
    }
}
