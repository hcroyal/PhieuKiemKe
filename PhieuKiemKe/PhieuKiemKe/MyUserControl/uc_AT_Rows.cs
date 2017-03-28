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
    public partial class uc_AT_Rows : UserControl
    {
        public uc_AT_Rows()
        {
            InitializeComponent();
            txt_TruongSo07.Properties.Items.Add("SAKUJYO");
            txt_TruongSo07.Properties.Items.Add("YOHAKU");
            txt_TruongSo07.Properties.Items.Add("KAKISONJI");
            txt_TruongSo07.Properties.Items.Add("MISIYO");
        }
        private void uc_AT_Rows_Load(object sender, EventArgs e)
        {
            txt_TruongSo07.GotFocus += Txt_TruongSo07_GotFocus;
            txt_TruongSo08.GotFocus += Txt_TruongSo08_GotFocus;
            txt_TruongSo09.GotFocus += Txt_TruongSo08_GotFocus;
            txt_TruongSo10.GotFocus += Txt_TruongSo08_GotFocus;
        }

        private void Txt_TruongSo08_GotFocus(object sender, EventArgs e)
        {
            ((TextEdit)sender).SelectAll();
        }

        private void Txt_TruongSo07_GotFocus(object sender, EventArgs e)
        {
            txt_TruongSo07.SelectAll();
        }

        public void resetData()
        {
            txt_TruongSo07.Text = "";
            txt_TruongSo08.Text = "";
            txt_TruongSo09.Text = "";
            txt_TruongSo10.Text = "";
        }

        public bool isEmpty()
        {
            return string.IsNullOrEmpty(txt_TruongSo07.Text) &&
                   string.IsNullOrEmpty(txt_TruongSo08.Text) &&
                   string.IsNullOrEmpty(txt_TruongSo09.Text) &&
                   string.IsNullOrEmpty(txt_TruongSo10.Text);
        }
    }
}
