using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXLanguageCourseApp
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
      //  string a = "";
        public Form1()
        {
            InitializeComponent();
            
        }
        DbLCEntities db = new DbLCEntities();
        private void btnListele_Click(object sender, EventArgs e)
        {
          
            gridControl1.DataSource = db.Manager.ToList();
           // gridView1.Columns[2].Visible = false;
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            var x = db.Manager.Find(id);
            x.ManagerName = txtad.Text;
            x.ManagerSurname = txtsad.Text;
            db.SaveChanges();
            
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            txtId.Text = (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString());
        }
    }
}
