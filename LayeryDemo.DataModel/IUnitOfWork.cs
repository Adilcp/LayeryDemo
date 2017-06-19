using Layery.Data;
using LayeryDemo.DataModel.Model;

namespace LayeryDemo.DataModel
{
    public interface IUnitOfWork : IUnitOfWorkBase
    {
        IGenericRepository<Student> StandardRepository { get; }
        IGenericRepository<Student> StudentRepository { get; }
        IGenericRepository<Subject> SubjectRepository { get; }
        IGenericRepository<Teacher> TeacherRepository { get; }
    }
}