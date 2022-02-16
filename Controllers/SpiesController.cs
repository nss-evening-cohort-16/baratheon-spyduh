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

        [HttpGet("friendIds/{id}")]
        public IActionResult GetFriendIds(int id)
        {
            Spy spy = _repo.GetById(id);

            if (spy == null)
            {
                return NotFound();
            }

            return Ok(spy.FriendIds);
        }

        [HttpGet("friends/{id}")]
        public IActionResult GetFriends(int id)
        {
            Spy spy = _repo.GetById(id);

            if (spy == null)
            {
                return NotFound();
            }

            return Ok(_repo.GetFriends(spy));
        }

        [HttpGet("enemyIds/{id}")]
        public IActionResult GetEnemyIds(int id)
        {
            Spy spy = _repo.GetById(id);

            if (spy == null)
            {
                return BadRequest();
            }

            return Ok(spy.EnemyIds);
        }

        [HttpGet("enemies/{id}")]
        public IActionResult GetEnemies(int id)
        {
            Spy spy = _repo.GetById(id);

            if (spy == null)
            {
                return BadRequest();
            }

            return Ok(_repo.GetEnemies(spy));
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
