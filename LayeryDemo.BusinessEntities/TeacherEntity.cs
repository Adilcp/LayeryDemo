using System.Collections.Generic;

namespace LayeryDemo.BusinessEntities
{
    public class TeacherEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<StandardEntity> Standards { get; set; }
        public virtual ICollection<SubjectEntity> Subjects { get; set; }
    }
}