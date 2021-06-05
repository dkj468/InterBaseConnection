using System.Threading.Tasks;
using Interbase_connection.Data;
using Microsoft.AspNetCore.Mvc;

namespace Interbase_connection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkRequestController : ControllerBase
    {
        IRepository _repo;
        public WorkRequestController(IRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetWorkRequests()
        {
            var lists = await _repo.GetAllWorkrequest();
            return Ok(lists);
        }
    }
}