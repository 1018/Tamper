using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;

namespace TamperResistantProgram
{
    public partial class VersionInfoForm : Form
    {
        // バージョン名
        private string _appVersion = string.Empty;
        // 製品名
        private string _appProductName = string.Empty;
        // 会社名
        private string _appCompanyName = string.Empty;
        // コピーライト
        private string _appCopyright = string.Empty;
        // 詳細情報
        private string _appDescription = string.Empty;
        // アプリケーションアイコン
        private Icon _appIcon = null;

        public VersionInfoForm()
        {
            InitializeComponent();
            getAppInfo();
        }

        /// <summary>
        /// アプリケーション情報取得
        /// </summary>
        private void getAppInfo()
        {
            _appVersion = Application.ProductVersion;
            _appProductName = Application.ProductName;
            _appCompanyName = Application.CompanyName;

            Assembly mainAssembly = Assembly.GetEntryAssembly();

            // コピーライトを取得
            _appCopyright = "-";
            object[] copyrightArray =
                mainAssembly.GetCustomAttributes(
                typeof(AssemblyCopyrightAttribute), false);
            if ((null != copyrightArray) && (copyrightArray.Length > 0))
            {
                _appCopyright =
                    ((AssemblyCopyrightAttribute)copyrightArray[0]).Copyright;
            }

            // 詳細情報
            _appDescription = "-";
            object[] descriptionArray =
                mainAssembly.GetCustomAttributes(
                typeof(AssemblyDescriptionAttribute), false);
            if ((null != descriptionArray) && (descriptionArray.Length > 0))
            {
                _appDescription =
                    ((AssemblyDescriptionAttribute)descriptionArray[0]).Description;
            }

            // アプリケーションアイコン
            SHFILEINFO shinfo = new SHFILEINFO();
            IntPtr hSuccess = SHGetFileInfo(
              mainAssembly.Location, 0,
              ref shinfo, (uint)Marshal.SizeOf(shinfo),
              SHGFI_ICON | SHGFI_LARGEICON);
            if (hSuccess != IntPtr.Zero)
            {
                _appIcon = Icon.FromHandle(shinfo.hIcon);
            }
            else
            {
                _appIcon = SystemIcons.Application;
            }
            

            
        }
        #region アイコン取得用
        // SHGetFileInfo関数
        [DllImport("shell32.dll")]
        private static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags);

        // SHGetFileInfo関数で使用するフラグ
        private const uint SHGFI_ICON = 0x100; // アイコン・リソースの取得
        private const uint SHGFI_LARGEICON = 0x0; // 大きいアイコン
        private const uint SHGFI_SMALLICON = 0x1; // 小さいアイコン

        // SHGetFileInfo関数で使用する構造体
        private struct SHFILEINFO
        {
            public IntPtr hIcon;
            public IntPtr iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        };
        #endregion

        private void VersionInfoForm_Load(object sender, EventArgs e)
        {
            this.Text = _appProductName + " のバージョン情報";
            lblAppCompanyProductName.Text = _appCompanyName +" " + _appProductName;
            lblAppVersion.Text = "Version: " + _appVersion;
            lblCopyright.Text = _appCopyright;
            lblAppDescription.Text = _appDescription;
            pbxAppIcon.Image = _appIcon.ToBitmap();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
