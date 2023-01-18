using Interface;
using Models.Data;
using Models.Models;

namespace Framework
{
    public class WeightedScoring : IAntragService
    {
        private readonly ParkplatzverwaltungContext _context = new ParkplatzverwaltungContext();
        public int AntragBewerten(Parkplatzantrag application)
        {

            // Define the weights for each factor
            int distanceWeight = 2;
            int besonderefallWeight = 1;
            int rideshareWeight = 3; 
            int travelTimeWeight = 1;
            int drivingTimeWeight = 2;
            /*
             
             */
            // Define the range of values for each factor
            //int distanceMin = 0;
            int distanceMin = 0;
            int distanceMax = 10;
            int travelTimeMin = 0;
            int travelTimeMax = 60;
            int drivingTimeMin = 0;
            int drivingTimeMax = 60;    

            // Calculate the score for each factor
            int distanceScore = PunkteRechnen((double)application.EntfernungKm, distanceMin, distanceMax);
            int besonderefallScore = application.Besonderefall.GetValueOrDefault() ? 1 : 0;
            int rideshareScore = application.Mitfahrgelegenheit.GetValueOrDefault() ? 1 : 0;
            int travelTimeScore = PunkteRechnen(application.Reisezeit.GetValueOrDefault().TotalMinutes, travelTimeMin, travelTimeMax);
            int drivingTimeScore = PunkteRechnen(application.Fahrzeit.GetValueOrDefault().TotalMinutes, drivingTimeMin, drivingTimeMax);

            // Calculate the overall score
            int overallScore = (distanceScore * distanceWeight) + (besonderefallScore * besonderefallWeight) + (rideshareScore * rideshareWeight) + (travelTimeScore * travelTimeWeight) + (drivingTimeScore * drivingTimeWeight);

            return overallScore;
        }

        private int PunkteRechnen(double value, int min, int max)
        {
            /*
            if (value < min)
            {
                return 0;
            }
            if (value > max)
            {
                return max - min;
            }
            return (int)(value - min);
            */
            // Calculate the range of values
            double range = max - min;

            // Calculate the score using a linear function
            double score = (value - min) / range;

            // Map the score to the range 0-10
            int scoreInt = (int)Math.Round(score * 10);

            // Ensure the score is within the range 0-10
            return Math.Min(Math.Max(scoreInt, 0), 10);
        }
    }

}
