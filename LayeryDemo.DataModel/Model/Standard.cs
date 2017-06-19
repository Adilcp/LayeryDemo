using System.Collections.Generic;

namespace LayeryDemo.DataModel.Model
{
    public class Standard
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
