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
        private List<Category> category = new List<Category>();

        public class Category
        {
            public string Value { get; set; }
            public string ChuThich { get; set; }
        }
        private void setData()
        {
            category.Add(new uc_AT_Rows.Category() { Value = "SAKUJYO", ChuThich = "Khi dữ liệu giữa phiếu bị gạch bỏ, hoặc trống nguyên dòng" });
            category.Add(new uc_AT_Rows.Category() { Value = "YOHAKU", ChuThich = "Kết thúc dữ liệu trong phiếu" });
            category.Add(new uc_AT_Rows.Category() { Value = "KAKISONJI", ChuThich = "Khi cả phiếu gạch chéo, bỏ" });
            category.Add(new uc_AT_Rows.Category() { Value = "MISIYO", ChuThich = "Khi cả phiếu trống, không có dữ liệu (phiếu trắng)" });
        }

        public uc_AT_Rows()
        {
            InitializeComponent();
            setData();
            txt_TruongSo07.Properties.DataSource = category;
            txt_TruongSo07.Properties.DisplayMember = "Value";
            txt_TruongSo07.Properties.ValueMember = "Value";
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
            txt_TruongSo07.SelectAll();//txt_TruongSo07.ShowPopup();
        }

        public void resetData()
        {
            txt_TruongSo07.Text = "";
            txt_TruongSo08.Text = "";
            txt_TruongSo09.Text = "";
            txt_TruongSo10.Text = "";
            txt_TruongSo07.BackColor = Color.White;
            txt_TruongSo07.ForeColor = Color.Black;
            txt_TruongSo08.BackColor = Color.White;
            txt_TruongSo08.ForeColor = Color.Black;
            txt_TruongSo09.BackColor = Color.White;
            txt_TruongSo09.ForeColor = Color.Black;
            txt_TruongSo10.BackColor = Color.White;
            txt_TruongSo10.ForeColor = Color.Black;

        }

        public bool TruongSo7Trong()
        {
            return String.IsNullOrEmpty(txt_TruongSo07.Text);
        }
        public bool isEmpty()
        {
            return String.IsNullOrEmpty(txt_TruongSo07.Text) &&
                   String.IsNullOrEmpty(txt_TruongSo08.Text) &&
                   String.IsNullOrEmpty(txt_TruongSo09.Text) &&
                   String.IsNullOrEmpty(txt_TruongSo10.Text);
        }

        public void SaveData(string idimage, string truongso02, string truongso03, string truongso04, string truongso05, string idphieu)
        {
            Global.db.Insert_AT(idimage, Global.StrBatch, Global.StrUsername, truongso02, truongso03, truongso04, truongso05,
                txt_TruongSo07.Text, txt_TruongSo08.Text, txt_TruongSo09.Text, txt_TruongSo10.Text, txt_STT.Text,
                idphieu);
        }

        private void txt_TruongSo07_TextChanged(object sender, EventArgs e)
        {
            if (txt_TruongSo07.Text.IndexOf('?') >= 0)
                txt_TruongSo07.Text = @"?";
            if (txt_TruongSo07.Text != "" && txt_TruongSo07.Text != @"?" && txt_TruongSo07.Text.Length > 30)
            {
                txt_TruongSo07.BackColor = Color.Red;
                txt_TruongSo07.ForeColor = Color.White;
            }
            else
            {
                txt_TruongSo07.BackColor = Color.White;
                txt_TruongSo07.ForeColor = Color.Black;
            }
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo10_EditValueChanged(object sender, EventArgs e)
        {
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo08_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBox((TextEdit)sender,0,25);
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo09_EditValueChanged(object sender, EventArgs e)
        {
            DoiMauTextBox((TextEdit)sender, 0, 10);
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo07_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_TruongSo08.Enabled == false || txt_TruongSo09.Enabled == false || txt_TruongSo10.Enabled == false)
                {
                    SendKeys.Send("{Tab}");
                }
                else
                {
                    SendKeys.Send("{Tab}");
                    SendKeys.Send("{Tab}");
                    SendKeys.Send("{Tab}");
                    SendKeys.Send("{Tab}");
                }
            }
           
        }

        private void txt_TruongSo10_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode==Keys.Down)
            {
                if (txt_TruongSo08.Enabled == false || txt_TruongSo09.Enabled == false || txt_TruongSo10.Enabled == false)
                {
                    SendKeys.Send("{Tab}");
                }
                else
                {
                    SendKeys.Send("{Tab}");
                    SendKeys.Send("{Tab}");
                    SendKeys.Send("{Tab}");
                    SendKeys.Send("{Tab}");
                }
               
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (txt_TruongSo08.Enabled == false || txt_TruongSo09.Enabled == false || txt_TruongSo10.Enabled == false)
                {
                    SendKeys.Send("+{Tab}");
                }
                else
                {
                    SendKeys.Send("+{Tab}");
                    SendKeys.Send("+{Tab}");
                    SendKeys.Send("+{Tab}");
                    SendKeys.Send("+{Tab}");
                }
               
            }

        }

        private void txt_TruongSo08_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                if (txt_TruongSo08.Enabled == false || txt_TruongSo09.Enabled == false || txt_TruongSo10.Enabled == false)
                {
                    SendKeys.Send("{Tab}");
                }
                else
                {
                    SendKeys.Send("{Tab}");
                    SendKeys.Send("{Tab}");
                    SendKeys.Send("{Tab}");
                    SendKeys.Send("{Tab}");
                }

            }
            else if (e.KeyCode == Keys.Up)
            {
                if (txt_TruongSo08.Enabled == false || txt_TruongSo09.Enabled == false || txt_TruongSo10.Enabled == false)
                {
                    SendKeys.Send("+{Tab}");
                }
                else
                {
                    SendKeys.Send("+{Tab}");
                    SendKeys.Send("+{Tab}");
                    SendKeys.Send("+{Tab}");
                    SendKeys.Send("+{Tab}");
                }

            }
        }

        public void DoiMauTextBox(TextEdit txt, int sobytenho, int sobytelon)
        {
            if (txt.Text.IndexOf('?') >= 0)
                txt.Text = @"?";
            if (txt.Text != "" && txt.Text != @"?" && (txt.Text.Length > sobytelon || txt.Text.Length < sobytenho))
            {
                txt.BackColor = Color.Red;
                txt.ForeColor = Color.White;
            }
            else
            {
                txt.BackColor = Color.White;
                txt.ForeColor = Color.Black;
            }
        }

        private void txt_TruongSo09_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                if (txt_TruongSo08.Enabled == false || txt_TruongSo09.Enabled == false || txt_TruongSo10.Enabled == false)
                {
                    SendKeys.Send("{Tab}");
                }
                else
                {
                    SendKeys.Send("{Tab}");
                    SendKeys.Send("{Tab}");
                    SendKeys.Send("{Tab}");
                    SendKeys.Send("{Tab}");
                }

            }
            else if (e.KeyCode == Keys.Up)
            {
                if (txt_TruongSo08.Enabled == false || txt_TruongSo09.Enabled == false || txt_TruongSo10.Enabled == false)
                {
                    SendKeys.Send("+{Tab}");
                }
                else
                {
                    SendKeys.Send("+{Tab}");
                    SendKeys.Send("+{Tab}");
                    SendKeys.Send("+{Tab}");
                    SendKeys.Send("+{Tab}");
                }

            }
        }
    }
}
