using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_des_drones.Core.Models
{
    /// <summary>
    /// Les status possibles d'une drone
    /// </summary>
    public record HealthStatus
    {
        #region DroneStatus
        public static HealthStatus Ok = new HealthStatus { Id = 0, Label = "Ok" };
        public static HealthStatus Broken = new HealthStatus { Id = -1, Label = "Cassé" };
        public static HealthStatus Repair = new HealthStatus { Id = -2, Label = "En réparation" };
        #endregion

        #region Properties
        public decimal Id { get; init; }
        public string Label { get; init; } = default!;
        #endregion
    }

    //public class HealthStatus
    //{
    //    #region DroneStatus
    //    public static HealthStatus Ok = new HealthStatus { Id = 0, Label = "Ok" };
    //    public static HealthStatus Broken = new HealthStatus { Id = -1, Label = "Cassé" };
    //    public static HealthStatus Repair = new HealthStatus { Id = -2, Label = "En réparation" };
    //    #endregion

    //    #region Properties
    //    public int Id { get; set; } = 0;
    //    public string Label { get; set; } = default!;
    //    #endregion
    //}

    //public enum HealthStatus
    //{
    //    Ok = 0,
    //    Broken = -1,
    //    Repair = -2
    //}
}
