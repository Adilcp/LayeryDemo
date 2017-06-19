using Layery.Business;
using LayeryDemo.BusinessEntities;
using LayeryDemo.DataModel;
using LayeryDemo.DataModel.Model;

namespace LayeryDemo.BusinessServices
{
    public class StandardService : BusinessServiceBase<StandardEntity, Standard>, IStandardService
    {
        public StandardService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
