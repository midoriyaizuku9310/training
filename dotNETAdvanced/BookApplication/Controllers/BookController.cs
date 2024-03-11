using EmployeeWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using AutoMapper;
namespace EmployeeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        readonly IMapper _mapper;
        readonly IBookDataAccess dal;

        public BookController(IMapper mapper, IBookDataAccess dal)
        {
            _mapper = mapper;
            this.dal = dal;
        }

        [HttpGet]
        [Route("getBooks")]
        public List<Books> getBooks()
        {
            BookDataAccess dal = new BookDataAccess();
            List<Books> books = dal.getBooks();
            return books;
        }

        [HttpGet]
        [Route("getBookById/{id}")]
        public ActionResult getBookById(int id)
        {
            try
            {
                //BookDataAccess dal = new BookDataAccess();
                Books book = dal.getBookById(id);
                return Ok(book);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("addBook")]

        public ActionResult Post([FromBody] Books book)
        {
            try
            {
               // BookDataAccess dal = new BookDataAccess();
                dal.addBooks(book);
                return Ok("record added");
            }
            catch(Exception ex) { 
            return BadRequest(ex.Message);  
            }

        }

        [HttpPut]
        [Route("updateBook")]

        public void update(Books book)
        {
           // BookDataAccess dal = new BookDataAccess();
            dal.update(book);

        }

        [HttpDelete]
        [Route("deleteBookById/{id}")]

        public void deleteBook(int id)
        {
            //BookDataAccess dal = new BookDataAccess();
            dal.delete(id);
        }

    }
}
