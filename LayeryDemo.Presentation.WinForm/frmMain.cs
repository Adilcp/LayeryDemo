using LayeryDemo.BusinessEntities;
using LayeryDemo.BusinessServices;
using LayeryDemo.Presentation.WinForm.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LayeryDemo.Presentation.WinForm
{
    public partial class frmMain : Form
    {
        private ITeacherService teacherService;
        private IStandardService standardService;

        public frmMain(ITeacherService teacherService, IStandardService standardService)
        {
            this.teacherService = teacherService;
            this.standardService = standardService;
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            RefreshTeachersList();            
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            var standards = standardService.GetAll().Take(3);
            var teacher = new TeacherEntity { Name = "New Teacher", Standards = standards.ToList() };
            teacherService.Add(teacher);
            RefreshTeachersList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshTeachersList();
        }

        private void RefreshTeachersList()
        {
            lstTeacher.Items.Clear();
            var teachers = teacherService.GetAll<TeacherModel>();
            lstTeacher.Items.AddRange(teachers.ToArray());
        }

        private void lstTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {   
            TeacherEntity selectedTeacher = teacherService.GetById(((TeacherModel)lstTeacher.SelectedItem).Id, true, true);
            lstStds.Items.Clear();
            lstStds.Items.AddRange(selectedTeacher.Standards.ToArray());

        }
    }
}
