using Microsoft.AspNetCore.Mvc;
using MyBookshopAPI.Communication;

namespace MyBookshopAPI.Controllers;
[Route("api/[controller]")]
[ApiController]

public class BookShopController : ControllerBase {
    [HttpGet]
    [Route("books")]
    [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult GetAll() {

        List<Book> books = new() {
            new Book(){
                Autor = "Ian",
                Gender = ["Drama"],
                Id = 1,
                Price = "9,99",
                Quantity = 10,
                Title = "A jornada de um só Homem",
            },
            new Book(){
                Autor = "Mariah",
                Gender = ["Comédia"],
                Id = 2,
                Price = "9,99",
                Quantity = 10,
                Title = "Os cantos que ali vão",
            },
        };

        return Ok(books);
    }

    [HttpPost]
    [Route("books")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult Create([FromBody]Book book) {
        ResponseCreateBookJson response = new() {
            Id = book.Id,
        };
        return Created(string.Empty, response);
    }

    [HttpDelete]
    [Route("books/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] int id) { 
        return NoContent();
    }

    [HttpPut]
    [Route("books/{id}")]
    [ProducesResponseType(typeof(Book), StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] int id) {
        return NoContent();
    }
}
