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
        SkillsRepository _skillsRepo = new SkillsRepository();

        [HttpGet]
        public List<Skills> GetAllSkills()
        {
            return _skillsRepo.GetAll();
        }
    }
}
