using System.ComponentModel.DataAnnotations;

namespace Metallix.Models;

public class Track
{  
    //inte [Required] då Track listing kan vara oklart eller obestämd (alternativt menat att vara circulärt)
    public int SongNumber { get; set; }
    [Required(ErrorMessage = "Track requires a title. If track title is intentionally 'nothing' then simply enter 'Blank'")] 
    public string Title { get; set; } = string.Empty;

}