namespace TamperResistantProgram
{
    partial class VersionInfoForm
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
            this.pbxAppIcon = new System.Windows.Forms.PictureBox();
            this.lblAppCompanyProductName = new System.Windows.Forms.Label();
            this.lblAppVersion = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblAppDescription = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAppIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxAppIcon
            // 
            this.pbxAppIcon.Location = new System.Drawing.Point(8, 24);
            this.pbxAppIcon.Name = "pbxAppIcon";
            this.pbxAppIcon.Size = new System.Drawing.Size(32, 32);
            this.pbxAppIcon.TabIndex = 0;
            this.pbxAppIcon.TabStop = false;
            // 
            // lblAppCompanyProductName
            // 
            this.lblAppCompanyProductName.AutoSize = true;
            this.lblAppCompanyProductName.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblAppCompanyProductName.Location = new System.Drawing.Point(64, 24);
            this.lblAppCompanyProductName.Name = "lblAppCompanyProductName";
            this.lblAppCompanyProductName.Size = new System.Drawing.Size(164, 18);
            this.lblAppCompanyProductName.TabIndex = 1;
            this.lblAppCompanyProductName.Text = "AppCompanyProductName";
            // 
            // lblAppVersion
            // 
            this.lblAppVersion.AutoSize = true;
            this.lblAppVersion.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblAppVersion.Location = new System.Drawing.Point(64, 48);
            this.lblAppVersion.Name = "lblAppVersion";
            this.lblAppVersion.Size = new System.Drawing.Size(72, 18);
            this.lblAppVersion.TabIndex = 2;
            this.lblAppVersion.Text = "AppVersion";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCopyright.Location = new System.Drawing.Point(64, 72);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(64, 18);
            this.lblCopyright.TabIndex = 3;
            this.lblCopyright.Text = "Copyright";
            // 
            // lblAppDescription
            // 
            this.lblAppDescription.AutoSize = true;
            this.lblAppDescription.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblAppDescription.Location = new System.Drawing.Point(64, 96);
            this.lblAppDescription.Name = "lblAppDescription";
            this.lblAppDescription.Size = new System.Drawing.Size(95, 18);
            this.lblAppDescription.TabIndex = 4;
            this.lblAppDescription.Text = "AppDescription";
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnOk.Location = new System.Drawing.Point(280, 136);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // VersionInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 174);
            this.ControlBox = false;
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblAppDescription);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblAppVersion);
            this.Controls.Add(this.lblAppCompanyProductName);
            this.Controls.Add(this.pbxAppIcon);
            this.Name = "VersionInfoForm";
            this.Text = "VersionInfoForm";
            this.Load += new System.EventHandler(this.VersionInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAppIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxAppIcon;
        private System.Windows.Forms.Label lblAppCompanyProductName;
        private System.Windows.Forms.Label lblAppVersion;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblAppDescription;
        private System.Windows.Forms.Button btnOk;
    }
}