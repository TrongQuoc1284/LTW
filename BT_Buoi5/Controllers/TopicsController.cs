using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BT_Buoi5.Data;
using System.Linq;

namespace BT_Buoi5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TopicsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Topics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<object>>> GetTopicsWithBookCount()
        {
            var topicsWithCount = await _context.Topics
                .Select(t => new
                {
                    t.Id,
                    t.Name,
                    BookCount = _context.Books.Count(b => b.TopicId == t.Id)
                })
                .ToListAsync();

            return topicsWithCount;
        }
    }
} 