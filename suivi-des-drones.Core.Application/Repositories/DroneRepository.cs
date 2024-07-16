using suivi_des_drones.Core.Interfaces.Infrastructure;
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
        #region Fields
        private readonly IDroneDataLayer droneDataLayer;
        #endregion

        #region Constructors
        public DroneRepository(IDroneDataLayer droneDataLayer)
        {
           this.droneDataLayer = droneDataLayer;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Retourne la liste complète des drones
        /// </summary>
        /// <returns></returns>
        public List<Drone> GetAll()
        {
            List<Drone> MyListFromDataLayer = this.droneDataLayer.GetList();
            return MyListFromDataLayer;
        }

        public List<HealthStatus> GetAllStatus()
        {
            List<HealthStatus> MyStatusListFromDataLayer = this.droneDataLayer.GetStatuses();
            return MyStatusListFromDataLayer;
        }
        #endregion
    }
}
