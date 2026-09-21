using System.ComponentModel.DataAnnotations;

namespace Metallix.Models;

public class Album
{
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "Album must have a title")]
    public string AlbumName { get; set; } = string.Empty;
    [Required]
    public string Artist { get; set; } = "N/A";

    public bool ListeningStatus { get; set; } = false;
}
