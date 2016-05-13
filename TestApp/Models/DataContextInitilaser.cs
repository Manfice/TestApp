using System.Collections.Generic;
using System.Data.Entity;

namespace TestApp.Models
{
    public class DataContextInitilaser:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            new List<RelationType>
            {
                new RelationType {Title = "Друг"},
                new RelationType {Title = "Враг"},
                new RelationType {Title = "Знакомый"},
                new RelationType {Title = "Влюблен"},
                new RelationType {Title = "Хто это??"}
            }.ForEach(item=>context.RelationTypes.Add(item));
            context.SaveChanges();
        }
    }
}