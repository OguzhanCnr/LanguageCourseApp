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
    public partial class ClassFormcs : Form
    {
        DbLCEntities1 db = new DbLCEntities1();
        public ClassFormcs()
        {
            InitializeComponent();
        }

        void ClassList()
        {
            var query = (from item in db.Classes
                         where item.ClassIsActive == true
                         select new
                         {
                             item.ClassId,
                             item.ClassName,
                             item.Teacher.TeacherName
                         });

            gridControl1.DataSource = query.ToList();

            var teacher = (from x in db.Teacher
                           where x.TeacherIsActive == true
                           select new
                           {
                               x.TeacherId,
                               x.TeacherName
                           }).ToList();
            lupTeacher.Properties.ValueMember = "TeacherId";
            lupTeacher.Properties.DisplayMember = "TeacherName";
            lupTeacher.Properties.DataSource = teacher;
        }

        private void ClassFormcs_Load(object sender, EventArgs e)
        {
            ClassList();

        }

        private void btnClassAdd_Click(object sender, EventArgs e)
        {
            Classes classes = new Classes();
            classes.ClassName = txtClassName.Text;
            classes.TeacherId = int.Parse(lupTeacher.EditValue.ToString());
            classes.ClassIsActive = true;

            db.Classes.Add(classes);
            db.SaveChanges();

            ClassList();
        }

        private void btnClassDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtClassId.Text);
            var x = db.Classes.Find(id);
            x.ClassIsActive = false;

            db.SaveChanges();
            XtraMessageBox.Show("Sınıf Silme İşlemi Başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClassList();
        }

        private void btnClassUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtClassId.Text);
            var x = db.Classes.Find(id);
            x.ClassName = txtClassName.Text;
            x.TeacherId = int.Parse(lupTeacher.EditValue.ToString());

            db.SaveChanges();
            XtraMessageBox.Show("Sınıf Güncelleme İşlemi Başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClassList();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtClassId.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString());
            txtClassName.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
            lupTeacher.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();
            //   txtManagerUsername.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3]).ToString();
            //txtManagerPassword.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[4]).ToString();
        }

        private void btnexportpdf_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string hedefKlasor = folderBrowserDialog1.SelectedPath.ToString();
                gridControl1.ExportToPdf(hedefKlasor + "\\class.Pdf");
            }
            else
            {
                MessageBox.Show("Dosyanın Kopyalanacağı Klasörü Seçmediniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
