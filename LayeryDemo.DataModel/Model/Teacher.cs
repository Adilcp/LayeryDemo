using System.Collections.Generic;

namespace LayeryDemo.DataModel.Model
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Standard> Standards { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}