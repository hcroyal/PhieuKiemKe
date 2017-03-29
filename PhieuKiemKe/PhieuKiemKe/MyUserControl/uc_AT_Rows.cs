using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace PhieuKiemKe.MyUserControl
{
    public partial class uc_AT_Rows : UserControl
    {
        public event AllTextChange Changed;

        public uc_AT_Rows()
        {
            InitializeComponent();
            txt_TruongSo07.Properties.Items.Add("SAKUJYO    | Khi dữ liệu giữa phiếu bị gạch bỏ, hoặc trống nguyên dòng");
            txt_TruongSo07.Properties.Items.Add("YOHAKU     | Kết thúc dữ liệu trong phiếu");
            txt_TruongSo07.Properties.Items.Add("KAKISONJI | Khi cả phiếu gạch chéo, bỏ");
            txt_TruongSo07.Properties.Items.Add("MISIYO       | Khi cả phiếu trống, không có dữ liệu (phiếu trắng)");
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

        public void SaveData(string idimage, string truongso02, string truongso03, string truongso04, string truongso05, string idphieu)
        {
            Global.db.Insert_AT(idimage, Global.StrBatch, Global.StrUsername, truongso02, truongso03, truongso04, truongso05,
                txt_TruongSo07.Text, txt_TruongSo08.Text, txt_TruongSo09.Text, txt_TruongSo10.Text, txt_STT.Text,
                idphieu);
        }

        private void txt_TruongSo07_TextChanged(object sender, EventArgs e)
        {
            if (txt_TruongSo07.Text == "SAKUJYO    | KHI DỮ LIỆU GIỮA PHIẾU BỊ GẠCH BỎ, HOẶC TRỐNG NGUYÊN DÒNG")
            {
                txt_TruongSo07.Text = "SAKUJYO";
            }
            else if (txt_TruongSo07.Text == "YOHAKU     | KẾT THÚC DỮ LIỆU TRONG PHIẾU")
            {
                txt_TruongSo07.Text = "YOHAKU";
            }
            else if (txt_TruongSo07.Text == "KAKISONJI | KHI CẢ PHIẾU GẠCH CHÉO, BỎ")
            {
                txt_TruongSo07.Text = "KAKISONJI";
            }
            else if (txt_TruongSo07.Text == "MISIYO       | KHI CẢ PHIẾU TRỐNG, KHÔNG CÓ DỮ LIỆU (PHIẾU TRẮNG)")
            {
                txt_TruongSo07.Text = "MISIYO";
            }
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo10_EditValueChanged(object sender, EventArgs e)
        {
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo08_EditValueChanged(object sender, EventArgs e)
        {
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo09_EditValueChanged(object sender, EventArgs e)
        {
            Changed?.Invoke(sender, e);
        }
    }
}
