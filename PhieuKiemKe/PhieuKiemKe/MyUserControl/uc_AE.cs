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
    public partial class uc_AE : UserControl
    {
        public event AllTextChange Changed;
        public uc_AE()
        {
            InitializeComponent();
        }
        void UpdateStt()
        {
            uc_AE_Rows1.txt_STT.Text = "01";
            uc_AE_Rows2.txt_STT.Text = "02";
            uc_AE_Rows3.txt_STT.Text = "03";
            uc_AE_Rows4.txt_STT.Text = "04";
            uc_AE_Rows5.txt_STT.Text = "05";
            uc_AE_Rows6.txt_STT.Text = "06";
            uc_AE_Rows7.txt_STT.Text = "07";
            uc_AE_Rows8.txt_STT.Text = "08";
            uc_AE_Rows9.txt_STT.Text = "09";
            uc_AE_Rows10.txt_STT.Text = "10";
        }
        public void ResetData()
        {
            txt_TruongSo02.Text = "";
            txt_TruongSo03.Text = "";
            txt_TruongSo04.Text = "";
            txt_TruongSo05.Text = "";

            txt_TruongSo02.BackColor = Color.White;
            txt_TruongSo03.BackColor = Color.White;
            txt_TruongSo04.BackColor = Color.White;
            txt_TruongSo05.BackColor = Color.White;

            txt_TruongSo02.ForeColor = Color.Black;
            txt_TruongSo03.ForeColor = Color.Black;
            txt_TruongSo04.ForeColor = Color.Black;
            txt_TruongSo05.ForeColor = Color.Black;

            uc_AE_Rows1.ResetData();
            uc_AE_Rows2.ResetData();
            uc_AE_Rows3.ResetData();
            uc_AE_Rows4.ResetData();
            uc_AE_Rows5.ResetData();
            uc_AE_Rows6.ResetData();
            uc_AE_Rows7.ResetData();
            uc_AE_Rows8.ResetData();
            uc_AE_Rows9.ResetData();
            uc_AE_Rows10.ResetData();
            txt_TruongSo02.Focus();}

        public bool IsEmpty()
        {
            bool empty = true;

            if (uc_AE_Rows1.IsEmpty() == false ||
                uc_AE_Rows2.IsEmpty() == false ||
                uc_AE_Rows3.IsEmpty() == false ||
                uc_AE_Rows4.IsEmpty() == false ||
                uc_AE_Rows5.IsEmpty() == false ||
                uc_AE_Rows6.IsEmpty() == false ||
                uc_AE_Rows7.IsEmpty() == false ||
                uc_AE_Rows8.IsEmpty() == false ||
                uc_AE_Rows9.IsEmpty() == false ||
                uc_AE_Rows10.IsEmpty() == false)
                empty = false;
            return empty;
        }

        public void SaveData_AE(string idImage)
        {
            foreach (var item in Controls)
            {
                if (item is uc_AE_Rows)
                {
                    Global.db.Insert_AE(idImage, Global.StrBatch, Global.StrUsername, txt_TruongSo02.Text,
                        txt_TruongSo03.Text, txt_TruongSo04.Text, txt_TruongSo05.Text,
                        ((uc_AE_Rows) item).txt_TruongSo09.Text, ((uc_AE_Rows) item).txt_STT.Text);
                }
            }
        }
        private void uc_AE_Load(object sender, EventArgs e)
        {
            UpdateStt();
            txt_TruongSo02.GotFocus += Txt_TruongSo02_GotFocus;
            txt_TruongSo03.GotFocus += Txt_TruongSo02_GotFocus;
            txt_TruongSo04.GotFocus += Txt_TruongSo02_GotFocus;
            txt_TruongSo05.GotFocus += Txt_TruongSo02_GotFocus;
        }

        private void Txt_TruongSo02_GotFocus(object sender, EventArgs e)
        {
            ((TextEdit)sender).SelectAll();
        }

        private void txt_TruongSo02_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_TruongSo02.Text.IndexOf('?') >= 0)
                txt_TruongSo02.Text = @"?";
            if (txt_TruongSo02.Text != "" && txt_TruongSo02.Text != @"?" && txt_TruongSo02.Text.Length > 6)
            {
                txt_TruongSo02.BackColor = Color.Red;
                txt_TruongSo02.ForeColor = Color.White;
            }
            else
            {
                txt_TruongSo02.BackColor = Color.White;
                txt_TruongSo02.ForeColor = Color.Black;
            }
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo03_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_TruongSo03.Text.IndexOf('?') >= 0)
                txt_TruongSo03.Text = @"?";
            if (txt_TruongSo03.Text != "" && txt_TruongSo03.Text != @"?" && txt_TruongSo03.Text.Length > 4)
            {
                txt_TruongSo03.BackColor = Color.Red;
                txt_TruongSo03.ForeColor = Color.White;
            }
            else
            {
                txt_TruongSo03.BackColor = Color.White;
                txt_TruongSo03.ForeColor = Color.Black;
            }
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo04_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_TruongSo04.Text.IndexOf('?') >= 0)
                txt_TruongSo04.Text = @"?";
            if (txt_TruongSo04.Text != "" && txt_TruongSo04.Text != @"?" && txt_TruongSo04.Text.Length > 10)
            {
                txt_TruongSo04.BackColor = Color.Red;
                txt_TruongSo04.ForeColor = Color.White;
            }
            else
            {
                txt_TruongSo04.BackColor = Color.White;
                txt_TruongSo04.ForeColor = Color.Black;
            }
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo05_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_TruongSo05.Text.IndexOf('?') >= 0)
                txt_TruongSo05.Text = @"?";
            if (txt_TruongSo05.Text != "" && txt_TruongSo05.Text != @"?" && txt_TruongSo05.Text.Length > 15)
            {
                txt_TruongSo05.BackColor = Color.Red;
                txt_TruongSo05.ForeColor = Color.White;
            }
            else
            {
                txt_TruongSo05.BackColor = Color.White;
                txt_TruongSo05.ForeColor = Color.Black;
            }
            Changed?.Invoke(sender, e);
        }
    }
}
