using Layery.Business;
using LayeryDemo.BusinessEntities;
using LayeryDemo.DataModel;
using LayeryDemo.DataModel.Model;

namespace LayeryDemo.BusinessServices
{
    public class StudentService : BusinessServiceBase<StudentEntity, Student>, IStudentService
    {
        public StudentService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
