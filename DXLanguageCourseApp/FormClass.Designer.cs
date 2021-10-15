
namespace DXLanguageCourseApp
{
    partial class FormClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClass));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGradeId = new System.Windows.Forms.TextBox();
            this.txtGrade1 = new System.Windows.Forms.TextBox();
            this.txtGrade2 = new System.Windows.Forms.TextBox();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnClassDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnClassUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnClassAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lupStudentName = new DevExpress.XtraEditors.LookUpEdit();
            this.lupClasses = new DevExpress.XtraEditors.LookUpEdit();
            this.txtStudentAbsenteeism = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnexportpdf = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupStudentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupClasses.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Not Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Öğrenci:";
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "İkinci Not:";
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Birinci Not:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(113, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Sınıf:";
            // 
            // txtGradeId
            // 
            this.txtGradeId.Enabled = false;
            this.txtGradeId.Location = new System.Drawing.Point(212, 45);
            this.txtGradeId.Name = "txtGradeId";
            this.txtGradeId.Size = new System.Drawing.Size(158, 23);
            this.txtGradeId.TabIndex = 8;
            // 
            // txtGrade1
            // 
            this.txtGrade1.Location = new System.Drawing.Point(212, 227);
            this.txtGrade1.Name = "txtGrade1";
            this.txtGrade1.Size = new System.Drawing.Size(158, 23);
            this.txtGrade1.TabIndex = 8;
            this.txtGrade1.Text = "0";
            // 
            // txtGrade2
            // 
            this.txtGrade2.Location = new System.Drawing.Point(212, 279);
            this.txtGrade2.Name = "txtGrade2";
            this.txtGrade2.Size = new System.Drawing.Size(158, 23);
            this.txtGrade2.TabIndex = 8;
            this.txtGrade2.Text = "0";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // btnClassDelete
            // 
            this.btnClassDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClassDelete.ImageOptions.Image")));
            this.btnClassDelete.Location = new System.Drawing.Point(337, 396);
            this.btnClassDelete.Name = "btnClassDelete";
            this.btnClassDelete.Size = new System.Drawing.Size(107, 46);
            this.btnClassDelete.TabIndex = 67;
            this.btnClassDelete.Text = "Sil";
            this.btnClassDelete.Click += new System.EventHandler(this.btnClassDelete_Click);
            // 
            // btnClassUpdate
            // 
            this.btnClassUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClassUpdate.ImageOptions.Image")));
            this.btnClassUpdate.Location = new System.Drawing.Point(195, 396);
            this.btnClassUpdate.Name = "btnClassUpdate";
            this.btnClassUpdate.Size = new System.Drawing.Size(107, 46);
            this.btnClassUpdate.TabIndex = 66;
            this.btnClassUpdate.Text = "Güncelle";
            this.btnClassUpdate.Click += new System.EventHandler(this.btnClassUpdate_Click);
            // 
            // btnClassAdd
            // 
            this.btnClassAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClassAdd.ImageOptions.Image")));
            this.btnClassAdd.Location = new System.Drawing.Point(58, 396);
            this.btnClassAdd.Name = "btnClassAdd";
            this.btnClassAdd.Size = new System.Drawing.Size(107, 46);
            this.btnClassAdd.TabIndex = 65;
            this.btnClassAdd.Text = "Ekle";
            this.btnClassAdd.Click += new System.EventHandler(this.btnClassAdd_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 41);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(937, 446);
            this.gridControl1.TabIndex = 68;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // lupStudentName
            // 
            this.lupStudentName.Location = new System.Drawing.Point(212, 87);
            this.lupStudentName.Name = "lupStudentName";
            this.lupStudentName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupStudentName.Size = new System.Drawing.Size(158, 22);
            this.lupStudentName.TabIndex = 69;
            // 
            // lupClasses
            // 
            this.lupClasses.Location = new System.Drawing.Point(212, 131);
            this.lupClasses.Name = "lupClasses";
            this.lupClasses.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupClasses.Size = new System.Drawing.Size(158, 22);
            this.lupClasses.TabIndex = 70;
            // 
            // txtStudentAbsenteeism
            // 
            this.txtStudentAbsenteeism.Location = new System.Drawing.Point(212, 185);
            this.txtStudentAbsenteeism.Name = "txtStudentAbsenteeism";
            this.txtStudentAbsenteeism.Size = new System.Drawing.Size(158, 23);
            this.txtStudentAbsenteeism.TabIndex = 72;
            this.txtStudentAbsenteeism.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 71;
            this.label3.Text = "Devamsızlık:";
            // 
            // btnexportpdf
            // 
            this.btnexportpdf.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnexportpdf.ImageOptions.Image")));
            this.btnexportpdf.Location = new System.Drawing.Point(195, 457);
            this.btnexportpdf.Name = "btnexportpdf";
            this.btnexportpdf.Size = new System.Drawing.Size(107, 46);
            this.btnexportpdf.TabIndex = 100;
            this.btnexportpdf.Text = "PDF";
            this.btnexportpdf.Click += new System.EventHandler(this.btnexportpdf_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.btnexportpdf);
            this.groupControl1.Controls.Add(this.txtStudentAbsenteeism);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.lupClasses);
            this.groupControl1.Controls.Add(this.lupStudentName);
            this.groupControl1.Controls.Add(this.btnClassDelete);
            this.groupControl1.Controls.Add(this.btnClassUpdate);
            this.groupControl1.Controls.Add(this.btnClassAdd);
            this.groupControl1.Controls.Add(this.txtGrade2);
            this.groupControl1.Controls.Add(this.txtGrade1);
            this.groupControl1.Controls.Add(this.txtGradeId);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(967, 28);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(489, 555);
            this.groupControl1.TabIndex = 101;
            this.groupControl1.Text = "Öğrenci Bilgileri";
            // 
            // FormClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1530, 671);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FormClass";
            this.Text = "FormClass";
            this.Load += new System.EventHandler(this.FormClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupStudentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupClasses.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGradeId;
        private System.Windows.Forms.TextBox txtGrade1;
        private System.Windows.Forms.TextBox txtGrade2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.SimpleButton btnClassDelete;
        private DevExpress.XtraEditors.SimpleButton btnClassUpdate;
        private DevExpress.XtraEditors.SimpleButton btnClassAdd;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LookUpEdit lupStudentName;
        private DevExpress.XtraEditors.LookUpEdit lupClasses;
        private System.Windows.Forms.TextBox txtStudentAbsenteeism;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnexportpdf;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}