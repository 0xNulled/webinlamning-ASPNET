using System.ComponentModel.DataAnnotations;

namespace Metallix.Models;

public class Album
{
    
    public int id { get; set; }
   
    public string albumName { get; set; } = string.Empty;
    
    public string artist { get; set; } = string.Empty;

    public bool listeningStatus { get; set; } = false;

    public string? imageURL { get; set; }
}
