namespace LayeryDemo.DataModel.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Standard Standard { get; set; }
    }
}