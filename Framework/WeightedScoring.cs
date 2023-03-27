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
        public int AntragBewerten(Parkplatzantrag application)
        {
            using var context = new ParkplatzverwaltungContext();
            context
                .Parkplatzantrags
                .Include(e => e.Schueler)
                .Include(e => e.Schueler.Adressen)
                .Load();

            // Definiere die Gewichte für jeden Faktor
            double distanceWeight = 0.2;
            double besonderefallWeight = 0.1;
            double rideshareWeight = 0.3;
            double travelTimeWeight = 0.1;
            double drivingTimeWeight = 0.2;

            // Definiere den Wertebereich für jeden Faktor
            double distanceMin = 0;
            double distanceMax = 100;
            double travelTimeMin = 0;
            double travelTimeMax = 60;
            double drivingTimeMin = 0;
            double drivingTimeMax = 60;


            // Normalisiere die Werte für jeden Faktor mit Min-Max-Normalisierung
            double distanceNormalized = NormalizeValue(application.EntfernungKm.GetValueOrDefault(), distanceMin, distanceMax);
            double besonderefallNormalized = application.Besonderefall.GetValueOrDefault() ? 1 : 0;
            double rideshareNormalized = application.Mitfahrgelegenheit.GetValueOrDefault() ? 1 : 0;
            double travelTimeNormalized = NormalizeValue(application.Reisezeit.GetValueOrDefault().TotalMinutes, travelTimeMin, travelTimeMax);
            double drivingTimeNormalized = NormalizeValue(application.Fahrzeit.GetValueOrDefault().TotalMinutes, drivingTimeMin, drivingTimeMax);

            // Berechne die Punktzahl für jeden Faktor
            double distanceScore = distanceNormalized * distanceWeight;
            double besonderefallScore = besonderefallNormalized * besonderefallWeight;
            double rideshareScore = rideshareNormalized * rideshareWeight;
            double travelTimeScore = travelTimeNormalized * travelTimeWeight;
            double drivingTimeScore = drivingTimeNormalized * drivingTimeWeight;

            // Berechne die Gesamtpunktzahl
            double overallScore = distanceScore + besonderefallScore + rideshareScore + travelTimeScore + drivingTimeScore;

            // Konvertiere die Gesamtpunktzahl in eine Ganzzahl
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
