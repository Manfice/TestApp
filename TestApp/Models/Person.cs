using System.Collections.Generic;

namespace TestApp.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsMale { get; set; }
        public virtual Person Spouse { get; set; }
        public virtual ICollection<Relation> Relations { get; set; }
        public virtual MyPhoto Photo { get; set; }
        public virtual ICollection<Interest> Interests { get; set; }
    }

    public class Interest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual Person Person { get; set; }
    }

    public class MyPhoto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }
    }

    public class Relation
    {
        public int Id { get; set; }
        public virtual Person Person { get; set; }
        public virtual RelationType RelationType { get; set; }
    }

    public class RelationType
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }

}