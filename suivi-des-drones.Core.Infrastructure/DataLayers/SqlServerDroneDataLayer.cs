using suivi_des_drones.Core.Infrastructure.DataBases;
using suivi_des_drones.Core.Interfaces.Infrastructure;
using suivi_des_drones.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_des_drones.Core.Infrastructure.DataLayers
{
    public class SqlServerDroneDataLayer : IDroneDataLayer
    {
        #region Fields
        private readonly DronesDbContext? context = null;
        #endregion

        #region Constructors
        public SqlServerDroneDataLayer(DronesDbContext context)
        {
            this.context = context;
        }
        #endregion

        #region Public Methods
        public List<Drone> GetList()
        {
            var query = from item in this.context?.Drones
                            //where item.CreationDate == DateTime.Now
                        select item;

            return query.ToList();
            //return new List<Drone> {
            //    new Drone { Matricule = "ABC123", CreationDate = DateTime.Now.AddDays(-100), HealthStatus = HealthStatus.Ok },
            //    new Drone { Matricule = "EFG456", CreationDate = DateTime.Now.AddDays(-60), HealthStatus = HealthStatus.Repair },
            //    new Drone { Matricule = "HIJ789", CreationDate = DateTime.Now.AddDays(-30), HealthStatus = HealthStatus.Broken },
            //    new Drone { Matricule = "KLM101", CreationDate = DateTime.Now.AddDays(-20), HealthStatus = HealthStatus.Broken},
            //    new Drone { Matricule = "NOP112", CreationDate = DateTime.Now.AddDays(-40), HealthStatus = HealthStatus.Ok },
            //    new Drone { Matricule = "QRS131", CreationDate = DateTime.Now.AddDays(-70), HealthStatus = HealthStatus.Repair }
            //    };
        }

        public List<HealthStatus> GetStatuses()
        {
            var query = from item in this.context?.HealthStatuses
                            //where item.CreationDate == DateTime.Now
                        select item;

            return query.ToList();
        }

        public void AddDrone(Drone drone)
        {
            this.context?.Drones.Add(drone);


            var entry = this.context?.Entry(drone.HealthStatus);
            entry.State = Microsoft.EntityFrameworkCore.EntityState.Unchanged;

            this.context?.SaveChanges();
        }
        #endregion
    }
}
