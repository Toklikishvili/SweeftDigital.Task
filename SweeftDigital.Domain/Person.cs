using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SweeftDigital.Domain;

public abstract class Person
{
    [Required]
    [Column(TypeName = "nvarchar(20)")]
    public string? FirstName { get; set; }
    [Required]
    [Column(TypeName = "nvarchar(30)")]
    public string? LastName { get; set; }
    [Required]
    [Column(TypeName = "nvarchar(10)")]
    public string? Gender { get; set; }
}