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
        #region Public Methods
        public List<Drone> GetList()
        {
            using var context = new DronesDbContext();

            var query = from item in context.Drones
                        //where item.CreationDate == DateTime.Now
                        select item;

            return query.ToList();
        }
        #endregion
    }
}
