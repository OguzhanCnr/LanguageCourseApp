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
    public partial class MTeacherForm : Form
    {
        DbLCEntities1 db = new DbLCEntities1();
        public MTeacherForm()
        {
            InitializeComponent();
        }
        void MTeacherList()
        {
           // gridControl1.DataSource = db.Manager.Where(x => x.ManagerIsActive == true).ToList();
            gridControl1.DataSource = db.Teacher.Where(x=>x.TeacherIsActive==true).ToList();
            gridView1.Columns[3].Visible = false;
            gridView1.Columns[4].Visible = false;
            gridView1.Columns[5].Visible = false;
            gridView1.Columns[6].Visible = false;

        }
        private void MTeacherForm_Load(object sender, EventArgs e)
        {
            MTeacherList();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtTeacherId.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
            txtTeacherName.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
            txtTeacherSurname.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();

        }

        private void btnTeacherAdd_Click(object sender, EventArgs e)
        {
            if (txtTeacherName.Text != "")
            {

                Teacher teacher = new Teacher();
                teacher.TeacherName = txtTeacherName.Text;
                teacher.TeacherSurname = txtTeacherSurname.Text;
                teacher.TeacherIsActive = true;
                teacher.TeacherUsername = txtTeacherName.Text;
                teacher.TeacherPassword = txtTeacherSurname.Text;

                db.Teacher.Add(teacher);
                db.SaveChanges();
                MTeacherList();

                XtraMessageBox.Show("Öğretmen Ekleme İşlemi Başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
              //  MessageBox.Show("Öğretmen Eklenmiştir");
            }
            else
            {
                XtraMessageBox.Show("Öğretmen Ekleme İşlemi Başarısız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("Öğretmen Ekleme İşlemi Başarısız");
            }
        }

        private void btnTeacherUpdate_Click(object sender, EventArgs e)
        {
            if (txtTeacherId.Text != "")
            {

                int id = Convert.ToInt32(txtTeacherId.Text);
                var x = db.Teacher.Find(id);

                x.TeacherName = txtTeacherName.Text;
                x.TeacherSurname = txtTeacherSurname.Text;
                db.SaveChanges();
                MTeacherList();
                XtraMessageBox.Show("Öğretmen Güncelleme İşlemi Başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
              //  MessageBox.Show("Öğretmen Bilgileri Güncellendi");

            }
            else
            {
                XtraMessageBox.Show("Öğretmen Güncelleme İşlemi Başarısız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
              //  MessageBox.Show("Öğretmen Güncelleme İşlemi Başarısız");
            }
        }

        private void btnTeacherDelete_Click(object sender, EventArgs e)
        {
            if (txtTeacherId.Text != "")
            {

                int id = Convert.ToInt32(txtTeacherId.Text);
                var x = db.Teacher.Find(id);
                x.TeacherIsActive = false;
               // db.Teacher.Remove(x);
                db.SaveChanges();
                MTeacherList();
                XtraMessageBox.Show("Öğretmen Silme İşlemi Başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
              //  MessageBox.Show("Öğretmen Silindi");

            }
            else
            {
                XtraMessageBox.Show("Öğretmen Silme İşlemi Başarısız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
              //  MessageBox.Show("Öğretmen Silme İşlemi Başarısız");
            }
        }

        private void btnexportpdf_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string hedefKlasor = folderBrowserDialog1.SelectedPath.ToString();
                gridControl1.ExportToPdf(hedefKlasor + "\\teachers.Pdf");
            }
            else
            {
                MessageBox.Show("Dosyanın Kopyalanacağı Klasörü Seçmediniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
