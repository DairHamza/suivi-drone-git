using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using suivi_des_drones.Core.Models;

namespace suivi_des_drones.Web.UI.Pages
{
    public class CreateDroneModel : PageModel
    {
        public void OnPost(Drone drone)
        {
            //premiere methode
            //string recuprerInfos = this.Request.Form["matricule"];

            //deuxieme approche recuperation des donnée formulaire via params de la methode

            //troisieme approche via un objet Drone
        }
    }
}
