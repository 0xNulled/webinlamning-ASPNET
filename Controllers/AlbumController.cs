namespace Metallix.Controllers;
using Microsoft.AspNetCore.Mvc;
using Metallix;
using Metallix.Models;

[ApiController]
[Route("api/[Controller]")]
public class AlbumController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(DummyData.ExampleDatabase.AlbumList);
    }

    /*[HttpGet("id/{id}")]
    public IActionResult GetById(int id)
    {
        var album = DummyData.ExampleDatabase.AlbumList.FirstOrDefault();


    };*/

    //[HttpPut("updatebyid/{id}")]
    //public IActionResult UpdateById(int id, Album updatedAlbum)
}