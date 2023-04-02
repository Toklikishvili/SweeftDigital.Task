using Microsoft.EntityFrameworkCore;
using SweeftDigital.Domain;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("SweeftDigital.Repository")]
[assembly: InternalsVisibleTo("SweeftDigital.XUnitTest")]
[assembly: InternalsVisibleTo("SweeftDigitalTask")]

namespace SweeftDigital.DbConection;
internal class SweeftDigitalDbContext : DbContext
{
    public SweeftDigitalDbContext(DbContextOptions options) : base(options) { }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Pupil> Pupils { get; set; }
}