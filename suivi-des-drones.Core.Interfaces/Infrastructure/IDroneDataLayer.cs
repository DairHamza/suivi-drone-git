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
        /// <summary>
        /// Retourne la list complète des drones
        /// </summary>
        /// <returns></returns>
        public List<Drone> GetList ();
    }
}
