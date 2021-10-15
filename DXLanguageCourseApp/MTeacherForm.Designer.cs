
namespace DXLanguageCourseApp
{
    partial class MTeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MTeacherForm));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtTeacherId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTeacherSurname = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnTeacherAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnTeacherUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnTeacherDelete = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnexportpdf = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 23);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(653, 422);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // txtTeacherId
            // 
            this.txtTeacherId.Enabled = false;
            this.txtTeacherId.Location = new System.Drawing.Point(209, 59);
            this.txtTeacherId.Name = "txtTeacherId";
            this.txtTeacherId.Size = new System.Drawing.Size(172, 23);
            this.txtTeacherId.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(111, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 17);
            this.label13.TabIndex = 28;
            this.label13.Text = "Soyad:";
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(209, 107);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(172, 23);
            this.txtTeacherName.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(111, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 17);
            this.label14.TabIndex = 29;
            this.label14.Text = "Ad:";
            // 
            // txtTeacherSurname
            // 
            this.txtTeacherSurname.Location = new System.Drawing.Point(209, 154);
            this.txtTeacherSurname.Name = "txtTeacherSurname";
            this.txtTeacherSurname.Size = new System.Drawing.Size(172, 23);
            this.txtTeacherSurname.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(111, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 17);
            this.label15.TabIndex = 30;
            this.label15.Text = "Öğretmen ID:";
            // 
            // btnTeacherAdd
            // 
            this.btnTeacherAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTeacherAdd.ImageOptions.Image")));
            this.btnTeacherAdd.Location = new System.Drawing.Point(44, 248);
            this.btnTeacherAdd.Name = "btnTeacherAdd";
            this.btnTeacherAdd.Size = new System.Drawing.Size(119, 54);
            this.btnTeacherAdd.TabIndex = 34;
            this.btnTeacherAdd.Text = "Ekle";
            this.btnTeacherAdd.Click += new System.EventHandler(this.btnTeacherAdd_Click);
            // 
            // btnTeacherUpdate
            // 
            this.btnTeacherUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTeacherUpdate.ImageOptions.Image")));
            this.btnTeacherUpdate.Location = new System.Drawing.Point(205, 248);
            this.btnTeacherUpdate.Name = "btnTeacherUpdate";
            this.btnTeacherUpdate.Size = new System.Drawing.Size(119, 54);
            this.btnTeacherUpdate.TabIndex = 35;
            this.btnTeacherUpdate.Text = "Güncelle";
            this.btnTeacherUpdate.Click += new System.EventHandler(this.btnTeacherUpdate_Click);
            // 
            // btnTeacherDelete
            // 
            this.btnTeacherDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTeacherDelete.ImageOptions.Image")));
            this.btnTeacherDelete.Location = new System.Drawing.Point(358, 248);
            this.btnTeacherDelete.Name = "btnTeacherDelete";
            this.btnTeacherDelete.Size = new System.Drawing.Size(119, 54);
            this.btnTeacherDelete.TabIndex = 36;
            this.btnTeacherDelete.Text = "Sil";
            this.btnTeacherDelete.Click += new System.EventHandler(this.btnTeacherDelete_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.btnexportpdf);
            this.groupControl1.Controls.Add(this.btnTeacherDelete);
            this.groupControl1.Controls.Add(this.btnTeacherUpdate);
            this.groupControl1.Controls.Add(this.btnTeacherAdd);
            this.groupControl1.Controls.Add(this.txtTeacherId);
            this.groupControl1.Controls.Add(this.label13);
            this.groupControl1.Controls.Add(this.txtTeacherName);
            this.groupControl1.Controls.Add(this.label14);
            this.groupControl1.Controls.Add(this.txtTeacherSurname);
            this.groupControl1.Controls.Add(this.label15);
            this.groupControl1.Location = new System.Drawing.Point(724, 23);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(496, 422);
            this.groupControl1.TabIndex = 37;
            this.groupControl1.Text = "Öğretmen Bilgileri";
            // 
            // btnexportpdf
            // 
            this.btnexportpdf.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnexportpdf.ImageOptions.Image")));
            this.btnexportpdf.Location = new System.Drawing.Point(205, 333);
            this.btnexportpdf.Name = "btnexportpdf";
            this.btnexportpdf.Size = new System.Drawing.Size(119, 54);
            this.btnexportpdf.TabIndex = 101;
            this.btnexportpdf.Text = "PDF";
            this.btnexportpdf.Click += new System.EventHandler(this.btnexportpdf_Click);
            // 
            // MTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 532);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "MTeacherForm";
            this.Text = "MTeacherForm";
            this.Load += new System.EventHandler(this.MTeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox txtTeacherId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTeacherSurname;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraEditors.SimpleButton btnTeacherAdd;
        private DevExpress.XtraEditors.SimpleButton btnTeacherUpdate;
        private DevExpress.XtraEditors.SimpleButton btnTeacherDelete;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnexportpdf;
    }
}