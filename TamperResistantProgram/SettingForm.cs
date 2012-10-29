using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;	//Keyboardクラス用

namespace TamperResistantProgram
{
    public partial class SettingForm : Form
    {
        #region 定数
        private const string EXP_MOUSE_CLICK = "画面をクリックしたときに発生します。";
        private const string EXP_MOUSE_DOUBLE_CLICK = "画面をダブルクリックしたときに発生します。";
        private const string EXP_MOUSE_DOWN = "マウスポインタがコントロール上にあり、\r\nマウスボタンが押されたときに発生します。";
        private const string EXP_MOUSE_HOVER = "マウスポインタが一定時間、画面上で動かなかったときに\r\n発生します。";
        private const string EXP_MOUSE_LEAVE = "マウスポインタが画面の表示領域から離れたときに\r\n発生します。";
        private const string EXP_MOUSE_WHEEL = "コントロールにフォーカスがあるときに、\r\nマウスホイールを回転させると発生します。";
        private const string EXP_KEY_EVENT = "キー操作を行った場合に発生します。";
        #endregion
        private int _keyData;
        
        public bool mouseClick { get; set; }
        public bool mouseDoubleClick { get; set; }
        public bool mouseDown { get; set; }
        public bool mouseHover { get; set; }
        public bool mouseLeave { get; set; }
        public bool mouseWheel { get; set; }
        public bool keyEvent { get; set; }

        
        public SettingForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームロード時表示処理
        /// </summary>
        private void SettingForm_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();

            txtCurrentKey.Text = Properties.Settings.Default.StopMonitoring;          
            cbxClick.Checked = Properties.Settings.Default.MouseClick;
            cbxDoubleClick.Checked = Properties.Settings.Default.MouseDoubleClick;
            cbxDown.Checked = Properties.Settings.Default.MouseDown;
            cbxHover.Checked = Properties.Settings.Default.MouseHover;
            cbxLeave.Checked = Properties.Settings.Default.MouseLeave;
            cbxWheel.Checked = Properties.Settings.Default.MouseWheel;
            cbxKey.Checked = Properties.Settings.Default.KeyEvent;
        }

