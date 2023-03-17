using Interface;
using Microsoft.EntityFrameworkCore;
using Models.Data;
using Models.Models;
using System;
using System.Linq;

namespace Framework
{
    public class WeightedScoring : IAntragService
    {
        private readonly ParkplatzverwaltungContext _context = new ParkplatzverwaltungContext();

        public int AntragBewerten(Parkplatzantrag application)
        {
            _context
             .Parkplatzantrags
             .Include(e => e.Schueler)
             .Include(e => e.Schueler.Adressen)
             .Load();

            // Define the weights for each factor
            double distanceWeight = 0.2;
            double besonderefallWeight = 0.1;
            double rideshareWeight = 0.3;
            double travelTimeWeight = 0.1;
            double drivingTimeWeight = 0.2;

            // Define the range of values for each factor
            double distanceMin = _context.Parkplatzantrags.Min(a => a.EntfernungKm.GetValueOrDefault());
            double distanceMax = _context.Parkplatzantrags.Max(a => a.EntfernungKm.GetValueOrDefault());
            double travelTimeMin = _context.Parkplatzantrags.Min(a => a.Reisezeit.GetValueOrDefault().TotalMinutes);
            double travelTimeMax = _context.Parkplatzantrags.Max(a => a.Reisezeit.GetValueOrDefault().TotalMinutes);
            double drivingTimeMin = _context.Parkplatzantrags.Min(a => a.Fahrzeit.GetValueOrDefault().TotalMinutes);
            double drivingTimeMax = _context.Parkplatzantrags.Max(a => a.Fahrzeit.GetValueOrDefault().TotalMinutes);

            // Normalize the values for each factor using Min-Max normalization
            double distanceNormalized = NormalizeValue(application.EntfernungKm.GetValueOrDefault(), distanceMin, distanceMax);
            double besonderefallNormalized = application.Besonderefall.GetValueOrDefault() ? 1 : 0;
            double rideshareNormalized = application.Mitfahrgelegenheit.GetValueOrDefault() ? 1 : 0;
            double travelTimeNormalized = NormalizeValue(application.Reisezeit.GetValueOrDefault().TotalMinutes, travelTimeMin, travelTimeMax);
            double drivingTimeNormalized = NormalizeValue(application.Fahrzeit.GetValueOrDefault().TotalMinutes, drivingTimeMin, drivingTimeMax);

            // Calculate the score for each factor
            double distanceScore = distanceNormalized * distanceWeight;
            double besonderefallScore = besonderefallNormalized * besonderefallWeight;
            double rideshareScore = rideshareNormalized * rideshareWeight;
            double travelTimeScore = travelTimeNormalized * travelTimeWeight;
            double drivingTimeScore = drivingTimeNormalized * drivingTimeWeight;

            // Calculate the overall score
            double overallScore = distanceScore + besonderefallScore + rideshareScore + travelTimeScore + drivingTimeScore;

            // Convert the overall score to an integer
            int finalScore = Convert.ToInt32(overallScore * 10);

            return finalScore;
        }

        private double NormalizeValue(double value, double min, double max)
        {
            double range = max - min;
            return (value - min) / range;
        }
    }
}
