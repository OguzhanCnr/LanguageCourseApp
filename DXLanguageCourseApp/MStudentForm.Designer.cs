
namespace DXLanguageCourseApp
{
    partial class MStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MStudentForm));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentSurname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnStudentDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnStudentUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnStudentAdd = new DevExpress.XtraEditors.SimpleButton();
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
            this.gridControl1.Location = new System.Drawing.Point(28, 40);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(754, 467);
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
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point(183, 237);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(204, 23);
            this.txtStudentNumber.TabIndex = 55;
            this.txtStudentNumber.Text = "0";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Enabled = false;
            this.txtStudentId.Location = new System.Drawing.Point(183, 92);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(204, 23);
            this.txtStudentId.TabIndex = 52;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(183, 140);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(204, 23);
            this.txtStudentName.TabIndex = 53;
            // 
            // txtStudentSurname
            // 
            this.txtStudentSurname.Location = new System.Drawing.Point(183, 187);
            this.txtStudentSurname.Name = "txtStudentSurname";
            this.txtStudentSurname.Size = new System.Drawing.Size(204, 23);
            this.txtStudentSurname.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 47;
            this.label6.Text = "Numara:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "Soyad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 17);
            this.label9.TabIndex = 50;
            this.label9.Text = "Ad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 51;
            this.label10.Text = "Öğrenci ID:";
            // 
            // btnStudentDelete
            // 
            this.btnStudentDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentDelete.ImageOptions.Image")));
            this.btnStudentDelete.Location = new System.Drawing.Point(358, 347);
            this.btnStudentDelete.Name = "btnStudentDelete";
            this.btnStudentDelete.Size = new System.Drawing.Size(117, 46);
            this.btnStudentDelete.TabIndex = 59;
            this.btnStudentDelete.Text = "Sil";
            this.btnStudentDelete.Click += new System.EventHandler(this.btnStudentDelete_Click);
            // 
            // btnStudentUpdate
            // 
            this.btnStudentUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentUpdate.ImageOptions.Image")));
            this.btnStudentUpdate.Location = new System.Drawing.Point(202, 347);
            this.btnStudentUpdate.Name = "btnStudentUpdate";
            this.btnStudentUpdate.Size = new System.Drawing.Size(117, 46);
            this.btnStudentUpdate.TabIndex = 58;
            this.btnStudentUpdate.Text = "Güncelle";
            this.btnStudentUpdate.Click += new System.EventHandler(this.btnStudentUpdate_Click);
            // 
            // btnStudentAdd
            // 
            this.btnStudentAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentAdd.ImageOptions.Image")));
            this.btnStudentAdd.Location = new System.Drawing.Point(48, 347);
            this.btnStudentAdd.Name = "btnStudentAdd";
            this.btnStudentAdd.Size = new System.Drawing.Size(117, 46);
            this.btnStudentAdd.TabIndex = 57;
            this.btnStudentAdd.Text = "Ekle";
            this.btnStudentAdd.Click += new System.EventHandler(this.btnStudentAdd_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.btnexportpdf);
            this.groupControl1.Controls.Add(this.btnStudentDelete);
            this.groupControl1.Controls.Add(this.btnStudentUpdate);
            this.groupControl1.Controls.Add(this.btnStudentAdd);
            this.groupControl1.Controls.Add(this.txtStudentNumber);
            this.groupControl1.Controls.Add(this.txtStudentId);
            this.groupControl1.Controls.Add(this.txtStudentName);
            this.groupControl1.Controls.Add(this.txtStudentSurname);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Location = new System.Drawing.Point(854, 40);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(501, 467);
            this.groupControl1.TabIndex = 60;
            this.groupControl1.Text = "Öğrenci Bilgileri";
            // 
            // btnexportpdf
            // 
            this.btnexportpdf.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnexportpdf.ImageOptions.Image")));
            this.btnexportpdf.Location = new System.Drawing.Point(202, 416);
            this.btnexportpdf.Name = "btnexportpdf";
            this.btnexportpdf.Size = new System.Drawing.Size(117, 46);
            this.btnexportpdf.TabIndex = 100;
            this.btnexportpdf.Text = "PDF";
            this.btnexportpdf.Click += new System.EventHandler(this.btnexportpdf_Click);
            // 
            // MStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 634);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "MStudentForm";
            this.Text = "MStudentForm";
            this.Load += new System.EventHandler(this.MStudentForm_Load);
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
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentSurname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SimpleButton btnStudentDelete;
        private DevExpress.XtraEditors.SimpleButton btnStudentUpdate;
        private DevExpress.XtraEditors.SimpleButton btnStudentAdd;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnexportpdf;
    }
}