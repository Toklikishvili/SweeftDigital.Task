using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SweeftDigital.Domain;

public sealed class Pupil : Person
{
    [Key]
    public int PupilId { get; set; }
    [Column(TypeName = "nvarchar(20)")]
    public string? Class { get; set; }
    public ICollection<Teacher>? Teachers { get; set; }
}
