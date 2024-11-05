using Microsoft.EntityFrameworkCore;
using NoteTaking.Models;
using System.Collections.Generic;

namespace NoteTaking.Data
{
    public class NoteContext : DbContext
    {
        public NoteContext(DbContextOptions<NoteContext> options) : base(options) { }

        public DbSet<Note> Notes { get; set; }
    }
}
