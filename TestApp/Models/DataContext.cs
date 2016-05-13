using System.Data.Entity;

namespace TestApp.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("PersonRelations")
        {
            Database.SetInitializer<DataContext>(new DataContextInitilaser());
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<MyPhoto> MyPhotos { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<RelationType> RelationTypes { get; set; }
        public DbSet<Relation> Relations { get; set; }
    }
}