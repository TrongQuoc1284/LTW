using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BT_Buoi5.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BT_Buoi5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Books
        // GET: api/Books?topicId=5
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks(int? topicId)
        {
            var query = _context.Books.Include(b => b.Topic).AsQueryable();

            if (topicId.HasValue)
            {
                query = query.Where(b => b.TopicId == topicId.Value);
            }

            return await query.ToListAsync();
        }

        // GET: api/Books/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            var book = await _context.Books.Include(b => b.Topic).FirstOrDefaultAsync(b => b.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }
    }
} 