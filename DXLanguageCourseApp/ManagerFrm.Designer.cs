
namespace DXLanguageCourseApp
{
    partial class ManagerFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerFrm));
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnManager = new DevExpress.XtraBars.BarButtonItem();
            this.btnStudent = new DevExpress.XtraBars.BarButtonItem();
            this.btnTeacher = new DevExpress.XtraBars.BarButtonItem();
            this.btnManagerList = new DevExpress.XtraBars.BarButtonItem();
            this.btnStudentList = new DevExpress.XtraBars.BarButtonItem();
            this.btnTeacherList = new DevExpress.XtraBars.BarButtonItem();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnClassList = new DevExpress.XtraBars.BarButtonItem();
            this.btnPdf = new DevExpress.XtraBars.BarButtonItem();
            this.btnClass = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtManagerUsername = new System.Windows.Forms.TextBox();
            this.btnManagerDelete = new DevExpress.XtraEditors.SimpleButton();
            this.txtManagerPassword = new System.Windows.Forms.TextBox();
            this.btnManagerUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.txtManagerId = new System.Windows.Forms.TextBox();
            this.btnManagerAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtManagerName = new System.Windows.Forms.TextBox();
            this.txtManagerSurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnexportpdf = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 796);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1257, 30);
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnManager,
            this.btnStudent,
            this.btnTeacher,
            this.btnManagerList,
            this.btnStudentList,
            this.btnTeacherList,
            this.btnAdd,
            this.btnDelete,
            this.btnUpdate,
            this.btnClassList,
            this.btnPdf,
            this.btnClass});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 13;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1257, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnManager
            // 
            this.btnManager.Caption = "Manager";
            this.btnManager.Id = 1;
            this.btnManager.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnManager.ImageOptions.Image")));
            this.btnManager.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnManager.ImageOptions.LargeImage")));
            this.btnManager.Name = "btnManager";
            // 
            // btnStudent
            // 
            this.btnStudent.Caption = "Students";
            this.btnStudent.Id = 2;
            this.btnStudent.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStudent.ImageOptions.Image")));
            this.btnStudent.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnStudent.ImageOptions.LargeImage")));
            this.btnStudent.Name = "btnStudent";
            // 
            // btnTeacher
            // 
            this.btnTeacher.Caption = "Teachers";
            this.btnTeacher.Id = 3;
            this.btnTeacher.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTeacher.ImageOptions.Image")));
            this.btnTeacher.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTeacher.ImageOptions.LargeImage")));
            this.btnTeacher.Name = "btnTeacher";
            // 
            // btnManagerList
            // 
            this.btnManagerList.Caption = "Müdür Listele";
            this.btnManagerList.Id = 4;
            this.btnManagerList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnManagerList.ImageOptions.Image")));
            this.btnManagerList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnManagerList.ImageOptions.LargeImage")));
            this.btnManagerList.Name = "btnManagerList";
            // 
            // btnStudentList
            // 
            this.btnStudentList.Caption = "Öğrenci Listele";
            this.btnStudentList.Id = 5;
            this.btnStudentList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentList.ImageOptions.Image")));
            this.btnStudentList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnStudentList.ImageOptions.LargeImage")));
            this.btnStudentList.Name = "btnStudentList";
            this.btnStudentList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStudentList_ItemClick);
            // 
            // btnTeacherList
            // 
            this.btnTeacherList.Caption = "Öğretmen Listele";
            this.btnTeacherList.Id = 6;
            this.btnTeacherList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTeacherList.ImageOptions.Image")));
            this.btnTeacherList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTeacherList.ImageOptions.LargeImage")));
            this.btnTeacherList.Name = "btnTeacherList";
            this.btnTeacherList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTeacherList_ItemClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Ekle";
            this.btnAdd.Id = 7;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.LargeImage")));
            this.btnAdd.Name = "btnAdd";
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Sil";
            this.btnDelete.Id = 8;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.LargeImage")));
            this.btnDelete.Name = "btnDelete";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Güncelle";
            this.btnUpdate.Id = 9;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.LargeImage")));
            this.btnUpdate.Name = "btnUpdate";
            // 
            // btnClassList
            // 
            this.btnClassList.Caption = "Dersleri Listele";
            this.btnClassList.Id = 10;
            this.btnClassList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClassList.ImageOptions.Image")));
            this.btnClassList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnClassList.ImageOptions.LargeImage")));
            this.btnClassList.Name = "btnClassList";
            this.btnClassList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClassFrm_ItemClick);
            // 
            // btnPdf
            // 
            this.btnPdf.Caption = "Çıktı Al";
            this.btnPdf.Id = 11;
            this.btnPdf.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPdf.ImageOptions.Image")));
            this.btnPdf.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPdf.ImageOptions.LargeImage")));
            this.btnPdf.Name = "btnPdf";
            // 
            // btnClass
            // 
            this.btnClass.Caption = "Dersler";
            this.btnClass.Id = 12;
            this.btnClass.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClass.ImageOptions.Image")));
            this.btnClass.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnClass.ImageOptions.LargeImage")));
            this.btnClass.Name = "btnClass";
            this.btnClass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClass_ItemClick);
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Text = "ribbonPageCategory1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnStudentList);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTeacherList);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnClassList);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnClass);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(38, 211);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(649, 403);
            this.gridControl1.TabIndex = 65;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // txtManagerUsername
            // 
            this.txtManagerUsername.Location = new System.Drawing.Point(197, 197);
            this.txtManagerUsername.Name = "txtManagerUsername";
            this.txtManagerUsername.Size = new System.Drawing.Size(187, 23);
            this.txtManagerUsername.TabIndex = 94;
            // 
            // btnManagerDelete
            // 
            this.btnManagerDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnManagerDelete.ImageOptions.Image")));
            this.btnManagerDelete.Location = new System.Drawing.Point(351, 310);
            this.btnManagerDelete.Name = "btnManagerDelete";
            this.btnManagerDelete.Size = new System.Drawing.Size(94, 58);
            this.btnManagerDelete.TabIndex = 98;
            this.btnManagerDelete.Text = "Sil";
            this.btnManagerDelete.Click += new System.EventHandler(this.btnManagerDelete_Click);
            // 
            // txtManagerPassword
            // 
            this.txtManagerPassword.Location = new System.Drawing.Point(198, 250);
            this.txtManagerPassword.Name = "txtManagerPassword";
            this.txtManagerPassword.Size = new System.Drawing.Size(187, 23);
            this.txtManagerPassword.TabIndex = 95;
            // 
            // btnManagerUpdate
            // 
            this.btnManagerUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnManagerUpdate.ImageOptions.Image")));
            this.btnManagerUpdate.Location = new System.Drawing.Point(198, 310);
            this.btnManagerUpdate.Name = "btnManagerUpdate";
            this.btnManagerUpdate.Size = new System.Drawing.Size(94, 58);
            this.btnManagerUpdate.TabIndex = 97;
            this.btnManagerUpdate.Text = "Güncelle";
            this.btnManagerUpdate.Click += new System.EventHandler(this.btnManagerUpdate_Click);
            // 
            // txtManagerId
            // 
            this.txtManagerId.Enabled = false;
            this.txtManagerId.Location = new System.Drawing.Point(197, 53);
            this.txtManagerId.Name = "txtManagerId";
            this.txtManagerId.Size = new System.Drawing.Size(187, 23);
            this.txtManagerId.TabIndex = 91;
            // 
            // btnManagerAdd
            // 
            this.btnManagerAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnManagerAdd.ImageOptions.Image")));
            this.btnManagerAdd.Location = new System.Drawing.Point(37, 310);
            this.btnManagerAdd.Name = "btnManagerAdd";
            this.btnManagerAdd.Size = new System.Drawing.Size(94, 58);
            this.btnManagerAdd.TabIndex = 96;
            this.btnManagerAdd.Text = "Ekle";
            this.btnManagerAdd.Click += new System.EventHandler(this.btnManagerAdd_Click);
            // 
            // txtManagerName
            // 
            this.txtManagerName.Location = new System.Drawing.Point(197, 101);
            this.txtManagerName.Name = "txtManagerName";
            this.txtManagerName.Size = new System.Drawing.Size(187, 23);
            this.txtManagerName.TabIndex = 92;
            // 
            // txtManagerSurname
            // 
            this.txtManagerSurname.Location = new System.Drawing.Point(197, 148);
            this.txtManagerSurname.Name = "txtManagerSurname";
            this.txtManagerSurname.Size = new System.Drawing.Size(187, 23);
            this.txtManagerSurname.TabIndex = 93;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 86;
            this.label5.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 87;
            this.label4.Text = "Kullanıcı adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 88;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 89;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 90;
            this.label1.Text = "Müdür ID:";
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.btnexportpdf);
            this.groupControl1.Controls.Add(this.txtManagerUsername);
            this.groupControl1.Controls.Add(this.btnManagerDelete);
            this.groupControl1.Controls.Add(this.txtManagerPassword);
            this.groupControl1.Controls.Add(this.btnManagerUpdate);
            this.groupControl1.Controls.Add(this.txtManagerId);
            this.groupControl1.Controls.Add(this.btnManagerAdd);
            this.groupControl1.Controls.Add(this.txtManagerName);
            this.groupControl1.Controls.Add(this.txtManagerSurname);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(736, 198);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(475, 473);
            this.groupControl1.TabIndex = 103;
            this.groupControl1.Text = "Müdür Bilgileri";
            // 
            // btnexportpdf
            // 
            this.btnexportpdf.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnexportpdf.ImageOptions.Image")));
            this.btnexportpdf.Location = new System.Drawing.Point(197, 410);
            this.btnexportpdf.Name = "btnexportpdf";
            this.btnexportpdf.Size = new System.Drawing.Size(94, 58);
            this.btnexportpdf.TabIndex = 99;
            this.btnexportpdf.Text = "PDF";
            this.btnexportpdf.Click += new System.EventHandler(this.btnexportpdf_Click);
            // 
            // ManagerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 826);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "ManagerFrm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "ManagerFrm";
            this.Load += new System.EventHandler(this.ManagerFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox txtManagerUsername;
        private DevExpress.XtraEditors.SimpleButton btnManagerDelete;
        private System.Windows.Forms.TextBox txtManagerPassword;
        private DevExpress.XtraEditors.SimpleButton btnManagerUpdate;
        private System.Windows.Forms.TextBox txtManagerId;
        private DevExpress.XtraEditors.SimpleButton btnManagerAdd;
        private System.Windows.Forms.TextBox txtManagerName;
        private System.Windows.Forms.TextBox txtManagerSurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem btnManager;
        private DevExpress.XtraBars.BarButtonItem btnStudent;
        private DevExpress.XtraBars.BarButtonItem btnTeacher;
        private DevExpress.XtraBars.BarButtonItem btnManagerList;
        private DevExpress.XtraBars.BarButtonItem btnStudentList;
        private DevExpress.XtraBars.BarButtonItem btnTeacherList;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnClassList;
        private DevExpress.XtraBars.BarButtonItem btnPdf;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.BarButtonItem btnClass;
        private DevExpress.XtraEditors.SimpleButton btnexportpdf;
    }
}