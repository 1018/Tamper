using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SystemCommon;

namespace TamperResistantProgram
{
    public partial class MainForm : Form
    {
        #region　定数
        private const string LOG_DIR_PATH = @"C:\TamperResistantProgram\";
        private const string MOUSE_CLICK = "マウスクリックイベントが発生しました。";
        private const string MOUSE_DOUBLE_CLICK = "マウスダブルクリックイベントが発生しました。";
        private const string MOUSE_DOWN = "マウスダウンイベントが発生しました。";
        private const string MOUSE_ENTER = "マウスポインターによってコントロールに入力されようとしています";
        private const string MOUSE_HOVER = "マウスホバーイベントが発生しました。";
        private const string MOUSE_LEAVE = "マウスリーブイベントが発生しました。";
        private const string MOUSE_MOVE = "マウスポインターがコントロール上を移動しました";
        private const string MOUSE_WHEEL = "マウスホイールイベントが発生しました。";

        private const string STOP_MONITORING = "監視End";
        private const string MINIMIZE_WINDOW = "ウィンドウを最小化します";
        
        #endregion

        private int _displayHeight = Screen.PrimaryScreen.Bounds.Height;
        private int _displayWidth = Screen.PrimaryScreen.Bounds.Width;
        private Form trForm = null;
        private SettingForm sf = null;
        private string _logDirPath;

        private static MainForm _instance = null;
        public static MainForm Instance
        {
            get
            {
                if (null == _instance || _instance.IsDisposed)
                {
                    _instance = new MainForm();
                }
                return _instance;
            }
        }

        private Keys _stopMonitoring { get; set; }


        #region win32 APIでの画面キャプチャ
        private const int SRCCOPY = 13369376;
        private const int CAPTUREBLT = 103741824;
        [DllImport("user32.dll")]
        private static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("gdi32.dll")]
        private static extern int BitBlt(IntPtr hDestDC,
            int x,
            int y,
            int nWidth,
            int nHeight,
            IntPtr hSrcDC,
            int xSrc,
            int ySrc,
            int dwRop);

        [DllImport("user32.dll")]
        private static extern IntPtr ReleaseDC(IntPtr hwnd, IntPtr hdc);

        /// <summary>
        /// プライマリスクリーンの画像取得
        /// </summary>
        /// <returns></returns>
        public static Bitmap CaptureScreen()
        {
            //プライマリモニタのデバイスコンテキストを取得
            IntPtr disDC = GetDC(IntPtr.Zero);
            //Bitmapの作成
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                Screen.PrimaryScreen.Bounds.Height);
            //Graphicsの作成
            Graphics g = Graphics.FromImage(bmp);
            //Graphicsのデバイスコンテキストを取得
            IntPtr hDC = g.GetHdc();
            //Bitmapに画像をコピーする
            BitBlt(hDC, 0, 0, bmp.Width, bmp.Height,
                disDC, 0, 0, SRCCOPY);
            //解放
            g.ReleaseHdc(hDC);
            g.Dispose();
            ReleaseDC(IntPtr.Zero, disDC);

            return bmp;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern int GetWindowRect(IntPtr hwnd,
            ref  RECT lpRect);

        #endregion

        public MainForm()
        {
            InitializeComponent();
            _logDirPath = getExeAppPath();
         
        }

