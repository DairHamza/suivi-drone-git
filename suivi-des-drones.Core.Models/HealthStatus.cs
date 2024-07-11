using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_des_drones.Core.Models
{
    public enum HealthStatus
    {
        Ok = 0,
        Broken = -1,
        Repair = -2
    }
}
