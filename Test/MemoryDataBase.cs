using Microsoft.EntityFrameworkCore;
using SweeftDigital.DbConection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("SweeftDigitalTask")]
namespace Test;
internal static class MemoryDataBase
{
    private static SweeftDigitalDbContext? _context;
    public static SweeftDigitalDbContext GetMemoryDatabase()
    {
        if (_context == null)
        {
            var dbOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("MemoryDbContext");
            _context = new SweeftDigitalDbContext(dbOptions.Options);
            return _context;
        }
        return _context;
    }
}
