using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpyDuh_Baratheon.DataAccess;
using SpyDuh_Baratheon.Models;


namespace SpyDuh_Baratheon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        ServicesRepository _servicesrepo = new ServicesRepository();

        [HttpGet]
        public List<Services> GetAllServices()
        {
            return _servicesrepo.GetAll();
        }
    }
}
