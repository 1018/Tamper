namespace TamperResistantProgram
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmStart = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsStop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVersionInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "TamperResistantProgram";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmStart,
            this.cmsStop,
            this.tsmSettings,
            this.tsmVersionInfo});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(161, 114);
            // 
            // tsmStart
            // 
            this.tsmStart.Name = "tsmStart";
            this.tsmStart.Size = new System.Drawing.Size(160, 22);
            this.tsmStart.Text = "開始";
            this.tsmStart.Click += new System.EventHandler(this.tsmStart_Click);
            // 
            // cmsStop
            // 
            this.cmsStop.Name = "cmsStop";
            this.cmsStop.Size = new System.Drawing.Size(160, 22);
            this.cmsStop.Text = "終了";
            this.cmsStop.Click += new System.EventHandler(this.cmsStop_Click);
            // 
            // tsmSettings
            // 
            this.tsmSettings.Name = "tsmSettings";
            this.tsmSettings.Size = new System.Drawing.Size(160, 22);
            this.tsmSettings.Text = "設定";
            this.tsmSettings.Click += new System.EventHandler(this.tsmSettings_Click);
            // 
            // tsmVersionInfo
            // 
            this.tsmVersionInfo.Name = "tsmVersionInfo";
            this.tsmVersionInfo.Size = new System.Drawing.Size(160, 22);
            this.tsmVersionInfo.Text = "バージョン情報";
            this.tsmVersionInfo.Click += new System.EventHandler(this.tsmVersionInfo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.05D;
            this.ShowInTaskbar = false;
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmStart;
        private System.Windows.Forms.ToolStripMenuItem cmsStop;
        private System.Windows.Forms.ToolStripMenuItem tsmVersionInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmSettings;
    }
}

