using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using suivi_des_drones.Core.Interfaces.Repositories;
using suivi_des_drones.Core.Models;

namespace suivi_des_drones.Web.UI.Pages
{
    public class IndexModel : PageModel
    {

        #region Properties
        public List<Drone> ListOfDrones = new List<Drone>();
        public List<string> ListOfStatus = new List<string>();
        IDroneRepository repository;
        //HealthStatus healthStatus;
        #endregion


        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, IDroneRepository repository /*, HealthStatus healthStatus*/)
        {
            _logger = logger;
            this.repository = repository;
            //this.healthStatus = healthStatus;
        }

        //public void OnGet()
        //{

        //}

        public IActionResult OnGet()
        {
            SetDroneList();
            SetStatusList();
            return this.Page();
        }

        public List<Drone> SetDroneList()
        {
            ListOfDrones = repository.GetAll();
            return ListOfDrones;
        }

        public List<string> SetStatusList()
        {
            ListOfStatus.Add(HealthStatus.Ok.Label);
            ListOfStatus.Add(HealthStatus.Broken.Label);
            ListOfStatus.Add(HealthStatus.Repair.Label);
            return ListOfStatus;
        }


    }
}
