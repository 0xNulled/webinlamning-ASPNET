namespace Metallix.Controllers;
using Microsoft.AspNetCore.Mvc;
using Metallix;
using Metallix.Models;

[ApiController]
[Route("api/[Controller]")]
public class AlbumController : ControllerBase
{
    [HttpGet]
    //public IActionResult GetAll() {};
    [HttpGet("id/{id}")]
    //public IActionResult GetById(int id) {};
    [HttpPut("updatebyid/{id}")]
    //public IActionResult UpdateById(int id, Album updatedAlbum)
}