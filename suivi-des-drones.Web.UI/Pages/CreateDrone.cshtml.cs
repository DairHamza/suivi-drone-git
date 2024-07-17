using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace suivi_des_drones.Web.UI.Pages
{
    public class CreateDroneModel : PageModel
    {
        public void OnPost()
        {
            //premiere methode
            string recuprerInfos = this.Request.Form["matricule"];
        }
    }
}
