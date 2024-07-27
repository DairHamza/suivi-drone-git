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
            //Methodes de recuperation des données du formulaire
            // 1 : par This.Request.Form["name_field"]
            // 2 : passer les noms des champs en paramètres : string matricule, string dateCreation
            // 3 : passer un objet Drone en paramètres
            // 4 : utiliser le BindProperty
            this.droneRepository.SaveDrone(MyDrone);
            this.MyDrone.Matricule = "";
            this.MyDrone.CreationDate= DateTime.Now;
            this.ModelState.Clear();
        }

        [BindProperty]
        public Drone MyDrone { get; set; }    
    }
}   
