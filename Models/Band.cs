using System.ComponentModel.DataAnnotations;

namespace Metallix.Models;

public class Band
{
    [Required]
    public int Id { get; set;}
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Genre { get; set; } = string.Empty;
    [Required]
    public bool Status { get; set; }

    // public list<album> Albums { get; set; }

};