using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PhieuKiemKe.MyUserControl
{
    public delegate void AllTextChange(object sender, EventArgs e);
    public partial class uc_AE_Rows : UserControl
    {
        public event AllTextChange Changed;
        public uc_AE_Rows()
        {
            InitializeComponent();
        }
        public void ResetData()
        {
            txt_TruongSo09.Text = "";
            txt_TruongSo09.BackColor = Color.White;
            txt_TruongSo09.ForeColor = Color.Black;
        }
        public bool IsEmpty()
        {
            if (string.IsNullOrEmpty(txt_TruongSo09.Text))
                return true;
            return false;
        }

        private void txt_TruongSo09_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_TruongSo09.Text.IndexOf('?') >= 0)
                txt_TruongSo09.Text = @"?";
            if ( txt_TruongSo09.Text != "" && txt_TruongSo09.Text != @"?"&& txt_TruongSo09.Text.Length>10)
            {
                txt_TruongSo09.BackColor = Color.Red;
                txt_TruongSo09.ForeColor = Color.White;
            }
            else
            {
                txt_TruongSo09.BackColor = Color.White;
                txt_TruongSo09.ForeColor = Color.Black;
            }
            Changed?.Invoke(sender, e);
        }

        private void uc_AE_Rows_Load(object sender, EventArgs e)
        {
            txt_TruongSo09.GotFocus += Txt_TruongSo09_GotFocus;
        }
        private void Txt_TruongSo09_GotFocus(object sender, EventArgs e)
        {
            ((TextEdit)sender).SelectAll();
        }

        private void txt_TruongSo09_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                SendKeys.Send("{Tab}");
            }
            else if (e.KeyCode == Keys.Up)
            {
                SendKeys.Send("+{Tab}");
            }
        }
    }
}
