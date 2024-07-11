using suivi_des_drones.Core.Interfaces.Repositories;
using suivi_des_drones.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_des_drones.Core.Application.Repositories
{
    /// <summary>
    /// Repository qui gère les drones : La lecture, la création , la modification , la suppression etc...
    /// </summary>
    public class DroneRepository : IDroneRepository
    {
        #region Public methods
        /// <summary>
        /// Retourne la liste complète des drones
        /// </summary>
        /// <returns></returns>
        public List<Drone> GetAll()
        {
            return new List<Drone> {
                new Drone { Matricule = "ABC123", CreationDate = DateTime.Now.AddDays(-100), HealthStatus = HealthStatus.Ok },
                new Drone { Matricule = "EFG456", CreationDate = DateTime.Now.AddDays(-60), HealthStatus = HealthStatus.Repair },
                new Drone { Matricule = "ABC123", CreationDate = DateTime.Now.AddDays(-30), HealthStatus = HealthStatus.Broken },
                new Drone { Matricule = "ABC123", CreationDate = DateTime.Now.AddDays(-20), HealthStatus = HealthStatus.Broken},
                new Drone { Matricule = "ABC123", CreationDate = DateTime.Now.AddDays(-40), HealthStatus = HealthStatus.Ok },
                new Drone { Matricule = "ABC123", CreationDate = DateTime.Now.AddDays(-70), HealthStatus = HealthStatus.Repair }
                };
        }
        #endregion
    }
}
