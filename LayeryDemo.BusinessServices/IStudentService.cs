using Layery.Business;
using LayeryDemo.BusinessEntities;

namespace LayeryDemo.BusinessServices
{
    public interface IStudentService : IBusinessServiceBase<StudentEntity>
    {
        /// <summary>
        /// Get student by name
        /// </summary>
        /// <param name="studentName">Name of the student</param>
        /// <returns>StudentEntity</returns>
        StudentEntity GetStudentByName(string studentName);

        /// <summary>
        /// Get student by name
        /// </summary>
        /// <typeparam name="Model">Type</typeparam>
        /// <param name="studentName">Name of student</param>
        /// <returns>Model</returns>
        Model GetStudentByName<Model>(string studentName);
    }
}