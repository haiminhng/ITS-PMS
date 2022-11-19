using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Models;

namespace Interface
{
    public interface IGoogleService
    {
        Task<string> GetDistance(Adressen adresse);
        Task<string> GetDriveTime(Adressen adresse);
    }
}
