using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using suivi_des_drones.Core.Application.Repositories;
using suivi_des_drones.Core.Interfaces.Repositories;
using suivi_des_drones.Core.Models;

namespace suivi_des_drones.Web.UI.Pages
{
    public class CreateDroneModel : PageModel
    {
        #region Fields
        private readonly IDroneRepository droneRepository;
        #endregion

        #region Constructors
        public CreateDroneModel(IDroneRepository droneRepository)
        {
            this.droneRepository = droneRepository;
        }
        #endregion
        public void OnPost()
        {
            this.droneRepository.SaveDrone(MyDrone);        
        }

        [BindProperty]
        public Drone MyDrone { get; set; }    
    }
}   