        /// <summary>
        /// 新しいフォームを作成する
        /// </summary>
        /// <param name="trForm"></param>
        private void createNewForm(Form trForm)
        {
            try
            {
                trForm.ControlBox = false;
                trForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                trForm.ShowInTaskbar = false;
                trForm.Height = _displayHeight;
                trForm.Width = _displayWidth;
                trForm.StartPosition = FormStartPosition.CenterScreen;
                trForm.TopMost = true;
                trForm.WindowState = FormWindowState.Maximized;

                PictureBox pb = new PictureBox();
                pb.Height = _displayHeight;
                pb.Width = _displayWidth;

                trForm.Controls.Add(pb);

                pb.Image = CaptureScreen();

                pb.MouseClick += new MouseEventHandler(pb_MouseClick);
                pb.MouseDoubleClick += new MouseEventHandler(pb_MouseDoubleClick);
                pb.MouseDown += new MouseEventHandler(pb_MouseDown);
                //pb.MouseEnter += new EventHandler(pb_MouseEnter);
                pb.MouseHover += new EventHandler(pb_MouseHover);
                pb.MouseLeave += new EventHandler(pb_MouseLeave);
                //pb.MouseMove += new MouseEventHandler(pb_MouseMove);
                pb.MouseWheel += new MouseEventHandler(pb_MouseWheel);

            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message, _logDirPath);
            }
        }          

        /// <summary>
        /// コンテキストメニューでの開始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmStart_Click(object sender, EventArgs e)
        {
            Logger.WriteLog("監視Start", _logDirPath);
                      
            trForm = new Form();
            createNewForm(trForm);
            // モーダルで表示
            //trForm.ShowDialog();
            trForm.Show();

            trForm.KeyUp += new KeyEventHandler(trForm_KeyUp);       
            
        }



        #region Mouse Event
        void pb_MouseClick(object sender, MouseEventArgs e)
        {
            if(sf.mouseClick)
            {
                Logger.WriteLog(MOUSE_CLICK, _logDirPath);
            }
        }

        void pb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (sf.mouseDoubleClick)
            {
                Logger.WriteLog(MOUSE_DOUBLE_CLICK, _logDirPath);
            }
        } 

        void pb_MouseDown(object sender, MouseEventArgs e)
        {
            if (sf.mouseDown)
            {
                Logger.WriteLog(MOUSE_DOWN, _logDirPath);
            }
        }

        //void pb_MouseEnter(object sender, EventArgs e)
        //{
        //    Logger.WriteLog(MOUSE_ENTER, _logDirPath);
        //}

        void pb_MouseHover(object sender, EventArgs e)
        {
            if (sf.mouseHover)
            {
                Logger.WriteLog(MOUSE_HOVER, _logDirPath);
            }
        }
        void pb_MouseLeave(object sender, EventArgs e)
        {
            if (sf.mouseLeave)
            {
                Logger.WriteLog(MOUSE_LEAVE, _logDirPath);
            }
        }

        //void pb_MouseMove(object sender, MouseEventArgs e)
        //{
        //    Logger.WriteLog(MOUSE_MOVE, _logDirPath);
        //}

        void pb_MouseWheel(object sender, MouseEventArgs e)
        {
            if (sf.mouseWheel)
            {
                Logger.WriteLog(MOUSE_WHEEL, _logDirPath);
            }
        }
        #endregion

        /// <summary>
        /// キー押下処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void trForm_KeyUp(object sender, KeyEventArgs e)
        {
            if((int)e.KeyData == Properties.Settings.Default.KeyData)
            {
                Logger.WriteLog(STOP_MONITORING, _logDirPath);                                   
                trForm.Close();
                trForm.Dispose(); 
            }
            else if (e.KeyCode == Properties.Settings.Default.MinimizeWindow)
            {
                Logger.WriteLog(MINIMIZE_WINDOW, _logDirPath);
                trForm.WindowState = FormWindowState.Minimized;
            }
            else
            {
                if (sf.keyEvent)
                {
                    Logger.WriteLog("Key: " + e.KeyCode.ToString(), _logDirPath);
                }
            }
        }

        /// <summary>
        /// コンテキストメニューでの終了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmsStop_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            notifyIcon.Icon.Dispose();
#warning 本体終わらないからプロセスkill                        
            this.Close();
            //this.Dispose();
            int myId = Process.GetCurrentProcess().Id;
            Process p = Process.GetProcessById(myId);
            p.Kill();
        }

        /// <summary>
        /// コンテキストメニューでのバージョン情報
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmVersionInfo_Click(object sender, EventArgs e)
        {
            VersionInfoForm vif = new VersionInfoForm();
            vif.Show();
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

        /// <summary>
        /// 環境設定フォームの表示
        /// </summary> 
        private void tsmSettings_Click(object sender, EventArgs e)
        {
            sf = new SettingForm();
            sf.ShowDialog();
        }
    }
}
// EOF
