using DevExpress.XtraEditors;
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
    public partial class StudentForm : Form
    {
        DbLCEntities1 db = new DbLCEntities1();
        public StudentForm()
        {
            InitializeComponent();
        }



        private void dataGridViewStudents_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtStudentId.Text);
            var x = db.Student.Find(id);


            x.StudentName = txtStudentName.Text;
            x.StudentSurname = txtStudentSurname.Text;
            x.StudentUsername = txtStudentUsername.Text;
            x.StudentPassword = txtStudentPassword.Text;
        }
        void StundetList()
        {
            int id = Convert.ToInt32(txtStudentId.Text);
            var x = db.Student.Find(id);
            var query = from item in db.Grades
                        where item.StudentId == x.StudentId && item.GradeIsActive == true && item.Student.StudentIsActive == true
                        && item.Classes.ClassIsActive == true && item.Classes.Teacher.TeacherIsActive == true
                        select new
                        {

                            item.Student.StudentName,
                            item.Student.StudentSurname,
                            item.Classes.ClassName,
                            t = item.Classes.Teacher.TeacherName +" "+item.Classes.Teacher.TeacherSurname,
                            item.Student.StudentNumber,
                            item.StudentAbsenteeism,
                            item.Grade1,
                            item.Grade2,
                            item.Student.StudentUsername,
                            item.Student.StudentPassword


                        };


            gridControl1.DataSource = query.ToList();
        }
        private void StudentForm_Load(object sender, EventArgs e)
        {
            StundetList();
        }

        private void btnStudentUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtStudentId.Text);
            var x = db.Student.Find(id);

            if (txtStudentId.Text != "")
            {
                x.StudentUsername = txtStudentUsername.Text;
                x.StudentPassword = txtStudentPassword.Text;

                db.SaveChanges();
                StundetList();
               
                XtraMessageBox.Show("Liste Bilgileri Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // MessageBox.Show("Liste Bilgileri Güncellendi");

            }
            else
            {
                XtraMessageBox.Show("Liste Bilgileri Güncellenemedi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // MessageBox.Show("Bu derse erişim hakkınız yok");
            }
        }

        private void btnexportpdf_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string hedefKlasor = folderBrowserDialog1.SelectedPath.ToString();
                gridControl1.ExportToPdf(hedefKlasor + "\\student.Pdf");
            }
            else
            {
                MessageBox.Show("Dosyanın Kopyalanacağı Klasörü Seçmediniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
