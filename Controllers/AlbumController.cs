namespace Metallix.Controllers;
using Microsoft.AspNetCore.Mvc;
using Metallix;
using Metallix.Models;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using System.Reflection.Metadata.Ecma335;

[ApiController]
[Route("api/[Controller]")]
public class AlbumController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(DummyData.ExampleDatabase.AlbumList);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateListeningStatus(int id, Album test )
    {
        Console.WriteLine(id);
        Console.WriteLine(test);
        var album = DummyData.ExampleDatabase.AlbumList.FirstOrDefault((band) => band.id == id);

        //if (album == null) return NotFound();

        album.listeningStatus = !album.listeningStatus;
        //album.ListeningStatus = listeningStatus;
        //Console.WriteLine(id);
        //Console.WriteLine(listeningStatus);

        return Ok();
    }

    /*[HttpGet("id/{id}")]
    public IActionResult GetById(int id)
    {
        var album = DummyData.ExampleDatabase.AlbumList.FirstOrDefault();


    };*/

    //[HttpPut("updatebyid/{id}")]
    //public IActionResult UpdateById(int id, Album updatedAlbum)
}