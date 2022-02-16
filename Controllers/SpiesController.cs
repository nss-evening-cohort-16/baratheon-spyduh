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
        public IActionResult GetSpyByName(string _name)
        {
            var match = _repo.GetByName(_name);

            if (match == null)
            {
                return NotFound();
            }

            return Ok(match);
        }

        [HttpGet("{id}")]
        public IActionResult GetSpyByID(int _id)
        {
            var match = _repo.GetById(_id);

            if (match == null)
            {
                return NotFound();
            }

            return Ok(match);
        }

        // POST
        [HttpPost]
        public IActionResult PostNewSpy(Spy _spy)
        {
            if (_spy == null)
            {
                return NotFound();
            }
            else if (!ValidNewSpy(_spy)){
                return BadRequest();
            }
            else
            {
                _repo.Post(_spy);
                return Ok(_spy);
            }

        }

        private bool ValidNewSpy(Spy _spy)
        {
            if (string.IsNullOrWhiteSpace(_spy.Name))
            {
                return false;
            }

            if (_repo.GetByName(_spy.Name) != null)
            {
                return false;
            }

            if (_repo.GetById(_spy.Id) != null)
            {
                return false;
            }

            return true;
        }
    }
}
