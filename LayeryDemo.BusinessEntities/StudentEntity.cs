namespace LayeryDemo.BusinessEntities
{
    public class StudentEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual StandardEntity Standard { get; set; }
    }
}