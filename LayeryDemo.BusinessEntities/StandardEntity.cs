using System.Collections.Generic;

namespace LayeryDemo.BusinessEntities
{
    public class StandardEntity
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public virtual ICollection<StudentEntity> Students { get; set; }
        public virtual ICollection<TeacherEntity> Teachers { get; set; }
    }
}
