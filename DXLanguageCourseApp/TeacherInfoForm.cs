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
    public partial class TeacherInfoForm : Form
    {
        DbLCEntities1 db = new DbLCEntities1();
        public TeacherInfoForm()
        {
            InitializeComponent();
        }


        private void btnTeacherUpdate_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtTeachersId.Text);
            var x = db.Teacher.Find(id);

            x.TeacherName = txtTeachersName.Text;
            x.TeacherSurname = txtTeachersSurname.Text;
            x.TeacherUsername = txtTeachersUsername.Text;
            x.TeacherPassword = txtTeachersPassword.Text;

            db.SaveChanges();
            MessageBox.Show(" Bilgileriniz Güncellendi");
        }

       
    }
}
