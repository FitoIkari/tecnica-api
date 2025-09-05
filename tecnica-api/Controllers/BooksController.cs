using Microsoft.AspNetCore.Mvc;
using tecnica_api.Models;

namespace tecnica_api.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class BookController : ControllerBase
    {
        public static List<BookModel> Books = new() 
        { 
            new() { Title = "El fin del mundo y un despiadado pa�s de las maravillas", Id = Guid.NewGuid() },
            new() { Title = "La chica mec�nica", Id = Guid.NewGuid() }
        };

        [HttpGet]
        public ActionResult<List<BookModel>> GetBooks()
        {
            return Ok(Books);
        }
    }
}