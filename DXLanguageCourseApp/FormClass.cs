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
    public partial class FormClass : Form
    {
        DbLCEntities1 db = new DbLCEntities1();
        public FormClass()
        {
            InitializeComponent();
        }


        void GradeList()
        {
            var query = from item in db.Grades
                        where item.GradeIsActive == true && item.Student.StudentIsActive == true
                        && item.Classes.ClassIsActive == true && item.Classes.Teacher.TeacherIsActive == true
                        select new
                        {
                            item.GradeId,
                            item.StudentId,
                            NameSurname = item.Student.StudentName +" "+ item.Student.StudentSurname,
                            item.Student.StudentNumber,
                            item.Classes.ClassName,
                            Teacher = item.Classes.Teacher.TeacherName +" "+ item.Classes.Teacher.TeacherSurname,
                            item.Grade1,
                            item.Grade2,
                            item.StudentAbsenteeism,
                        };
            gridControl1.DataSource = query.ToList();
            var student = (from x in db.Student
                           where x.StudentIsActive == true
                           select new
                           {
                               x.StudentId,
                               x.StudentName,
                               x.StudentSurname,
                               x.StudentNumber,

                           }).ToList();

            lupStudentName.Properties.ValueMember = "StudentId";
            lupStudentName.Properties.DisplayMember = "StudentNumber";
            lupStudentName.Properties.DataSource = student;
            var classes = (from y in db.Classes
                           where y.ClassIsActive == true
                           select new
                           {
                               y.ClassId,
                               y.ClassName


                           }).ToList();
            lupClasses.Properties.ValueMember = "ClassId";
            lupClasses.Properties.DisplayMember = "ClassName";
            lupClasses.Properties.DataSource = classes;

        }
        private void FormClass_Load(object sender, EventArgs e)
        {
            GradeList();

        }


        private void btnClassDelete_Click(object sender, EventArgs e)
        {
            if (txtGradeId.Text != "")
            {
                int id = Convert.ToInt32(txtGradeId.Text);
                var x = db.Grades.Find(id);
                x.GradeIsActive = false;

                db.SaveChanges();
                GradeList();
                MessageBox.Show("Başarı ile Silindi");

            }
        }

        private void btnClassUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtGradeId.Text);
            var x = db.Grades.Find(id);
            x.StudentId = int.Parse(lupStudentName.EditValue.ToString());
            x.ClassId = int.Parse(lupClasses.EditValue.ToString());
            x.Grade1 = txtGrade1.Text;
            x.Grade2 = txtGrade2.Text;
            x.StudentAbsenteeism = int.Parse(txtStudentAbsenteeism.Text);

            db.SaveChanges();
            GradeList();
            MessageBox.Show("Liste Bilgileri Güncellendi");
        }

        private void btnClassAdd_Click(object sender, EventArgs e)
        {
            var teacher = db.Student.FirstOrDefault(x => x.StudentNumber.ToString() == lupStudentName.Text);
            var classes = db.Classes.FirstOrDefault(y => y.ClassName == lupClasses.Text);
            Grades grades = new Grades();

            // grades.Student.StudentName = txtStudentName.Text;
            grades.StudentId = teacher.StudentId;
            grades.ClassId = classes.ClassId;
            grades.Grade1 = txtGrade1.Text;
            grades.Grade2 = txtGrade2.Text;
            grades.StudentAbsenteeism = int.Parse(txtStudentAbsenteeism.Text);
            grades.GradeIsActive = true;


            //  var student = db.Student.FirstOrDefault(y => y.StudentName == txtStudentName.Text);
            // grades.Classes.ClassName = txtClass.Text;



            db.Grades.Add(grades);
            db.SaveChanges();
            GradeList();
            MessageBox.Show("Listeye Ekleme Yapıldı");
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtGradeId.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
            //txtStudentName.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
            //txtStudentSurname.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();
            lupStudentName.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3]).ToString();
            lupClasses.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[4]).ToString();
            //txtClass.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[5]).ToString();
            txtGrade1.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[6]).ToString();
            txtGrade2.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[7]).ToString();
            txtStudentAbsenteeism.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[8]).ToString();

        }

        private void btnexportpdf_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string hedefKlasor = folderBrowserDialog1.SelectedPath.ToString();
                gridControl1.ExportToPdf(hedefKlasor + "\\classlist.Pdf");
            }
            else
            {
                MessageBox.Show("Dosyanın Kopyalanacağı Klasörü Seçmediniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
