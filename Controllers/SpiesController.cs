using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpyDuh_Baratheon.DataAccess;
using SpyDuh_Baratheon.Models;

namespace SpyDuh_Baratheon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpiesController : ControllerBase
    {
        SpiesRepository _repo = new SpiesRepository();


        // GET
        [HttpGet]
        public List<Spy> GetAllSpies()
        {
            return _repo.GetAll();
        }

        [HttpGet("name/{name}")]
        public IActionResult GetSpyByName(string name)
        {
            var match = _repo.GetByName(name);

            if (match == null)
            {
                return NotFound();
            }

            return Ok(match);
        }

        [HttpGet("id/{id}")]
        public IActionResult GetSpyByID(int id)
        {
            var match = _repo.GetById(id);

            if (match == null)
            {
                return NotFound();
            }

            return Ok(match);
        }

        // POST
        [HttpPost]
        public IActionResult PostNewSpy(Spy newSpy)
        {
            if (newSpy == null)
            {
                return NotFound();
            }
            else if (!ValidNewSpy(newSpy)){
                return BadRequest();
            }
            else
            {
                _repo.Post(newSpy);
                return Ok(newSpy);
            }

        }

        private bool ValidNewSpy(Spy newSpy)
        {
            if (string.IsNullOrWhiteSpace(newSpy.Name))
            {
                return false;
            }

            if (_repo.GetByName(newSpy.Name) != null)
            {
                return false;
            }

            if (_repo.GetById(newSpy.Id) != null)
            {
                return false;
            }

            return true;
        }
    }
}
