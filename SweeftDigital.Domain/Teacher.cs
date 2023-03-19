using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SweeftDigital.Domain;

public sealed class Teacher : Person
{
    [Key]
    public int TeacherId { get; set; }
    [Column(TypeName = "nvarchar(20)")]
    public string? Subject { get; set; }
    public ICollection<Pupil>? Pupils { get; set; }
}
