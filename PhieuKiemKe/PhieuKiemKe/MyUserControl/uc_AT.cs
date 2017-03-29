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
    public partial class UC_AT : UserControl
    {
        public event AllTextChange Changed;
        public UC_AT()
        {
            InitializeComponent();
            uc_AT_Rows1.txt_TruongSo07.Properties.SelectedIndexChanged += Properties_SelectedIndexChanged;
            uc_AT_Rows2.txt_TruongSo07.Properties.SelectedIndexChanged += Properties_SelectedIndexChanged1;
            uc_AT_Rows3.txt_TruongSo07.Properties.SelectedIndexChanged += Properties_SelectedIndexChanged2;
            uc_AT_Rows4.txt_TruongSo07.Properties.SelectedIndexChanged += Properties_SelectedIndexChanged3;
            uc_AT_Rows5.txt_TruongSo07.Properties.SelectedIndexChanged += Properties_SelectedIndexChanged4;
            uc_AT_Rows6.txt_TruongSo07.Properties.SelectedIndexChanged += Properties_SelectedIndexChanged5;
            uc_AT_Rows7.txt_TruongSo07.Properties.SelectedIndexChanged += Properties_SelectedIndexChanged6;
            uc_AT_Rows8.txt_TruongSo07.Properties.SelectedIndexChanged += Properties_SelectedIndexChanged7;
            uc_AT_Rows9.txt_TruongSo07.Properties.SelectedIndexChanged += Properties_SelectedIndexChanged8;
            uc_AT_Rows10.txt_TruongSo07.Properties.SelectedIndexChanged += Properties_SelectedIndexChanged9;

            uc_AT_Rows2.txt_TruongSo08.KeyUp += Txt_TruongSo08_KeyUp;
            uc_AT_Rows3.txt_TruongSo08.KeyUp += Txt_TruongSo08_KeyUp1;
            uc_AT_Rows4.txt_TruongSo08.KeyUp += Txt_TruongSo08_KeyUp2;
            uc_AT_Rows5.txt_TruongSo08.KeyUp += Txt_TruongSo08_KeyUp3;
            uc_AT_Rows6.txt_TruongSo08.KeyUp += Txt_TruongSo08_KeyUp4;
            uc_AT_Rows7.txt_TruongSo08.KeyUp += Txt_TruongSo08_KeyUp5;
            uc_AT_Rows8.txt_TruongSo08.KeyUp += Txt_TruongSo08_KeyUp6;
            uc_AT_Rows9.txt_TruongSo08.KeyUp += Txt_TruongSo08_KeyUp7;
            uc_AT_Rows10.txt_TruongSo08.KeyUp += Txt_TruongSo08_KeyUp8;

            uc_AT_Rows1.txt_TruongSo09.KeyDown += Txt_TruongSo09_KeyDown;
            uc_AT_Rows2.txt_TruongSo09.KeyDown += Txt_TruongSo09_KeyDown1;
            uc_AT_Rows3.txt_TruongSo09.KeyDown += Txt_TruongSo09_KeyDown1;
            uc_AT_Rows4.txt_TruongSo09.KeyDown += Txt_TruongSo09_KeyDown1;
            uc_AT_Rows5.txt_TruongSo09.KeyDown += Txt_TruongSo09_KeyDown1;
            uc_AT_Rows6.txt_TruongSo09.KeyDown += Txt_TruongSo09_KeyDown1;
            uc_AT_Rows7.txt_TruongSo09.KeyDown += Txt_TruongSo09_KeyDown1;
            uc_AT_Rows8.txt_TruongSo09.KeyDown += Txt_TruongSo09_KeyDown1;
            uc_AT_Rows9.txt_TruongSo09.KeyDown += Txt_TruongSo09_KeyDown1;
            uc_AT_Rows10.txt_TruongSo09.KeyDown += Txt_TruongSo09_KeyDown2;



        }

       

        private void Txt_TruongSo09_KeyDown2(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Up)
            {
                SendKeys.Send("+{Tab}");
                SendKeys.Send("+{Tab}");
                SendKeys.Send("+{Tab}");
                SendKeys.Send("+{Tab}");
            }
        }

        private void Txt_TruongSo09_KeyDown1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                SendKeys.Send("{Tab}");
                SendKeys.Send("{Tab}");
                SendKeys.Send("{Tab}");
                SendKeys.Send("{Tab}");
            }
            else if (e.KeyCode == Keys.Up)
            {
                SendKeys.Send("+{Tab}");
                SendKeys.Send("+{Tab}");
                SendKeys.Send("+{Tab}");
                SendKeys.Send("+{Tab}");
            }

        }
        private void Txt_TruongSo09_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                SendKeys.Send("{Tab}");
                SendKeys.Send("{Tab}");
                SendKeys.Send("{Tab}");
                SendKeys.Send("{Tab}");
            }

        }

        private void Txt_TruongSo08_KeyUp8(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(uc_AT_Rows9.txt_TruongSo08.Text))
            {
                if (e.KeyCode == Keys.Divide)
                {
                    CopyDuLieuVaDuaConTroVeCuoi(uc_AT_Rows9.txt_TruongSo08, uc_AT_Rows10.txt_TruongSo08);
                }

            }
        }

        private void Txt_TruongSo08_KeyUp7(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(uc_AT_Rows8.txt_TruongSo08.Text))
            {
                if (e.KeyCode == Keys.Divide)
                {
                    CopyDuLieuVaDuaConTroVeCuoi(uc_AT_Rows8.txt_TruongSo08, uc_AT_Rows9.txt_TruongSo08);
                }

            }
        }

        private void Txt_TruongSo08_KeyUp6(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(uc_AT_Rows7.txt_TruongSo08.Text))
            {
                if (e.KeyCode == Keys.Divide)
                {
                    CopyDuLieuVaDuaConTroVeCuoi(uc_AT_Rows7.txt_TruongSo08, uc_AT_Rows8.txt_TruongSo08);
                }

            }
        }

        private void Txt_TruongSo08_KeyUp5(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(uc_AT_Rows6.txt_TruongSo08.Text))
            {
                if (e.KeyCode == Keys.Divide)
                {
                    CopyDuLieuVaDuaConTroVeCuoi(uc_AT_Rows6.txt_TruongSo08, uc_AT_Rows7.txt_TruongSo08);
                }

            }
        }

        private void Txt_TruongSo08_KeyUp4(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(uc_AT_Rows5.txt_TruongSo08.Text))
            {
                if (e.KeyCode == Keys.Divide)
                {
                    CopyDuLieuVaDuaConTroVeCuoi(uc_AT_Rows5.txt_TruongSo08, uc_AT_Rows6.txt_TruongSo08);
                }

            }
        }

        private void Txt_TruongSo08_KeyUp3(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(uc_AT_Rows4.txt_TruongSo08.Text))
            {
                if (e.KeyCode == Keys.Divide)
                {
                    CopyDuLieuVaDuaConTroVeCuoi(uc_AT_Rows4.txt_TruongSo08, uc_AT_Rows5.txt_TruongSo08);
                }

            }
        }

        private void Txt_TruongSo08_KeyUp2(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(uc_AT_Rows3.txt_TruongSo08.Text))
            {
                if (e.KeyCode == Keys.Divide)
                {
                    CopyDuLieuVaDuaConTroVeCuoi(uc_AT_Rows3.txt_TruongSo08, uc_AT_Rows4.txt_TruongSo08);
                }

            }
        }

        private void Txt_TruongSo08_KeyUp1(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(uc_AT_Rows2.txt_TruongSo08.Text))
            {
                if (e.KeyCode == Keys.Divide)
                {
                    CopyDuLieuVaDuaConTroVeCuoi(uc_AT_Rows2.txt_TruongSo08, uc_AT_Rows3.txt_TruongSo08);

                }
            }
        }

        private void Txt_TruongSo08_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(uc_AT_Rows1.txt_TruongSo08.Text))
            {
                if (e.KeyCode == Keys.Divide)
                {
                    CopyDuLieuVaDuaConTroVeCuoi(uc_AT_Rows1.txt_TruongSo08, uc_AT_Rows2.txt_TruongSo08);
                }
                
            }
            
        }
        private void Properties_SelectedIndexChanged9(object sender, EventArgs e)
        {
            VoHieuHoaCacTruongConLai(uc_AT_Rows10);
        }
        private void Properties_SelectedIndexChanged8(object sender, EventArgs e)
        {
            if (uc_AT_Rows8.txt_TruongSo07.SelectedIndex != 5 &&
                uc_AT_Rows8.txt_TruongSo07.SelectedIndex != 6 &&
                uc_AT_Rows8.txt_TruongSo07.SelectedIndex != 7)
            {
                if (uc_AT_Rows9.txt_TruongSo07.SelectedIndex == 5 ||
                    uc_AT_Rows9.txt_TruongSo07.SelectedIndex == 6 ||
                    uc_AT_Rows9.txt_TruongSo07.SelectedIndex == 7 ||
                    uc_AT_Rows9.txt_TruongSo07.SelectedIndex == -1)
                {
                    uc_AT_Rows10.txt_TruongSo07.SelectedIndex = uc_AT_Rows9.txt_TruongSo07.SelectedIndex;
                }
            }
            VoHieuHoaCacTruongConLai(uc_AT_Rows9);
        }

        private void Properties_SelectedIndexChanged7(object sender, EventArgs e)
        {

            if (uc_AT_Rows7.txt_TruongSo07.SelectedIndex != 5 &&
                uc_AT_Rows7.txt_TruongSo07.SelectedIndex != 6 &&
                uc_AT_Rows7.txt_TruongSo07.SelectedIndex != 7)
            {
                if (uc_AT_Rows8.txt_TruongSo07.SelectedIndex == 5 ||
                    uc_AT_Rows8.txt_TruongSo07.SelectedIndex == 6 ||
                    uc_AT_Rows8.txt_TruongSo07.SelectedIndex == 7 ||
                    uc_AT_Rows8.txt_TruongSo07.SelectedIndex == -1)
                {
                    
                    uc_AT_Rows9.txt_TruongSo07.SelectedIndex = uc_AT_Rows8.txt_TruongSo07.SelectedIndex;
                    uc_AT_Rows10.txt_TruongSo07.SelectedIndex = uc_AT_Rows8.txt_TruongSo07.SelectedIndex;
                }
            }
            VoHieuHoaCacTruongConLai(uc_AT_Rows8);
        }

        private void Properties_SelectedIndexChanged6(object sender, EventArgs e)
        {
            if (uc_AT_Rows6.txt_TruongSo07.SelectedIndex != 5 &&
                uc_AT_Rows6.txt_TruongSo07.SelectedIndex != 6 &&
                uc_AT_Rows6.txt_TruongSo07.SelectedIndex != 7)
            {
                if (uc_AT_Rows7.txt_TruongSo07.SelectedIndex == 5 ||
                    uc_AT_Rows7.txt_TruongSo07.SelectedIndex == 6 ||
                    uc_AT_Rows7.txt_TruongSo07.SelectedIndex == 7 ||
                    uc_AT_Rows7.txt_TruongSo07.SelectedIndex == -1)
                {
                    
                    uc_AT_Rows8.txt_TruongSo07.SelectedIndex = uc_AT_Rows7.txt_TruongSo07.SelectedIndex;
                    uc_AT_Rows9.txt_TruongSo07.SelectedIndex = uc_AT_Rows7.txt_TruongSo07.SelectedIndex;
                    uc_AT_Rows10.txt_TruongSo07.SelectedIndex = uc_AT_Rows7.txt_TruongSo07.SelectedIndex;
                }
            }
            VoHieuHoaCacTruongConLai(uc_AT_Rows7);
        }

        private void Properties_SelectedIndexChanged5(object sender, EventArgs e)
        {
            if (uc_AT_Rows5.txt_TruongSo07.SelectedIndex != 5 &&
                uc_AT_Rows5.txt_TruongSo07.SelectedIndex != 6 &&
                uc_AT_Rows5.txt_TruongSo07.SelectedIndex != 7)
            {
                if (uc_AT_Rows6.txt_TruongSo07.SelectedIndex == 5 ||
                    uc_AT_Rows6.txt_TruongSo07.SelectedIndex == 6 ||
                    uc_AT_Rows6.txt_TruongSo07.SelectedIndex == 7 ||
                    uc_AT_Rows6.txt_TruongSo07.SelectedIndex == -1)
                {
                    
                    uc_AT_Rows7.txt_TruongSo07.SelectedIndex = uc_AT_Rows6.txt_TruongSo07.SelectedIndex;
                    uc_AT_Rows8.txt_TruongSo07.SelectedIndex = uc_AT_Rows6.txt_TruongSo07.SelectedIndex;
                    uc_AT_Rows9.txt_TruongSo07.SelectedIndex = uc_AT_Rows6.txt_TruongSo07.SelectedIndex;
                    uc_AT_Rows10.txt_TruongSo07.SelectedIndex = uc_AT_Rows6.txt_TruongSo07.SelectedIndex;
                }
            }
            VoHieuHoaCacTruongConLai(uc_AT_Rows6);
        }

        private void Properties_SelectedIndexChanged4(object sender, EventArgs e)
        {
            if (uc_AT_Rows4.txt_TruongSo07.SelectedIndex != 5 && 
                uc_AT_Rows4.txt_TruongSo07.SelectedIndex != 6 &&
                uc_AT_Rows4.txt_TruongSo07.SelectedIndex != 7)
            {
                if (uc_AT_Rows5.txt_TruongSo07.SelectedIndex == 5 ||
                    uc_AT_Rows5.txt_TruongSo07.SelectedIndex == 6 ||
                    uc_AT_Rows5.txt_TruongSo07.SelectedIndex == 7 ||
                    uc_AT_Rows5.txt_TruongSo07.SelectedIndex == -1)
                {

                    uc_AT_Rows6.txt_TruongSo07.SelectedIndex = uc_AT_Rows5.txt_TruongSo07.SelectedIndex;
                    uc_AT_Rows7.txt_TruongSo07.SelectedIndex = uc_AT_Rows5.txt_TruongSo07.SelectedIndex;
                    uc_AT_Rows8.txt_TruongSo07.SelectedIndex = uc_AT_Rows5.txt_TruongSo07.SelectedIndex;
                    uc_AT_Rows9.txt_TruongSo07.SelectedIndex = uc_AT_Rows5.txt_TruongSo07.SelectedIndex;
                    uc_AT_Rows10.txt_TruongSo07.SelectedIndex = uc_AT_Rows5.txt_TruongSo07.SelectedIndex;
                }
            }
            VoHieuHoaCacTruongConLai(uc_AT_Rows5);
        }

        private void Properties_SelectedIndexChanged3(object sender, EventArgs e)
        {
            if (uc_AT_Rows3.txt_TruongSo07.SelectedIndex != 5 && 
                uc_AT_Rows3.txt_TruongSo07.SelectedIndex != 6 &&
                uc_AT_Rows3.txt_TruongSo07.SelectedIndex != 7)
            {
                if (uc_AT_Rows4.txt_TruongSo07.SelectedIndex == 5 ||
                   uc_AT_Rows4.txt_TruongSo07.SelectedIndex == 6 ||
                   uc_AT_Rows4.txt_TruongSo07.SelectedIndex == 7 ||
                   uc_AT_Rows4.txt_TruongSo07.SelectedIndex == -1)
                {

                    uc_AT_Rows5.txt_TruongSo07.SelectedIndex = uc_AT_Rows4.txt_TruongSo07.SelectedIndex;
                    uc_AT_Rows6.txt_TruongSo07.SelectedIndex = uc_AT_Rows4.txt_TruongSo07.SelectedIndex;
                    uc_AT_Rows7.txt_TruongSo07.SelectedIndex = uc_AT_Rows4.txt_TruongSo07.SelectedIndex;
                    uc_AT_Rows8.txt_TruongSo07.SelectedIndex = uc_AT_Rows4.txt_TruongSo07.SelectedIndex;
                    uc_AT_Rows9.txt_TruongSo07.SelectedIndex = uc_AT_Rows4.txt_TruongSo07.SelectedIndex;
                    uc_AT_Rows10.txt_TruongSo07.SelectedIndex = uc_AT_Rows4.txt_TruongSo07.SelectedIndex;
                }
            }
            VoHieuHoaCacTruongConLai(uc_AT_Rows4);

        }

        private void Properties_SelectedIndexChanged2(object sender, EventArgs e)
        {
            if (uc_AT_Rows2.txt_TruongSo07.SelectedIndex != 5 && 
                uc_AT_Rows2.txt_TruongSo07.SelectedIndex != 6 &&
                uc_AT_Rows2.txt_TruongSo07.SelectedIndex != 7)
            {
                if (uc_AT_Rows3.txt_TruongSo07.SelectedIndex == 5 ||
                uc_AT_Rows3.txt_TruongSo07.SelectedIndex == 6 ||
                uc_AT_Rows3.txt_TruongSo07.SelectedIndex == 7 ||
                uc_AT_Rows3.txt_TruongSo07.SelectedIndex == -1)
                {
                    uc_AT_Rows4.txt_TruongSo07.SelectedIndex = uc_AT_Rows3.txt_TruongSo07.SelectedIndex;
                    uc_AT_Rows5.txt_TruongSo07.SelectedIndex = uc_AT_Rows3.txt_TruongSo07.SelectedIndex;
                    uc_AT_Rows6.txt_TruongSo07.SelectedIndex = uc_AT_Rows3.txt_TruongSo07.SelectedIndex;
                    uc_AT_Rows7.txt_TruongSo07.SelectedIndex = uc_AT_Rows3.txt_TruongSo07.SelectedIndex;
                    uc_AT_Rows8.txt_TruongSo07.SelectedIndex = uc_AT_Rows3.txt_TruongSo07.SelectedIndex;
                    uc_AT_Rows9.txt_TruongSo07.SelectedIndex = uc_AT_Rows3.txt_TruongSo07.SelectedIndex;
                    uc_AT_Rows10.txt_TruongSo07.SelectedIndex = uc_AT_Rows3.txt_TruongSo07.SelectedIndex;
                }
            }
            VoHieuHoaCacTruongConLai(uc_AT_Rows3);

        }

        private void Properties_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (uc_AT_Rows1.txt_TruongSo07.SelectedIndex != 5 && 
                uc_AT_Rows1.txt_TruongSo07.SelectedIndex != 6 &&
                uc_AT_Rows1.txt_TruongSo07.SelectedIndex != 7)
            {
                if (uc_AT_Rows2.txt_TruongSo07.SelectedIndex == 5 ||
                   uc_AT_Rows2.txt_TruongSo07.SelectedIndex == 6 ||
                   uc_AT_Rows2.txt_TruongSo07.SelectedIndex == 7 ||
                   uc_AT_Rows2.txt_TruongSo07.SelectedIndex == -1)
                {

                    uc_AT_Rows3.txt_TruongSo07.SelectedIndex = uc_AT_Rows2.txt_TruongSo07.SelectedIndex;
                    uc_AT_Rows4.txt_TruongSo07.SelectedIndex = uc_AT_Rows2.txt_TruongSo07.SelectedIndex;
                    uc_AT_Rows5.txt_TruongSo07.SelectedIndex = uc_AT_Rows2.txt_TruongSo07.SelectedIndex;
                    uc_AT_Rows6.txt_TruongSo07.SelectedIndex = uc_AT_Rows2.txt_TruongSo07.SelectedIndex;
                    uc_AT_Rows7.txt_TruongSo07.SelectedIndex = uc_AT_Rows2.txt_TruongSo07.SelectedIndex;
                    uc_AT_Rows8.txt_TruongSo07.SelectedIndex = uc_AT_Rows2.txt_TruongSo07.SelectedIndex;
                    uc_AT_Rows9.txt_TruongSo07.SelectedIndex = uc_AT_Rows2.txt_TruongSo07.SelectedIndex;
                    uc_AT_Rows10.txt_TruongSo07.SelectedIndex = uc_AT_Rows2.txt_TruongSo07.SelectedIndex;
                }
            }
            VoHieuHoaCacTruongConLai(uc_AT_Rows2);

        }

        private void Properties_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uc_AT_Rows1.txt_TruongSo07.SelectedIndex == 5 ||
                uc_AT_Rows1.txt_TruongSo07.SelectedIndex == 6 ||
                uc_AT_Rows1.txt_TruongSo07.SelectedIndex == 7 ||
                uc_AT_Rows1.txt_TruongSo07.SelectedIndex == -1)
            {
                uc_AT_Rows2.txt_TruongSo07.SelectedIndex = uc_AT_Rows1.txt_TruongSo07.SelectedIndex;
                uc_AT_Rows3.txt_TruongSo07.SelectedIndex = uc_AT_Rows1.txt_TruongSo07.SelectedIndex;
                uc_AT_Rows4.txt_TruongSo07.SelectedIndex = uc_AT_Rows1.txt_TruongSo07.SelectedIndex;
                uc_AT_Rows5.txt_TruongSo07.SelectedIndex = uc_AT_Rows1.txt_TruongSo07.SelectedIndex;
                uc_AT_Rows6.txt_TruongSo07.SelectedIndex = uc_AT_Rows1.txt_TruongSo07.SelectedIndex;
                uc_AT_Rows7.txt_TruongSo07.SelectedIndex = uc_AT_Rows1.txt_TruongSo07.SelectedIndex;
                uc_AT_Rows8.txt_TruongSo07.SelectedIndex = uc_AT_Rows1.txt_TruongSo07.SelectedIndex;
                uc_AT_Rows9.txt_TruongSo07.SelectedIndex = uc_AT_Rows1.txt_TruongSo07.SelectedIndex;
                uc_AT_Rows10.txt_TruongSo07.SelectedIndex = uc_AT_Rows1.txt_TruongSo07.SelectedIndex;
            }

            VoHieuHoaCacTruongConLai(uc_AT_Rows1);
        }

        private void UC_AT_Load(object sender, EventArgs e)
        {
            resetData();
            setSTT();
        }
        private void setSTT()
        {
            uc_AT_Rows1.txt_STT.Text = "01";
            uc_AT_Rows2.txt_STT.Text = "02";
            uc_AT_Rows3.txt_STT.Text = "03";
            uc_AT_Rows4.txt_STT.Text = "04";
            uc_AT_Rows5.txt_STT.Text = "05";
            uc_AT_Rows6.txt_STT.Text = "06";
            uc_AT_Rows7.txt_STT.Text = "07";
            uc_AT_Rows8.txt_STT.Text = "08";
            uc_AT_Rows9.txt_STT.Text = "09";
            uc_AT_Rows10.txt_STT.Text = "10";
        }
        public void resetData()
        {
            txt_TruongSo02.Text = "";
            txt_TruongSo03.Text = "";
            txt_TruongSo04.Text = "";
            txt_TruongSo05.Text = "";
            uc_AT_Rows1.resetData();    
            uc_AT_Rows2.resetData();    
            uc_AT_Rows3.resetData();    
            uc_AT_Rows4.resetData();    
            uc_AT_Rows5.resetData();    
            uc_AT_Rows6.resetData();    
            uc_AT_Rows7.resetData();    
            uc_AT_Rows8.resetData();    
            uc_AT_Rows9.resetData();    
            uc_AT_Rows10.resetData();
            txt_TruongSo02.Focus();
        }

        public bool isEmpty()
        {
            return string.IsNullOrEmpty(txt_TruongSo02.Text) &&
                   string.IsNullOrEmpty(txt_TruongSo03.Text) &&
                   string.IsNullOrEmpty(txt_TruongSo04.Text) &&
                   string.IsNullOrEmpty(txt_TruongSo05.Text) &&
                   uc_AT_Rows1.isEmpty() &&
                   uc_AT_Rows2.isEmpty() &&
                   uc_AT_Rows3.isEmpty() &&
                   uc_AT_Rows4.isEmpty() &&
                   uc_AT_Rows5.isEmpty() &&
                   uc_AT_Rows6.isEmpty() &&
                   uc_AT_Rows7.isEmpty() &&
                   uc_AT_Rows8.isEmpty() &&
                   uc_AT_Rows9.isEmpty() &&
                   uc_AT_Rows10.isEmpty();
        }
        public void CopyDuLieuVaDuaConTroVeCuoi(TextEdit txtCopy, TextEdit txtHienTai)
        {
            string a = txtCopy.Text;
            txtHienTai.Text = a.Replace("/", "");
            txtHienTai.SelectionLength = 0;
            txtHienTai.SelectionStart = txtHienTai.Text.Length;
        }

        public void VoHieuHoaCacTruongConLai(uc_AT_Rows uc)
        {
            if (uc.txt_TruongSo07.SelectedIndex == 0 ||
                uc.txt_TruongSo07.SelectedIndex == 1 ||
                uc.txt_TruongSo07.SelectedIndex == 2 ||
                uc.txt_TruongSo07.SelectedIndex == 3 )
            {
                uc.txt_TruongSo08.Text = "";
                uc.txt_TruongSo09.Text = "";
                uc.txt_TruongSo10.Text = "";
                uc.txt_TruongSo08.Enabled = false;
                uc.txt_TruongSo09.Enabled = false;
                uc.txt_TruongSo10.Enabled = false;
            }
            else
            {
                uc.txt_TruongSo08.Enabled = true;
                uc.txt_TruongSo09.Enabled = true;
                uc.txt_TruongSo10.Enabled = true;
            }
          
        }

        public void SaveData(string idimage)
        {
            uc_AT_Rows1.SaveData(idimage, txt_TruongSo02.Text, txt_TruongSo03.Text, txt_TruongSo04.Text, txt_TruongSo05.Text, "1");
            uc_AT_Rows2.SaveData(idimage, txt_TruongSo02.Text, txt_TruongSo03.Text, txt_TruongSo04.Text, txt_TruongSo05.Text, "2");
            uc_AT_Rows3.SaveData(idimage, txt_TruongSo02.Text, txt_TruongSo03.Text, txt_TruongSo04.Text, txt_TruongSo05.Text, "3");
            uc_AT_Rows4.SaveData(idimage, txt_TruongSo02.Text, txt_TruongSo03.Text, txt_TruongSo04.Text, txt_TruongSo05.Text, "4");
            uc_AT_Rows5.SaveData(idimage, txt_TruongSo02.Text, txt_TruongSo03.Text, txt_TruongSo04.Text, txt_TruongSo05.Text, "5");
            uc_AT_Rows6.SaveData(idimage, txt_TruongSo02.Text, txt_TruongSo03.Text, txt_TruongSo04.Text, txt_TruongSo05.Text, "6");
            uc_AT_Rows7.SaveData(idimage, txt_TruongSo02.Text, txt_TruongSo03.Text, txt_TruongSo04.Text, txt_TruongSo05.Text, "7");
            uc_AT_Rows8.SaveData(idimage, txt_TruongSo02.Text, txt_TruongSo03.Text, txt_TruongSo04.Text, txt_TruongSo05.Text, "8");
            uc_AT_Rows9.SaveData(idimage, txt_TruongSo02.Text, txt_TruongSo03.Text, txt_TruongSo04.Text, txt_TruongSo05.Text, "9");
            uc_AT_Rows10.SaveData(idimage,txt_TruongSo02.Text, txt_TruongSo03.Text, txt_TruongSo04.Text, txt_TruongSo05.Text, "10");
        }

        private void txt_TruongSo02_EditValueChanged(object sender, EventArgs e)
        {
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo03_EditValueChanged(object sender, EventArgs e)
        {
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo04_EditValueChanged(object sender, EventArgs e)
        {
            Changed?.Invoke(sender, e);
        }

        private void txt_TruongSo05_EditValueChanged(object sender, EventArgs e)
        {
            Changed?.Invoke(sender, e);}
    }
}
