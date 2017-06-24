using Layery.Business;
using LayeryDemo.BusinessEntities;
using LayeryDemo.DataModel;
using LayeryDemo.DataModel.Model;

namespace LayeryDemo.BusinessServices
{
    public class StudentService : BusinessServiceBase<StudentEntity, Student>, IStudentService
    {
        private IUnitOfWork unitOfWork;
        public StudentService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Get student by name
        /// </summary>
        /// <param name="studentName">Name of the student</param>
        /// <returns>StudentEntity</returns>
        public StudentEntity GetStudentByName(string studentName) => GetStudentByName<StudentEntity>(studentName);

        /// <summary>
        /// Get student by name
        /// </summary>
        /// <typeparam name="Model">Type</typeparam>
        /// <param name="studentName">Name of student</param>
        /// <returns>Model</returns>
        public Model GetStudentByName<Model>(string studentName) => MapHelper.Map<Model>(unitOfWork.StudentRepository.Get(x => x.Name == studentName));
    }
}
