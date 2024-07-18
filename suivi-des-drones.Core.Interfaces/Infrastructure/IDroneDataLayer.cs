using suivi_des_drones.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_des_drones.Core.Interfaces.Infrastructure
{
    /// <summary>
    /// Isole l'accès à la base de données
    /// </summary>
    public interface IDroneDataLayer
    {
        #region Public methods
        /// <summary>
        /// Retourne la liste complète des drones
        /// </summary>
        /// <returns></returns>
        List<Drone> GetList ();
        /// <summary>
        /// Retourne la liste des status
        /// </summary>
        /// <returns></returns>
        List<HealthStatus> GetStatuses();
        /// <summary>
        /// Ajouter un drone dans la base de données
        /// </summary>
        /// <param name="drone"></param>
        void AddDrone(Drone drone);
        #endregion
    }
}
