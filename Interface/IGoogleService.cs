using Models.Models;

namespace Interface
{
    public interface IGoogleService
    {
        Task<double> GetDistance(Adressen adresse);
        Task<TimeSpan> GetDriveTime(Adressen adresse);
    }
}
