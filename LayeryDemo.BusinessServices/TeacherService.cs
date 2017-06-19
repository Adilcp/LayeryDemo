using Layery.Business;
using LayeryDemo.BusinessEntities;
using LayeryDemo.DataModel;
using LayeryDemo.DataModel.Model;

namespace LayeryDemo.BusinessServices
{
    public class TeacherService : BusinessServiceBase<TeacherEntity, Teacher>, ITeacherService
    {
        public TeacherService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
