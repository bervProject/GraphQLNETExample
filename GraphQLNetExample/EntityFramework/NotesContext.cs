using GraphQLNetExample.Notes;
using Microsoft.EntityFrameworkCore;

namespace GraphQLNetExample.EntityFramework
{
    public class NotesContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }

        public NotesContext(DbContextOptions options) : base(options)
        {

        }
    }
}
