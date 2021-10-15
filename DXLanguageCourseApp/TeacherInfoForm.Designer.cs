
namespace DXLanguageCourseApp
{
    partial class TeacherInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherInfoForm));
            this.txtTeachersPassword = new System.Windows.Forms.TextBox();
            this.txtTeachersUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTeachersSurname = new System.Windows.Forms.TextBox();
            this.txtTeachersName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTeachersId = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnTeacherUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTeachersPassword
            // 
            this.txtTeachersPassword.Location = new System.Drawing.Point(208, 210);
            this.txtTeachersPassword.Name = "txtTeachersPassword";
            this.txtTeachersPassword.Size = new System.Drawing.Size(155, 23);
            this.txtTeachersPassword.TabIndex = 47;
            // 
            // txtTeachersUsername
            // 
            this.txtTeachersUsername.Location = new System.Drawing.Point(208, 171);
            this.txtTeachersUsername.Name = "txtTeachersUsername";
            this.txtTeachersUsername.Size = new System.Drawing.Size(155, 23);
            this.txtTeachersUsername.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "Şifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Kullanıcı Adı:";
            // 
            // txtTeachersSurname
            // 
            this.txtTeachersSurname.Enabled = false;
            this.txtTeachersSurname.Location = new System.Drawing.Point(208, 128);
            this.txtTeachersSurname.Name = "txtTeachersSurname";
            this.txtTeachersSurname.Size = new System.Drawing.Size(155, 23);
            this.txtTeachersSurname.TabIndex = 41;
            // 
            // txtTeachersName
            // 
            this.txtTeachersName.Enabled = false;
            this.txtTeachersName.Location = new System.Drawing.Point(208, 89);
            this.txtTeachersName.Name = "txtTeachersName";
            this.txtTeachersName.Size = new System.Drawing.Size(155, 23);
            this.txtTeachersName.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Öğretmen Soyadı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(70, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 17);
            this.label10.TabIndex = 38;
            this.label10.Text = "Öğretmen Adı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 17);
            this.label11.TabIndex = 42;
            this.label11.Text = "Öğretmen Id:";
            // 
            // txtTeachersId
            // 
            this.txtTeachersId.Enabled = false;
            this.txtTeachersId.Location = new System.Drawing.Point(208, 54);
            this.txtTeachersId.Name = "txtTeachersId";
            this.txtTeachersId.Size = new System.Drawing.Size(155, 23);
            this.txtTeachersId.TabIndex = 43;
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.btnTeacherUpdate);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.txtTeachersPassword);
            this.groupControl1.Controls.Add(this.txtTeachersUsername);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.txtTeachersId);
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.txtTeachersSurname);
            this.groupControl1.Controls.Add(this.txtTeachersName);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Location = new System.Drawing.Point(195, 19);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(427, 374);
            this.groupControl1.TabIndex = 49;
            this.groupControl1.Text = "Bilgilerim";
            // 
            // btnTeacherUpdate
            // 
            this.btnTeacherUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTeacherUpdate.ImageOptions.Image")));
            this.btnTeacherUpdate.Location = new System.Drawing.Point(208, 290);
            this.btnTeacherUpdate.Name = "btnTeacherUpdate";
            this.btnTeacherUpdate.Size = new System.Drawing.Size(127, 59);
            this.btnTeacherUpdate.TabIndex = 50;
            this.btnTeacherUpdate.Text = "Güncelle";
            this.btnTeacherUpdate.Click += new System.EventHandler(this.btnTeacherUpdate_Click_1);
            // 
            // groupControl2
            // 
            this.groupControl2.Location = new System.Drawing.Point(424, 1);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(200, 100);
            this.groupControl2.TabIndex = 49;
            this.groupControl2.Text = "groupControl2";
            // 
            // TeacherInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupControl1);
            this.Name = "TeacherInfoForm";
            this.Text = "Bilgilerim";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TextBox txtTeachersPassword;
        public System.Windows.Forms.TextBox txtTeachersUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtTeachersSurname;
        public System.Windows.Forms.TextBox txtTeachersName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtTeachersId;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnTeacherUpdate;
    }
}