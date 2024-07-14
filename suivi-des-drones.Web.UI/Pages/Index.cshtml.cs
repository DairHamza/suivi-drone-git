using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using suivi_des_drones.Core.Infrastructure.DataBases;
using suivi_des_drones.Core.Interfaces.Repositories;
using suivi_des_drones.Core.Models;

namespace suivi_des_drones.Web.UI.Pages
{
    public class IndexModel : PageModel
    {

        #region Properties
        public List<Drone> ListOfDrones = new List<Drone>();
        public List<HealthStatus> ListOfStatus = new List<HealthStatus>();
        #endregion

        #region Fields
        private readonly IDroneRepository repository;
        private readonly ILogger<IndexModel> _logger;
        #endregion
        
        #region Constructors
        public IndexModel(ILogger<IndexModel> logger, IDroneRepository repository)
        {
            _logger = logger;
            this.repository = repository;
        }
        #endregion

        //public void OnGet()
        //{

        //}

        #region Public methods
        public IActionResult OnGet()
        {
            SetDroneList();
            SetStatusList();
            return this.Page();
        }
        #endregion

        #region Internal Methods
        private List<Drone> SetDroneList()
        {
            ListOfDrones = this.repository.GetAll();
            return ListOfDrones;
        }

        private List<HealthStatus> SetStatusList()
        {
            ListOfStatus.Add(HealthStatus.Ok);
            ListOfStatus.Add(HealthStatus.Broken);
            ListOfStatus.Add(HealthStatus.Repair);
            return ListOfStatus;
        }
        #endregion


    }
}
