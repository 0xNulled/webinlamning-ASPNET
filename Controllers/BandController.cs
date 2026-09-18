namespace Metallix.Controllers;
using Microsoft.AspNetCore.Mvc;
using Metallix;
using Metallix.Models;

[ApiController]
[Route("api/[Controller]")]
public class BandController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(DummyData.ExampleDatabase.BandList);
    }

    [HttpGet("id/{id}")]
    public IActionResult GetById(int id)
    {
        var band = DummyData.ExampleDatabase.BandList.FirstOrDefault(b => b.Id == id);

        if (band == null)
        {
            return NotFound();
        }

        return Ok(band);
    }

    [HttpGet("name/{name}")]
    public IActionResult GetByName(string name)
    {
        var band = DummyData.ExampleDatabase.BandList.Find(b => b.Name == name);

        if (band == null) 
        { 
            return NotFound();
        }

        return Ok(band);
    }

    [HttpPut("updatebyid/{id}")]
    public IActionResult UpdateById(int id, Band updated_band)
    {
        var band = DummyData.ExampleDatabase.BandList.FirstOrDefault(b => b.Id == id);

        if (band == null)
        {
            return NotFound();
        }

        band = updated_band;

        return NoContent();
    }

    [HttpPost("create")]
    public IActionResult CreateBand(Band band)
    {
        if (band == null)
        {
            return NotFound();
        }

        int appendId = DummyData.ExampleDatabase.BandList.Count();

        try 
        {
            band.Id = appendId + 1;
            DummyData.ExampleDatabase.BandList.Append(band);
        } 
        catch (Exception err)
        {
            return BadRequest(err);
        }

        return Ok(band); //Debugg. När funktionalitet är mer säkerställd behöver vi inte returna bandet 
    }
}