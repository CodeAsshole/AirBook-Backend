using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AirBook.Models
{
    public class TestContext : DbContext
    {
        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public virtual DbSet<TestModel> test { get; set; }
    }

    public class TestModel
    {
        public TestModel(){}

        public int Id { get; set; }

        [MaxLength(32)]
        public string Name { get; set; }
    }
}