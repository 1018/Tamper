namespace TamperResistantProgram
{
    partial class SettingForm
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
            this.lblCurrentKey = new System.Windows.Forms.Label();
            this.lblNewKey = new System.Windows.Forms.Label();
            this.txtCurrentKey = new System.Windows.Forms.TextBox();
            this.txtNewKey = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxLogOut = new System.Windows.Forms.GroupBox();
            this.gbxExplanation = new System.Windows.Forms.GroupBox();
            this.lblExplanation = new System.Windows.Forms.Label();
            this.cbxWheel = new System.Windows.Forms.CheckBox();
            this.cbxLeave = new System.Windows.Forms.CheckBox();
            this.cbxHover = new System.Windows.Forms.CheckBox();
            this.cbxDown = new System.Windows.Forms.CheckBox();
            this.cbxDoubleClick = new System.Windows.Forms.CheckBox();
            this.cbxKey = new System.Windows.Forms.CheckBox();
            this.cbxClick = new System.Windows.Forms.CheckBox();
            this.gbxStopMonitoring = new System.Windows.Forms.GroupBox();
            this.gbxLogOut.SuspendLayout();
            this.gbxExplanation.SuspendLayout();
            this.gbxStopMonitoring.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurrentKey
            // 
            this.lblCurrentKey.AutoSize = true;
            this.lblCurrentKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCurrentKey.Location = new System.Drawing.Point(16, 24);
            this.lblCurrentKey.Name = "lblCurrentKey";
            this.lblCurrentKey.Size = new System.Drawing.Size(68, 18);
            this.lblCurrentKey.TabIndex = 101;
            this.lblCurrentKey.Text = "現在のキー";
            // 
            // lblNewKey
            // 
            this.lblNewKey.AutoSize = true;
            this.lblNewKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblNewKey.Location = new System.Drawing.Point(16, 48);
            this.lblNewKey.Name = "lblNewKey";
            this.lblNewKey.Size = new System.Drawing.Size(92, 18);
            this.lblNewKey.TabIndex = 102;
            this.lblNewKey.Text = "設定したいキー";
            // 
            // txtCurrentKey
            // 
            this.txtCurrentKey.Location = new System.Drawing.Point(128, 16);
            this.txtCurrentKey.Name = "txtCurrentKey";
            this.txtCurrentKey.ReadOnly = true;
            this.txtCurrentKey.Size = new System.Drawing.Size(100, 25);
            this.txtCurrentKey.TabIndex = 0;
            // 
            // txtNewKey
            // 
            this.txtNewKey.Location = new System.Drawing.Point(128, 48);
            this.txtNewKey.Name = "txtNewKey";
            this.txtNewKey.ReadOnly = true;
            this.txtNewKey.Size = new System.Drawing.Size(100, 25);
            this.txtNewKey.TabIndex = 1;
            this.txtNewKey.TextChanged += new System.EventHandler(this.txtNewKey_TextChanged);
            this.txtNewKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewKey_KeyDown);
            this.txtNewKey.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNewKey_KeyUp);
            // 
            // btnApply
            // 
            this.btnApply.Enabled = false;
            this.btnApply.ForeColor = System.Drawing.Color.Black;
            this.btnApply.Location = new System.Drawing.Point(64, 80);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(80, 23);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "適用";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(152, 80);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "キャンセル";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // gbxLogOut
            // 
            this.gbxLogOut.Controls.Add(this.gbxExplanation);
            this.gbxLogOut.Controls.Add(this.cbxWheel);
            this.gbxLogOut.Controls.Add(this.cbxLeave);
            this.gbxLogOut.Controls.Add(this.cbxHover);
            this.gbxLogOut.Controls.Add(this.cbxDown);
            this.gbxLogOut.Controls.Add(this.cbxDoubleClick);
            this.gbxLogOut.Controls.Add(this.cbxKey);
            this.gbxLogOut.Controls.Add(this.cbxClick);
            this.gbxLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbxLogOut.Location = new System.Drawing.Point(8, 136);
            this.gbxLogOut.Name = "gbxLogOut";
            this.gbxLogOut.Size = new System.Drawing.Size(376, 200);
            this.gbxLogOut.TabIndex = 103;
            this.gbxLogOut.TabStop = false;
            this.gbxLogOut.Text = "ログ出力項目";
            // 
            // gbxExplanation
            // 
            this.gbxExplanation.Controls.Add(this.lblExplanation);
            this.gbxExplanation.ForeColor = System.Drawing.Color.Silver;
            this.gbxExplanation.Location = new System.Drawing.Point(8, 128);
            this.gbxExplanation.Name = "gbxExplanation";
            this.gbxExplanation.Size = new System.Drawing.Size(360, 64);
            this.gbxExplanation.TabIndex = 104;
            this.gbxExplanation.TabStop = false;
            this.gbxExplanation.Text = "説明";
            // 
            // lblExplanation
            // 
            this.lblExplanation.Enabled = false;
            this.lblExplanation.ForeColor = System.Drawing.Color.Silver;
            this.lblExplanation.Location = new System.Drawing.Point(8, 16);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(328, 32);
            this.lblExplanation.TabIndex = 0;
            // 
            // cbxWheel
            // 
            this.cbxWheel.AutoSize = true;
            this.cbxWheel.Checked = true;
            this.cbxWheel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxWheel.Location = new System.Drawing.Point(208, 72);
            this.cbxWheel.Name = "cbxWheel";
            this.cbxWheel.Size = new System.Drawing.Size(159, 22);
            this.cbxWheel.TabIndex = 9;
            this.cbxWheel.Text = "マウスホイールイベント";
            this.cbxWheel.UseVisualStyleBackColor = true;
            this.cbxWheel.CheckedChanged += new System.EventHandler(this.cbxWheel_CheckedChanged);
            this.cbxWheel.MouseEnter += new System.EventHandler(this.cbxWheel_MouseEnter);
            this.cbxWheel.MouseLeave += new System.EventHandler(this.cbxWheel_MouseLeave);
            // 
            // cbxLeave
            // 
            this.cbxLeave.AutoSize = true;
            this.cbxLeave.Checked = true;
            this.cbxLeave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxLeave.Location = new System.Drawing.Point(208, 48);
            this.cbxLeave.Name = "cbxLeave";
            this.cbxLeave.Size = new System.Drawing.Size(147, 22);
            this.cbxLeave.TabIndex = 8;
            this.cbxLeave.Text = "マウスリーブイベント";
            this.cbxLeave.UseVisualStyleBackColor = true;
            this.cbxLeave.CheckedChanged += new System.EventHandler(this.cbxLeave_CheckedChanged);
            this.cbxLeave.MouseEnter += new System.EventHandler(this.cbxLeave_MouseEnter);
            this.cbxLeave.MouseLeave += new System.EventHandler(this.cbxLeave_MouseLeave);
            // 
            // cbxHover
            // 
            this.cbxHover.AutoSize = true;
            this.cbxHover.Checked = true;
            this.cbxHover.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxHover.Location = new System.Drawing.Point(208, 24);
            this.cbxHover.Name = "cbxHover";
            this.cbxHover.Size = new System.Drawing.Size(147, 22);
            this.cbxHover.TabIndex = 7;
            this.cbxHover.Text = "マウスホバーイベント";
            this.cbxHover.UseVisualStyleBackColor = true;
            this.cbxHover.CheckedChanged += new System.EventHandler(this.cbxHover_CheckedChanged);
            this.cbxHover.MouseEnter += new System.EventHandler(this.cbxHover_MouseEnter);
            this.cbxHover.MouseLeave += new System.EventHandler(this.cbxHover_MouseLeave);
            // 
            // cbxDown
            // 
            this.cbxDown.AutoSize = true;
            this.cbxDown.Checked = true;
            this.cbxDown.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxDown.Location = new System.Drawing.Point(16, 72);
            this.cbxDown.Name = "cbxDown";
            this.cbxDown.Size = new System.Drawing.Size(147, 22);
            this.cbxDown.TabIndex = 6;
            this.cbxDown.Text = "マウスダウンイベント";
            this.cbxDown.UseVisualStyleBackColor = true;
            this.cbxDown.CheckedChanged += new System.EventHandler(this.cbxDown_CheckedChanged);
            this.cbxDown.MouseEnter += new System.EventHandler(this.cbxDown_MouseEnter);
            this.cbxDown.MouseLeave += new System.EventHandler(this.cbxDown_MouseLeave);
            // 
            // cbxDoubleClick
            // 
            this.cbxDoubleClick.AutoSize = true;
            this.cbxDoubleClick.Checked = true;
            this.cbxDoubleClick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxDoubleClick.Location = new System.Drawing.Point(16, 48);
            this.cbxDoubleClick.Name = "cbxDoubleClick";
            this.cbxDoubleClick.Size = new System.Drawing.Size(195, 22);
            this.cbxDoubleClick.TabIndex = 5;
            this.cbxDoubleClick.Text = "マウスダブルクリックイベント";
            this.cbxDoubleClick.UseVisualStyleBackColor = true;
            this.cbxDoubleClick.CheckedChanged += new System.EventHandler(this.cbxDoubleClick_CheckedChanged);
            this.cbxDoubleClick.MouseEnter += new System.EventHandler(this.cbxDoubleClick_MouseEnter);
            this.cbxDoubleClick.MouseLeave += new System.EventHandler(this.cbxDoubleClick_MouseLeave);
            // 
            // cbxKey
            // 
            this.cbxKey.AutoSize = true;
            this.cbxKey.Checked = true;
            this.cbxKey.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxKey.Location = new System.Drawing.Point(16, 104);
            this.cbxKey.Name = "cbxKey";
            this.cbxKey.Size = new System.Drawing.Size(99, 22);
            this.cbxKey.TabIndex = 10;
            this.cbxKey.Text = "キーイベント";
            this.cbxKey.UseVisualStyleBackColor = true;
            this.cbxKey.CheckedChanged += new System.EventHandler(this.cbxKey_CheckedChanged);
            this.cbxKey.MouseEnter += new System.EventHandler(this.cbxKey_MouseEnter);
            this.cbxKey.MouseLeave += new System.EventHandler(this.cbxKey_MouseLeave);
            // 
            // cbxClick
            // 
            this.cbxClick.AutoSize = true;
            this.cbxClick.Checked = true;
            this.cbxClick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxClick.Location = new System.Drawing.Point(16, 24);
            this.cbxClick.Name = "cbxClick";
            this.cbxClick.Size = new System.Drawing.Size(159, 22);
            this.cbxClick.TabIndex = 4;
            this.cbxClick.Text = "マウスクリックイベント";
            this.cbxClick.UseVisualStyleBackColor = true;
            this.cbxClick.CheckedChanged += new System.EventHandler(this.cbxClick_CheckedChanged);
            this.cbxClick.MouseEnter += new System.EventHandler(this.cbxClick_MouseEnter);
            this.cbxClick.MouseLeave += new System.EventHandler(this.cbxClick_MouseLeave);
            // 
            // gbxStopMonitoring
            // 
            this.gbxStopMonitoring.Controls.Add(this.lblCurrentKey);
            this.gbxStopMonitoring.Controls.Add(this.txtCurrentKey);
            this.gbxStopMonitoring.Controls.Add(this.btnCancel);
            this.gbxStopMonitoring.Controls.Add(this.txtNewKey);
            this.gbxStopMonitoring.Controls.Add(this.btnApply);
            this.gbxStopMonitoring.Controls.Add(this.lblNewKey);
            this.gbxStopMonitoring.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbxStopMonitoring.Location = new System.Drawing.Point(8, 8);
            this.gbxStopMonitoring.Name = "gbxStopMonitoring";
            this.gbxStopMonitoring.Size = new System.Drawing.Size(248, 120);
            this.gbxStopMonitoring.TabIndex = 100;
            this.gbxStopMonitoring.TabStop = false;
            this.gbxStopMonitoring.Text = "監視終了";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(406, 355);
            this.Controls.Add(this.gbxStopMonitoring);
            this.Controls.Add(this.gbxLogOut);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "環境設定";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.gbxLogOut.ResumeLayout(false);
            this.gbxLogOut.PerformLayout();
            this.gbxExplanation.ResumeLayout(false);
            this.gbxStopMonitoring.ResumeLayout(false);
            this.gbxStopMonitoring.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentKey;
        private System.Windows.Forms.Label lblNewKey;
        private System.Windows.Forms.TextBox txtCurrentKey;
        private System.Windows.Forms.TextBox txtNewKey;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbxLogOut;
        private System.Windows.Forms.CheckBox cbxKey;
        private System.Windows.Forms.CheckBox cbxClick;
        private System.Windows.Forms.CheckBox cbxWheel;
        private System.Windows.Forms.CheckBox cbxLeave;
        private System.Windows.Forms.CheckBox cbxHover;
        private System.Windows.Forms.CheckBox cbxDown;
        private System.Windows.Forms.CheckBox cbxDoubleClick;
        private System.Windows.Forms.GroupBox gbxExplanation;
        private System.Windows.Forms.Label lblExplanation;
        private System.Windows.Forms.GroupBox gbxStopMonitoring;
    }
}