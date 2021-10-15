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
    public partial class TeacherForm : Form
    {
        DbLCEntities1 db = new DbLCEntities1();
        public TeacherForm()
        {
            InitializeComponent();
        }


        void TeacherList()
        {
            Classes classes = new Classes();
            int id = Convert.ToInt32(txtTeachersId.Text);
            var x = db.Teacher.Find(id);



            var query = from item in db.Grades
                        where item.Classes.TeacherId == x.TeacherId && item.GradeIsActive == true && item.Student.StudentIsActive == true
                        && item.Classes.ClassIsActive == true && item.Classes.Teacher.TeacherIsActive == true

                        select new
                        {

                            item.GradeId,
                            item.Student.StudentName,
                            item.Student.StudentSurname,
                            item.Student.StudentNumber,
                            item.StudentAbsenteeism,
                            item.Grade1,
                            item.Grade2,
                            item.Classes.ClassName,

                        };


            gridControl1.DataSource = query.ToList();
        }
        //Where(y=>y.TeacherId==x.TeacherId)

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            TeacherList();
        }

        private void btnTeacherClassUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtGradeId.Text);
            var x = db.Grades.Find(id);

            if (x.Classes.Teacher.TeacherId == Convert.ToInt32(txtTeachersId.Text))
            {
                x.Classes.ClassName = txtStudentClass.Text;

                x.StudentAbsenteeism = Convert.ToInt32(txtStudentAbsenteeism.Text);
                x.Student.StudentNumber = txtStudentNumber.Text;
                x.Grade1 = txtGrade1.Text;
                x.Grade2 = txtGrade2.Text;
                db.SaveChanges();
                TeacherList();
                XtraMessageBox.Show("Liste Bilgileri Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //  MessageBox.Show("Liste Bilgileri Güncellendi");

            }
            else
            {
                XtraMessageBox.Show("Liste Bilgileri Güncellenemdi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //  MessageBox.Show("Bu derse erişim hakkınız yok");
            }
        }

        private void btnTeacherInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var teacher = db.Teacher.FirstOrDefault(x => x.TeacherId.ToString() == txtTeachersId.Text);
            //    var teacher = db.Teacher.FirstOrDefault(x => x.TeacherUsername == txtUsername.Text && x.TeacherPassword == txtPassword.Text);

            TeacherInfoForm teacherInfo = new TeacherInfoForm();

            teacherInfo.txtTeachersId.Text = teacher.TeacherId.ToString();
            teacherInfo.txtTeachersName.Text = teacher.TeacherName;
            teacherInfo.txtTeachersSurname.Text = teacher.TeacherSurname;
            teacherInfo.txtTeachersUsername.Text = teacher.TeacherUsername;
            teacherInfo.txtTeachersPassword.Text = teacher.TeacherPassword;

            teacherInfo.Show();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {


            txtGradeId.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
            txtStudentName.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
            txtStudentSurname.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();
            txtStudentNumber.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3]).ToString();
            txtStudentAbsenteeism.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[4]).ToString();
            txtGrade1.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[5]).ToString();
            txtGrade2.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[6]).ToString();
            txtStudentClass.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[7]).ToString();



        }

        private void btnexportpdf_Click(object sender, EventArgs e)
        {


            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string hedefKlasor = folderBrowserDialog1.SelectedPath.ToString();
                gridControl1.ExportToPdf(hedefKlasor + "\\teacher.Pdf");
            }
            else
            {
                MessageBox.Show("Dosyanın Kopyalanacağı Klasörü Seçmediniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUploadFolder_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                string filename = file.FileName;
                int id = Convert.ToInt32(txtGradeId.Text);
                var x = db.Grades.Find(id);

                if (x.Classes.Teacher.TeacherId == Convert.ToInt32(txtTeachersId.Text))
                {
                   
                    x.Folder = filename;
                    db.SaveChanges();
                    TeacherList();
                    XtraMessageBox.Show("Dosya Başarı ile Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   

                }
                else
                {
                    XtraMessageBox.Show("Dosya Başarı ile Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //  MessageBox.Show("Bu derse erişim hakkınız yok");
                }
            }
        }
    }
}

