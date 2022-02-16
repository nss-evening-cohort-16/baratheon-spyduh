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

        [HttpGet("id/{id}")]
        public IActionResult GetSpyByID(int _id)
        {
            var match = _repo.GetById(_id);

            if (match == null)
            {
                return NotFound();
            }

            return Ok(match);
        }

        [HttpGet("friendids/{friendsids")]
        public IActionResult GetSpyFriends(int friendsids)
        {
            var match = _repo.GetSpyFriendsIds(friendsids);
            if (match == null)
            {
                return NotFound();
            }
            return Ok(match);
        }        
    }
}
