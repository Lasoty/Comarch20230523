using BibliotekarzOctf.Shared.ModelDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace BibliotekarzOctf.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    [RequiredScope()]
    public class BookController : ControllerBase
    {
        public BookController()
        {
            
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll()
        {
            List<BookDto> books = new List<BookDto>()
            {
                new BookDto
                {
                    Id = 1,
                    Author = "Leszek  Lewandowski",
                    Title = "Title",
                    IsBorrowed = true,
                    PageCount = 123,
                    Borrower = new CustomerDto
                    {
                        Id = 1,
                        FirstName = "Adam",
                        LastName = "Nowak"
                    }
                }
            };

            return Ok(books);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Add(BookDto book)
        {
            return Ok(book);
        }
    }
}
