using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpyDuh_Baratheon.DataAccess;
using SpyDuh_Baratheon.Models;

namespace SpyDuh_Baratheon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        SkillsRepository _skrpo;

        public SkillsController(SkillsRepository repo) { _skrpo = repo; }

        [HttpGet]
        public IEnumerable<Skills> GetAllSkills()
        {
            return _skrpo.GetAll();
        }

        [HttpGet("id/{id}")]
        public IActionResult GetSkillById(int id)
        {
            var match = _skrpo.GetById(id);

            if (match == null)
            {
                return NotFound();
            }

            return Ok(match);
        }

    }
}
