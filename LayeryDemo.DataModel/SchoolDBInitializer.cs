using LayeryDemo.DataModel.Model;
using System.Collections.Generic;
using System.Data.Entity;

namespace LayeryDemo.DataModel
{
    public class SchoolDBInitializer : CreateDatabaseIfNotExists<SchoolDBContext>
    {
        protected override void Seed(SchoolDBContext context)
        {
            var std1 = new Standard { Label = "1" };
            var std2 = new Standard { Label = "2" };
            var std3 = new Standard { Label = "3" };
            var std4 = new Standard { Label = "4" };
            var std5 = new Standard { Label = "5" };

            context.Standards.Add(std1);
            context.Standards.Add(std2);
            context.Standards.Add(std3);
            context.Standards.Add(std4);
            context.Standards.Add(std5);

            List<Teacher> teachersList = new List<Teacher>();
            teachersList.Add(new Teacher { Name = "Teacher1", Standards = new List<Standard> { std1, std2, std4 } });
            teachersList.Add(new Teacher { Name = "Teacher2", Standards = new List<Standard> { std2, std3, std4 } });
            teachersList.Add(new Teacher { Name = "Teacher3", Standards = new List<Standard> { std1, std4 } });
            teachersList.Add(new Teacher { Name = "Teacher4", Standards = new List<Standard> { std4 } });

            context.Teachers.AddRange(teachersList);
        }
    }
}
