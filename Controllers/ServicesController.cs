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

        [HttpPost]
        public IActionResult PostNewService(Services newService)
        {
            if (newService == null)
            {
                return NotFound();
            }
            //else if (!ValidNewService(newService))
            //{
            //    return BadRequest();
            //}
            else
            {
                _servicesrepo.Post(newService);
                return Ok(newService);
            }            
        }

        //private bool ValidNewService(Services newService)
        //{
        //    if (_servicesrepo.GetById(newService) != null)
        //    {
        //        return false;
        //    }
        //    return true;
        //}
    }
}
