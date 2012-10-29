using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SystemCommon;


namespace TamperResistantProgram
{
    public partial class TamperResistantForm : Form
    {
        //private static TamperResistantForm _instance = null;
        //public static TamperResistantForm Instance
        //{
        //    get
        //    {
        //        if (null == _instance)
        //        {
        //            _instance = new TamperResistantForm();
        //        }
        //        return _instance;
        //    }
        //}

        private int _displayHeight = Screen.PrimaryScreen.Bounds.Height;
        private int _displayWidth = Screen.PrimaryScreen.Bounds.Width;
        private PictureBox _pb = null;


        public TamperResistantForm()
        {
            InitializeComponent();
        }

        private MainForm _mainForm = null;
        public TamperResistantForm(MainForm mf)
        {
            InitializeComponent();
            _mainForm = mf;
        }


        /// <summary>
        /// 実行ファイルのパス取得
        /// </summary>
        /// <returns></returns>
        private static string getExeAppPath()
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetEntryAssembly();
            if (asm == null)
                return "";
            else
                return System.IO.Path.GetDirectoryName(asm.Location);
        }

        private void TamperResistantForm_Load(object sender, EventArgs e)
        {
            _pb = new PictureBox();
            string dirPath = string.Empty;
            try
            {
                dirPath = getExeAppPath();
                if (!File.Exists(dirPath + IMAGE_FILE_NAME))
                {
                    _pb.Image = _mainForm.BmpImage;
                }
                else
                {
                    //throw new FileNotFoundException();
                    _pb.ImageLocation = dirPath + IMAGE_FILE_NAME;
                    _pb.Height = _displayHeight;
                    _pb.Width = _displayWidth;
                }


                this.ControlBox = false;
                this.FormBorderStyle = FormBorderStyle.None;
                this.ShowInTaskbar = false;
                this.Height = 100;// DisplayHeight;
                this.Width = 100;// DisplayWidth;
                this.StartPosition = FormStartPosition.CenterScreen;
                this.TopMost = true;
                this.WindowState = FormWindowState.Maximized;

                this.Controls.Add(_pb);
            }
            catch (FileNotFoundException fex)
            {
                Logger.WriteLog(fex.Message);
                MessageBox.Show("表示するイメージをフォルダにおいてください。",
                    fex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message);
                Logger.WriteLog(ex.StackTrace);
                MessageBox.Show("アプリケーションを終了します。",
                    ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            } 
        }

        /// <summary>
        /// キー押下処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TamperResistantForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    this.TopMost = true;
                    Cursor.Current = Cursors.WaitCursor;
                    Thread.Sleep(5000);
                    this.Cursor = Cursors.Default;
                    break;

                case Keys.F4:
                    this.Close();
                    break;

                case Keys.F6:
                    this.WindowState = FormWindowState.Minimized;

                    break;
            }

        }

        #region Constant
        private const string IMAGE_FILE_NAME = @"\Default.jpg";
        private const string SETTING_FILE = @"\Setting.ini";
        #endregion


    }
}
// EOF
