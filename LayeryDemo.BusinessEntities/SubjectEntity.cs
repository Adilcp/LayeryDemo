using System.Collections.Generic;

namespace LayeryDemo.BusinessEntities
{
    public class SubjectEntity
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public virtual ICollection<TeacherEntity> Teachers { get; set; }
    }
}