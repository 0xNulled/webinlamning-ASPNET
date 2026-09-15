using System.ComponentModel.DataAnnotations;

namespace Metallix.Models;

public class Album
{
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "Album must have a title")]
    public string Title { get; set; } = string.Empty;
    [Required]
    public int ReleaseYear { get; set; }

    public List<Tracks> TrackList { get; set;}
}