        /// <summary>
        /// 設定ボタン有効化
        /// </summary>
        private void txtNewKey_TextChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }

        /// <summary>
        /// 設定ボタン押下処理
        /// </summary>
        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (txtNewKey.Text == "")
            {
                MessageBox.Show("キーが設定されていません。", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtCurrentKey.Text = txtNewKey.Text;               
                Properties.Settings.Default["StopMonitoring"] = txtNewKey.Text; ;
                Properties.Settings.Default["KeyData"] = _keyData;
            }
        }

        /// <summary>
        /// 新しいキーの設定
        /// </summary>
        private void txtNewKey_KeyDown(object sender, KeyEventArgs e)
        {
            string buf = string.Empty;
            _keyData = 0;
            if ((e.Modifiers & Keys.Alt) == Keys.Alt)
            {
                buf += "Alt + ";
            }
                        
            if ((e.Modifiers & Keys.Control) == Keys.Control)
            {
                buf += "Ctrl + ";
            }
            
            if ((e.Modifiers & Keys.Shift) == Keys.Shift)
            {
                buf += "Shift + ";
            }

            if (e.KeyCode != Keys.Menu && e.KeyCode != Keys.ControlKey && e.KeyCode != Keys.ShiftKey)
            {
                txtNewKey.Text = "";
                txtNewKey.Text = buf + e.KeyCode.ToString();
                _keyData = (int)e.KeyData;
            }
            else
            {
                txtNewKey.Text = buf;
            }
        }


        /// <summary>
        /// キー押下処理
        /// </summary>
        private void txtNewKey_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtNewKey.Text == "Alt + " || txtNewKey.Text == "Ctrl + " || txtNewKey.Text == "Shift + ")
            {
                txtNewKey.Text = "";
            }            
        }

        #region Mouse & Key Event
        private void cbxClick_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxClick.Checked)
            {
                mouseClick = true;
                Properties.Settings.Default["MouseClick"] = true;
            }
            else
            {
                mouseClick = false;
                Properties.Settings.Default["MouseClick"] = false;
            }
        }

        private void cbxDoubleClick_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDoubleClick.Checked)
            {
                mouseDoubleClick = true;
                Properties.Settings.Default["MouseDoubleClick"] = true;
            }
            else
            {
                mouseDoubleClick = false;
                Properties.Settings.Default["MouseDoubleClick"] = false;
            }
        }

        private void cbxDown_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDown.Checked)
            {
                mouseDown = true;
                Properties.Settings.Default["MouseDown"] = true;
            }
            else
            {
                mouseDown = false;
                Properties.Settings.Default["MouseDown"] = false;
            }
        }

        private void cbxHover_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHover.Checked)
            {
                mouseHover = true;
                Properties.Settings.Default["MouseHover"] = true;
            }
            else
            {
                mouseHover = false;
                Properties.Settings.Default["MouseHover"] = false;
            }
        }

        private void cbxLeave_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxLeave.Checked)
            {
                mouseLeave = true;
                Properties.Settings.Default["MouseLeave"] = true;
            }
            else
            {
                mouseLeave = false;
                Properties.Settings.Default["MouseLeave"] = false;
            }
        }

        private void cbxWheel_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxWheel.Checked)
            {
                mouseWheel = true;
                Properties.Settings.Default["MouseWheel"] = true;
            }
            else
            {
                mouseWheel = false;
                Properties.Settings.Default["MouseWheel"] = false;
            }
        }

        private void cbxKey_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxKey.Checked)
            {
                keyEvent = true;
                Properties.Settings.Default["KeyEvent"] = true;
            }
            else
            {
                keyEvent = false;
                Properties.Settings.Default["KeyEvent"] = false;
            }
        }
        #endregion

        #region Explanation
        private void cbxClick_MouseEnter(object sender, EventArgs e)
        {
            lblExplanation.Text = EXP_MOUSE_CLICK;
        }

        private void cbxClick_MouseLeave(object sender, EventArgs e)
        {
            lblExplanation.Text = "";
        }

        private void cbxDoubleClick_MouseEnter(object sender, EventArgs e)
        {
            lblExplanation.Text = EXP_MOUSE_DOUBLE_CLICK;
        }

        private void cbxDoubleClick_MouseLeave(object sender, EventArgs e)
        {
            lblExplanation.Text = "";
        }

        private void cbxDown_MouseEnter(object sender, EventArgs e)
        {
            lblExplanation.Text = EXP_MOUSE_DOWN;
        }

        private void cbxDown_MouseLeave(object sender, EventArgs e)
        {
            lblExplanation.Text = "";
        }

        private void cbxHover_MouseEnter(object sender, EventArgs e)
        {
            lblExplanation.Text = EXP_MOUSE_HOVER;
        }

        private void cbxHover_MouseLeave(object sender, EventArgs e)
        {
            lblExplanation.Text = "";
        }

        private void cbxLeave_MouseEnter(object sender, EventArgs e)
        {
            lblExplanation.Text = EXP_MOUSE_LEAVE;
        }

        private void cbxLeave_MouseLeave(object sender, EventArgs e)
        {
            lblExplanation.Text = "";
        }

        private void cbxWheel_MouseEnter(object sender, EventArgs e)
        {
            lblExplanation.Text = EXP_MOUSE_WHEEL;
        }

        private void cbxWheel_MouseLeave(object sender, EventArgs e)
        {
            lblExplanation.Text = "";
        }

        private void cbxKey_MouseEnter(object sender, EventArgs e)
        {
            lblExplanation.Text = EXP_KEY_EVENT;
        }

        private void cbxKey_MouseLeave(object sender, EventArgs e)
        {
            lblExplanation.Text = "";
        }

        #endregion 



    }
}
