
namespace DXLanguageCourseApp
{
    partial class ClassFormcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassFormcs));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lupTeacher = new DevExpress.XtraEditors.LookUpEdit();
            this.btnClassDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnClassUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnClassAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtClassId = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnexportpdf = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lupTeacher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.btnexportpdf);
            this.groupControl1.Controls.Add(this.lupTeacher);
            this.groupControl1.Controls.Add(this.btnClassDelete);
            this.groupControl1.Controls.Add(this.btnClassUpdate);
            this.groupControl1.Controls.Add(this.btnClassAdd);
            this.groupControl1.Controls.Add(this.txtClassId);
            this.groupControl1.Controls.Add(this.txtClassName);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Location = new System.Drawing.Point(872, 29);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(542, 453);
            this.groupControl1.TabIndex = 62;
            this.groupControl1.Text = "Öğrenci Bilgileri";
            // 
            // lupTeacher
            // 
            this.lupTeacher.EditValue = "";
            this.lupTeacher.Location = new System.Drawing.Point(183, 160);
            this.lupTeacher.Name = "lupTeacher";
            this.lupTeacher.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupTeacher.Size = new System.Drawing.Size(201, 22);
            this.lupTeacher.TabIndex = 60;
            // 
            // btnClassDelete
            // 
            this.btnClassDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClassDelete.ImageOptions.Image")));
            this.btnClassDelete.Location = new System.Drawing.Point(321, 267);
            this.btnClassDelete.Name = "btnClassDelete";
            this.btnClassDelete.Size = new System.Drawing.Size(122, 46);
            this.btnClassDelete.TabIndex = 59;
            this.btnClassDelete.Text = "Sil";
            this.btnClassDelete.Click += new System.EventHandler(this.btnClassDelete_Click);
            // 
            // btnClassUpdate
            // 
            this.btnClassUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClassUpdate.ImageOptions.Image")));
            this.btnClassUpdate.Location = new System.Drawing.Point(183, 267);
            this.btnClassUpdate.Name = "btnClassUpdate";
            this.btnClassUpdate.Size = new System.Drawing.Size(122, 46);
            this.btnClassUpdate.TabIndex = 58;
            this.btnClassUpdate.Text = "Güncelle";
            this.btnClassUpdate.Click += new System.EventHandler(this.btnClassUpdate_Click);
            // 
            // btnClassAdd
            // 
            this.btnClassAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClassAdd.ImageOptions.Image")));
            this.btnClassAdd.Location = new System.Drawing.Point(38, 267);
            this.btnClassAdd.Name = "btnClassAdd";
            this.btnClassAdd.Size = new System.Drawing.Size(122, 46);
            this.btnClassAdd.TabIndex = 57;
            this.btnClassAdd.Text = "Ekle";
            this.btnClassAdd.Click += new System.EventHandler(this.btnClassAdd_Click);
            // 
            // txtClassId
            // 
            this.txtClassId.Enabled = false;
            this.txtClassId.Location = new System.Drawing.Point(180, 63);
            this.txtClassId.Name = "txtClassId";
            this.txtClassId.Size = new System.Drawing.Size(204, 23);
            this.txtClassId.TabIndex = 52;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(180, 111);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(204, 23);
            this.txtClassName.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "Öğretmen:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 50;
            this.label9.Text = "Ders Adı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 51;
            this.label10.Text = "Ders ID:";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(46, 29);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(754, 418);
            this.gridControl1.TabIndex = 61;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // btnexportpdf
            // 
            this.btnexportpdf.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnexportpdf.ImageOptions.Image")));
            this.btnexportpdf.Location = new System.Drawing.Point(183, 344);
            this.btnexportpdf.Name = "btnexportpdf";
            this.btnexportpdf.Size = new System.Drawing.Size(122, 46);
            this.btnexportpdf.TabIndex = 100;
            this.btnexportpdf.Text = "PDF";
            this.btnexportpdf.Click += new System.EventHandler(this.btnexportpdf_Click);
            // 
            // ClassFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 563);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "ClassFormcs";
            this.Text = "ClassFormcs";
            this.Load += new System.EventHandler(this.ClassFormcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lupTeacher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnClassDelete;
        private DevExpress.XtraEditors.SimpleButton btnClassUpdate;
        private DevExpress.XtraEditors.SimpleButton btnClassAdd;
        private System.Windows.Forms.TextBox txtClassId;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LookUpEdit lupTeacher;
        private DevExpress.XtraEditors.SimpleButton btnexportpdf;
    }
}