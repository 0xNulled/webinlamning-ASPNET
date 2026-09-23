namespace Metallix.Controllers;
using Microsoft.AspNetCore.Mvc;
using Metallix;

using System;
using System.IO;
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

    [HttpPut("{id}")]
    public IActionResult UpdateListeningStatus(int id)
    {
        var album = DummyData.ExampleDatabase.AlbumList.FirstOrDefault((band) => band.id == id);

        if (album == null) return NotFound();

        album.listeningStatus = !album.listeningStatus;

        return Ok();
    }

    [HttpPost("{id}/image")]
    public async Task<IActionResult> UploadNewImage(int id, IFormFile file) 
    {
        if (file.Length == 0) return BadRequest("ingen bild vald");

        var album = DummyData.ExampleDatabase.AlbumList.FirstOrDefault((album) => album.id == id );

        if (album == null) return NotFound();

        var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
        var filePath = Path.Combine("wwwroot/uploads", fileName);

        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await file.CopyToAsync(stream);
        }

        album.imageURL = $"/uploads/{fileName}";

        return Ok(album.imageURL);
    }

    [HttpPost("addAlbum")]
    public IActionResult createNewAlbum(Album newAlbum)
    {
        newAlbum.id = DummyData.ExampleDatabase.AlbumList.Count() + 1;

        DummyData.ExampleDatabase.AlbumList.Add(newAlbum);

        return Created();
    }
}