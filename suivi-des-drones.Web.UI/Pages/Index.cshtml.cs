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
        public List<HealthStatus> ListOfStatus = new List<HealthStatus>();
        IDroneRepository repository;
        //HealthStatus healthStatus;
        #endregion


        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, IDroneRepository repository)
        {
            _logger = logger;
            this.repository = repository;
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

        public List<HealthStatus> SetStatusList()
        {
            ListOfStatus.Add(HealthStatus.Ok);
            ListOfStatus.Add(HealthStatus.Broken);
            ListOfStatus.Add(HealthStatus.Repair);
            return ListOfStatus;
        }


    }
}
