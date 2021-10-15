using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXLanguageCourseApp
{
    public partial class LoginForm : Form
    {
        DbLCEntities1 db = new DbLCEntities1();
        
        public LoginForm()
        {
            InitializeComponent();
        }

       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var manager = db.Manager.FirstOrDefault(x => x.ManagerUsername == txtUsername.Text && x.ManagerPassword == txtPassword.Text);
            var student = db.Student.FirstOrDefault(x => x.StudentUsername == txtUsername.Text && x.StudentPassword == txtPassword.Text);
            var teacher = db.Teacher.FirstOrDefault(x => x.TeacherUsername == txtUsername.Text && x.TeacherPassword == txtPassword.Text);
            
          

            if (manager != null)
            {
                ManagerFrm managerFrm = new ManagerFrm();
                managerFrm.Show();



            }
            else if (student != null)
            {
                StudentForm studentForm = new StudentForm();

                studentForm.txtStudentId.Text = student.StudentId.ToString();
                studentForm.txtStudentName.Text = student.StudentName;
                studentForm.txtStudentSurname.Text = student.StudentSurname;
                studentForm.txtStudentNumber.Text = student.StudentNumber;
                studentForm.txtStudentUsername.Text = student.StudentUsername;
                studentForm.txtStudentPassword.Text = student.StudentPassword;

                studentForm.Show();


            }
            else if (teacher != null)
            {
                TeacherForm teacherForm = new TeacherForm();
                teacherForm.txtTeachersId.Text = teacher.TeacherId.ToString();



                teacherForm.Show();

            }
            else
            {
                MessageBox.Show("Hatalı Bilgi.");
                //Console.WriteLine(student.StudentUsername);

            }
        }
    }
}
