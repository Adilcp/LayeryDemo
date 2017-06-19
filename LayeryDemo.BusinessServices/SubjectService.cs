using Layery.Business;
using LayeryDemo.BusinessEntities;
using LayeryDemo.DataModel;
using LayeryDemo.DataModel.Model;

namespace LayeryDemo.BusinessServices
{
    public class SubjectService : BusinessServiceBase<SubjectEntity, Subject>
    {
        public SubjectService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
