using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LayeryDemo.DataModel.Model
{
    public class Subject
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}