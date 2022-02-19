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
        //ServicesRepository _servicesrepo = new ServicesRepository();

        [HttpGet]
        public List<Service> GetAllServices()
        {
            return ServicesRepository.GetAll();
        }

        [HttpGet("services/{id}")]
        public IActionResult GetServicesByID(int id)
        {
            var services = ServicesRepository.GetServiceById(id);

            if (services == null)
            {
                return BadRequest();
            }

            return Ok(services);
        }

        [HttpPost]
        public IActionResult PostNewService(Service newService)
        {
            if (newService == null)
            {
                return NotFound();
            }
            else
            {
                ServicesRepository.Post(newService);
                return Ok(newService);
            }            
        }

    }
}
