using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using suivi_des_drones.Core.Interfaces.Repositories;
using suivi_des_drones.Core.Models;

namespace suivi_des_drones.Web.UI.Pages
{
    public class IndexModel : PageModel
    {

        #region Properties
        public List<Drone> Lista = new List<Drone>();
        IDroneRepository repository;
        #endregion


        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, IDroneRepository repository)
        {
            _logger = logger;
            this.repository = repository;
        }

        public void OnGet()
        {
            setList();
        }

        public List<Drone> setList()
        {
            return Lista = repository.GetAll();
        }


    }
}
