using DevExpress.XtraBars;
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
    public partial class ManagerFrm : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        DbLCEntities1 db = new DbLCEntities1();
        public ManagerFrm()
        {
            InitializeComponent();
        }

        void ManagerList()
        {
            gridControl1.DataSource = db.Manager.Where(x => x.ManagerIsActive == true).ToList();
            gridView1.Columns[5].Visible = false;
        }


        private void btnClassFrm_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormClass frmClass = new FormClass();
            frmClass.Show();


        }



        private void btnStudentList_ItemClick(object sender, ItemClickEventArgs e)
        {
            MStudentForm mStudentForm = new MStudentForm();
            mStudentForm.Show();
        }

        private void btnTeacherList_ItemClick(object sender, ItemClickEventArgs e)
        {
            MTeacherForm mTeacherForm = new MTeacherForm();
            mTeacherForm.Show();
        }

        private void ManagerFrm_Load(object sender, EventArgs e)
        {
            ManagerList();
        }

        private void btnManagerDelete_Click(object sender, EventArgs e)
        {
            if (txtManagerId.Text != "")
            {
                int id = Convert.ToInt32(txtManagerId.Text);
                var x = db.Manager.Find(id);
                x.ManagerIsActive = false;

                db.SaveChanges();
                XtraMessageBox.Show("Müdür Silme İşlemi Başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ManagerList();
            }
            else
            {
                XtraMessageBox.Show("Müdür Silme İşlemi Başarısız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //   MessageBox.Show("Müdür Silme İşlemi Başarısız.");
            }
        }

        private void btnManagerUpdate_Click(object sender, EventArgs e)
        {

            if (txtManagerId.Text != "")
            {
                int id = Convert.ToInt32(txtManagerId.Text);
                var x = db.Manager.Find(id);
                x.ManagerName = txtManagerName.Text;
                x.ManagerSurname = txtManagerSurname.Text;
                x.ManagerUsername = txtManagerUsername.Text;
                x.ManagerPassword = txtManagerPassword.Text;

                db.SaveChanges();
                XtraMessageBox.Show("Müdür Güncelleme İşlemi Başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ManagerList();

            }
            else
            {
                XtraMessageBox.Show("Müdür Güncelleme İşlemi Başarısız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnManagerAdd_Click(object sender, EventArgs e)
        {
            if (txtManagerName.Text != "")
            {
                Manager manager = new Manager();

                manager.ManagerName = txtManagerName.Text;
                manager.ManagerSurname = txtManagerSurname.Text;
                manager.ManagerUsername = txtManagerUsername.Text;
                manager.ManagerPassword = txtManagerPassword.Text;
                manager.ManagerIsActive = true;
                db.Manager.Add(manager);
                db.SaveChanges();
                XtraMessageBox.Show("Müdür Ekleme İşlemi Başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ManagerList();


            }
            else
            {
                XtraMessageBox.Show("Müdür Ekleme İşlemi Başarısız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //   txtManagerId.Text = (gridView1.GetRowCellValue(index, "Id").ToString());
            txtManagerId.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString());
            txtManagerName.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
            txtManagerSurname.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();
            txtManagerUsername.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3]).ToString();
            txtManagerPassword.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[4]).ToString();
        }

        private void btnClass_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClassFormcs classForm = new ClassFormcs();
            classForm.Show();
        }

        private void btnexportpdf_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string hedefKlasor = folderBrowserDialog1.SelectedPath.ToString();
                gridControl1.ExportToPdf(hedefKlasor + "\\managers.Pdf");
            }
            else
            {
                MessageBox.Show("Dosyanın Kopyalanacağı Klasörü Seçmediniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


    }

}