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
    public partial class MStudentForm : Form
    {
        DbLCEntities1 db = new DbLCEntities1();
        public MStudentForm()
        {
            InitializeComponent();
        }
        void MStudentList()
        {
            gridControl1.DataSource = db.Student.Where(x=>x.StudentIsActive==true).ToList();
            gridView1.Columns[3].Visible = false;
            gridView1.Columns[4].Visible = false;
            gridView1.Columns[6].Visible = false;
            gridView1.Columns[7].Visible = false;


        }
        private void MStudentForm_Load(object sender, EventArgs e)
        {
            MStudentList();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtStudentId.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString());
            txtStudentName.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
            txtStudentSurname.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();
          //  txtStudentAbsenteeism.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[5]).ToString();
            txtStudentNumber.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[5]).ToString();
            //txtGrade1.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[7]).ToString(); 
            //txtGrade2.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[8]).ToString();
        }

        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            if (txtStudentName.Text != "")
            {
             
                
                Student student = new Student();
                student.StudentName = txtStudentName.Text;
                student.StudentSurname = txtStudentSurname.Text;
                
                student.StudentNumber = txtStudentNumber.Text;
                student.StudentUsername = txtStudentName.Text;
                student.StudentPassword = txtStudentSurname.Text;
              
                student.StudentIsActive = true;

                db.Student.Add(student);
                db.SaveChanges();
                MStudentList();
                XtraMessageBox.Show("Öğrenci Ekleme İşlemi Başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // MessageBox.Show("Öğrenci Eklenmiştir");
            }
            else
            {
                XtraMessageBox.Show("Öğrenci Ekleme İşlemi Başarısız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
             //   MessageBox.Show("Öğrenci Ekleme İşlemi Başarısız");
            }

        }
        private void btnStudentUpdate_Click(object sender, EventArgs e)
        {
            if (txtStudentId.Text != "")
            {
                int id = Convert.ToInt32(txtStudentId.Text);
                var x = db.Student.Find(id);
                x.StudentName = txtStudentName.Text;
                x.StudentSurname = txtStudentSurname.Text;
           
                x.StudentNumber = txtStudentNumber.Text;
               

                db.SaveChanges();
                MStudentList();
                XtraMessageBox.Show("Öğrenci Güncelleme İşlemi Başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("Öğrenci Bilgileri Güncellendi");

            }
            else
            {
                XtraMessageBox.Show("Öğrenci Güncelleme İşlemi Başarısız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
              //  MessageBox.Show("Öğrenci Güncelleme İşlemi Başarısız");
            }
        }

        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            if (txtStudentId.Text != "")
            {
                int id = Convert.ToInt32(txtStudentId.Text);
                var x = db.Student.Find(id);
                x.StudentIsActive = false;
                db.SaveChanges();
                MStudentList();
                XtraMessageBox.Show("Öğrenci Silme İşlemi Başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // MessageBox.Show("Öğrenci Silindi");

            }
            else
            {
                XtraMessageBox.Show("Öğrenci Silme İşlemi Başarısız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // MessageBox.Show("Öğrenci Silme İşlemi Başarısız");
            }
        }

        private void btnexportpdf_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string hedefKlasor = folderBrowserDialog1.SelectedPath.ToString();
                gridControl1.ExportToPdf(hedefKlasor + "\\students.Pdf");
            }
            else
            {
                MessageBox.Show("Dosyanın Kopyalanacağı Klasörü Seçmediniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

     
    }
}

