﻿using suivi_des_drones.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_des_drones.Core.Interfaces.Repositories
{
    /// <summary>
    /// Contrat pour tout repository gèrant des drones
    /// </summary>
    public interface IDroneRepository
    {
        List<Drone> GetAll();
        List<HealthStatus> GetAllStatus();

        void SaveDrone(Drone drone);
    }
}
