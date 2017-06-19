using Layery.Data;
using LayeryDemo.DataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeryDemo.DataModel
{
    public class UnitOfWork : UnitOfWorkBase, IUnitOfWork
    {
        public UnitOfWork(SchoolDBContext context) : base(context)
        {
        }

        public IGenericRepository<Student> StandardRepository => GetRepository<Student>();
        public IGenericRepository<Student> StudentRepository => GetRepository<Student>();
        public IGenericRepository<Teacher> TeacherRepository => GetRepository<Teacher>();
        public IGenericRepository<Subject> SubjectRepository => GetRepository<Subject>();
    }
}
