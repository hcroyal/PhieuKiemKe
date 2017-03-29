
using PhieuKiemKe.Properties;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PhieuKiemKe.MyForm
{
    public partial class frm_Check_DeSo : XtraForm
    {
        private bool _Flag = false;

        public frm_Check_DeSo()
        {
            InitializeComponent();
        }

        private void ResetData()
        {
            uc_AE1.ResetData();
            uc_AE2.ResetData();

            uC_AT1.resetData();
            uC_AT2.resetData();
            uc_PictureBox1.imageBox1.Image = null;
        }

        private void Compare_TextBox(TextEdit t1, TextEdit t2)
        {
            if (!string.IsNullOrEmpty(t1.Text) || !string.IsNullOrEmpty(t2.Text))
            {
                if (t1.Text != t2.Text)
                {
                    t1.BackColor = Color.PaleVioletRed;
                    t1.ForeColor = Color.White;
                    t2.BackColor = Color.PaleVioletRed;
                    t2.ForeColor = Color.White;
                }
            }
            else
            {
                t1.BackColor = Color.White;
                t1.ForeColor = Color.Black;
                t2.BackColor = Color.White;
                t2.ForeColor = Color.Black;
            }
        }

        private void Compare_LookUpEdit(LookUpEdit t1, LookUpEdit t2)
        {
            if (t1.ItemIndex != t2.ItemIndex)
            {
                t1.BackColor = Color.PaleVioletRed;
                t2.BackColor = Color.PaleVioletRed;
            }
            else
            {
                t1.BackColor = Color.White;
                t2.BackColor = Color.White;
            }
        }

        private void frm_Check_Load(object sender, EventArgs e)
        {
            try
            {
                lb_fBatchName.Text = Global.StrBatch;
                tp_AE_DeSo1.PageVisible = false;
                tp_AT_DeSo1.PageVisible = false;

                tp_AE_DeSo2.PageVisible = false;
                tp_AT_DeSo2.PageVisible = false;

                var soloi = (from w in Global.db.GetSoLoi_CheckDeSo(Global.StrBatch) select w.Column1).FirstOrDefault();
                lb_Loi.Text = soloi + " Lỗi";

                if (Global.LoaiPhieu == "AE")
                {
                    tp_AE_DeSo1.PageVisible = true;
                    tp_AE_DeSo2.PageVisible = true;
                }
                else if (Global.LoaiPhieu == "AT")
                {
                    tp_AT_DeSo1.PageVisible = true;
                    tp_AT_DeSo2.PageVisible = true;
                }
                btn_Luu_DeSo1.Visible = false;
                btn_Luu_DeSo2.Visible = false;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;

                uc_AE1.Changed += Uc_User1_Changed;
                uc_AE1.uc_AE_Rows1.Changed += Uc_User1_Changed;
                uc_AE1.uc_AE_Rows2.Changed += Uc_User1_Changed;
                uc_AE1.uc_AE_Rows3.Changed += Uc_User1_Changed;
                uc_AE1.uc_AE_Rows4.Changed += Uc_User1_Changed;
                uc_AE1.uc_AE_Rows5.Changed += Uc_User1_Changed;
                uc_AE1.uc_AE_Rows6.Changed += Uc_User1_Changed;
                uc_AE1.uc_AE_Rows7.Changed += Uc_User1_Changed;
                uc_AE1.uc_AE_Rows8.Changed += Uc_User1_Changed;
                uc_AE1.uc_AE_Rows9.Changed += Uc_User1_Changed;
                uc_AE1.uc_AE_Rows10.Changed += Uc_User1_Changed;

                uC_AT1.Changed += Uc_User1_Changed;
                uC_AT1.uc_AT_Rows1.Changed += Uc_User1_Changed;
                uC_AT1.uc_AT_Rows2.Changed += Uc_User1_Changed;
                uC_AT1.uc_AT_Rows3.Changed += Uc_User1_Changed;
                uC_AT1.uc_AT_Rows4.Changed += Uc_User1_Changed;
                uC_AT1.uc_AT_Rows5.Changed += Uc_User1_Changed;
                uC_AT1.uc_AT_Rows6.Changed += Uc_User1_Changed;
                uC_AT1.uc_AT_Rows7.Changed += Uc_User1_Changed;
                uC_AT1.uc_AT_Rows8.Changed += Uc_User1_Changed;
                uC_AT1.uc_AT_Rows9.Changed += Uc_User1_Changed;
                uC_AT1.uc_AT_Rows10.Changed += Uc_User1_Changed;

                uc_AE2.Changed += Uc_User2_Changed;
                uc_AE2.uc_AE_Rows1.Changed += Uc_User2_Changed;
                uc_AE2.uc_AE_Rows2.Changed += Uc_User2_Changed;
                uc_AE2.uc_AE_Rows3.Changed += Uc_User2_Changed;
                uc_AE2.uc_AE_Rows4.Changed += Uc_User2_Changed;
                uc_AE2.uc_AE_Rows5.Changed += Uc_User2_Changed;
                uc_AE2.uc_AE_Rows6.Changed += Uc_User2_Changed;
                uc_AE2.uc_AE_Rows7.Changed += Uc_User2_Changed;
                uc_AE2.uc_AE_Rows8.Changed += Uc_User2_Changed;
                uc_AE2.uc_AE_Rows9.Changed += Uc_User2_Changed;
                uc_AE2.uc_AE_Rows10.Changed += Uc_User2_Changed;

                uC_AT2.Changed += Uc_User2_Changed;
                uC_AT2.uc_AT_Rows1.Changed += Uc_User2_Changed;
                uC_AT2.uc_AT_Rows2.Changed += Uc_User2_Changed;
                uC_AT2.uc_AT_Rows3.Changed += Uc_User2_Changed;
                uC_AT2.uc_AT_Rows4.Changed += Uc_User2_Changed;
                uC_AT2.uc_AT_Rows5.Changed += Uc_User2_Changed;
                uC_AT2.uc_AT_Rows6.Changed += Uc_User2_Changed;
                uC_AT2.uc_AT_Rows7.Changed += Uc_User2_Changed;
                uC_AT2.uc_AT_Rows8.Changed += Uc_User2_Changed;
                uC_AT2.uc_AT_Rows9.Changed += Uc_User2_Changed;
                uC_AT2.uc_AT_Rows10.Changed += Uc_User2_Changed;
            }
            catch (Exception i)
            {
                MessageBox.Show("Lỗi" + i);
            }
        }

        private void Uc_User1_Changed(object sender, EventArgs e)
        {
            btn_Luu_DeSo1.Visible = false;
            btn_SuaVaLuu_User1.Visible = true;
        }

        private void Uc_User2_Changed(object sender, EventArgs e)
        {
            btn_Luu_DeSo2.Visible = false;
            btn_SuaVaLuu_User2.Visible = true;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            try
            {
                var nhap =
                (from w in Global.db.tbl_Images
                    where w.fbatchname == Global.StrBatch && w.ReadImageDESo == 2
                    select w.idimage).Count();
                var sohinh =
                    (from w in Global.db.tbl_Images where w.fbatchname == Global.StrBatch select w.idimage).Count();
                var check =
                (from w in Global.db.tbl_MissImage_DESOs
                    where w.fBatchName == Global.StrBatch && w.Submit == 0
                    select w.IdImage).Count();
                if (sohinh > nhap)
                {
                    MessageBox.Show("Chưa nhập xong DeSo!");
                    return;
                }
                if (check > 0)
                {
                    var listUser =
                    (from w in Global.db.tbl_MissImage_DESOs
                        where w.fBatchName == Global.StrBatch && w.Submit == 0
                        select w.UserName).ToList();
                    string sss = "";
                    foreach (var item in listUser)
                    {
                        sss += item + "\r\n";
                    }

                    if (listUser.Count > 0)
                    {
                        MessageBox.Show("Những user lấy hình về nhưng không nhập: \r\n" + sss);
                        return;
                    }
                }
                string temp = GetImage_DeSo();
                if (temp == "NULL")
                {
                    uc_PictureBox1.imageBox1.Dispose();
                    MessageBox.Show("Hết Hình!");
                    return;
                }
                if (temp == "Error")
                {
                    MessageBox.Show("Lỗi load hình");
                    return;
                }
                Load_DeSo(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;

                btn_Start.Visible = false;
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }
        }

        private void Load_DeSo(string strBatch, string idimage)
        {
            try
            {
                var deso = (from w in Global.db.tbl_DESOs
                    where w.fBatchName == strBatch && w.IdImage == idimage
                    select new
                    {
                        w.UserName,
                        w.Truong_02,
                        w.Truong_03,
                        w.Truong_04,
                        w.Truong_05,
                        w.Truong_07,
                        w.Truong_08,
                        w.Truong_09,
                        w.Truong_10
                    }).ToList();
                lb_username1.Text = deso[0].UserName;
                lb_username2.Text = deso[11].UserName;

                if (Global.LoaiPhieu == "AE")
                {
                    tabcontrol_DeSo1.SelectedTabPage = tp_AE_DeSo1;
                    uc_AE1.txt_TruongSo02.Text = deso[0].Truong_02;
                    uc_AE1.txt_TruongSo03.Text = deso[0].Truong_03;
                    uc_AE1.txt_TruongSo04.Text = deso[0].Truong_04;
                    uc_AE1.txt_TruongSo05.Text = deso[0].Truong_05;

                    uc_AE1.uc_AE_Rows1.txt_TruongSo09.Text = deso[0].Truong_09;
                    uc_AE1.uc_AE_Rows2.txt_TruongSo09.Text = deso[1].Truong_09;
                    uc_AE1.uc_AE_Rows3.txt_TruongSo09.Text = deso[2].Truong_09;
                    uc_AE1.uc_AE_Rows4.txt_TruongSo09.Text = deso[3].Truong_09;
                    uc_AE1.uc_AE_Rows5.txt_TruongSo09.Text = deso[4].Truong_09;
                    uc_AE1.uc_AE_Rows6.txt_TruongSo09.Text = deso[5].Truong_09;
                    uc_AE1.uc_AE_Rows7.txt_TruongSo09.Text = deso[6].Truong_09;
                    uc_AE1.uc_AE_Rows8.txt_TruongSo09.Text = deso[7].Truong_09;
                    uc_AE1.uc_AE_Rows9.txt_TruongSo09.Text = deso[8].Truong_09;
                    uc_AE1.uc_AE_Rows10.txt_TruongSo09.Text = deso[9].Truong_09;

                    tabcontrol_DeSo2.SelectedTabPage = tp_AE_DeSo2;
                    uc_AE2.txt_TruongSo02.Text = deso[10].Truong_02;
                    uc_AE2.txt_TruongSo03.Text = deso[10].Truong_03;
                    uc_AE2.txt_TruongSo04.Text = deso[10].Truong_04;
                    uc_AE2.txt_TruongSo05.Text = deso[10].Truong_05;

                    uc_AE2.uc_AE_Rows1.txt_TruongSo09.Text = deso[10].Truong_09;
                    uc_AE2.uc_AE_Rows2.txt_TruongSo09.Text = deso[11].Truong_09;
                    uc_AE2.uc_AE_Rows3.txt_TruongSo09.Text = deso[12].Truong_09;
                    uc_AE2.uc_AE_Rows4.txt_TruongSo09.Text = deso[13].Truong_09;
                    uc_AE2.uc_AE_Rows5.txt_TruongSo09.Text = deso[14].Truong_09;
                    uc_AE2.uc_AE_Rows6.txt_TruongSo09.Text = deso[15].Truong_09;
                    uc_AE2.uc_AE_Rows7.txt_TruongSo09.Text = deso[16].Truong_09;
                    uc_AE2.uc_AE_Rows8.txt_TruongSo09.Text = deso[17].Truong_09;
                    uc_AE2.uc_AE_Rows9.txt_TruongSo09.Text = deso[18].Truong_09;
                    uc_AE2.uc_AE_Rows10.txt_TruongSo09.Text = deso[19].Truong_09;
                    uc_AE1.txt_TruongSo02.Focus();

                }
                else if (Global.LoaiPhieu == "AT")
                {
                    //Load User 1
                    tabcontrol_DeSo1.SelectedTabPage = tp_AE_DeSo1;
                    uC_AT1.txt_TruongSo02.Text = deso[0].Truong_02;
                    uC_AT1.txt_TruongSo03.Text = deso[0].Truong_03;
                    uC_AT1.txt_TruongSo04.Text = deso[0].Truong_04;
                    uC_AT1.txt_TruongSo05.Text = deso[0].Truong_05;

                    uC_AT1.uc_AT_Rows1.txt_TruongSo07.Text = deso[0].Truong_07;
                    uC_AT1.uc_AT_Rows1.txt_TruongSo08.Text = deso[0].Truong_08;
                    uC_AT1.uc_AT_Rows1.txt_TruongSo09.Text = deso[0].Truong_09;
                    uC_AT1.uc_AT_Rows1.txt_TruongSo10.Text = deso[0].Truong_10;

                    uC_AT1.uc_AT_Rows2.txt_TruongSo07.Text = deso[1].Truong_07;
                    uC_AT1.uc_AT_Rows2.txt_TruongSo08.Text = deso[1].Truong_08;
                    uC_AT1.uc_AT_Rows2.txt_TruongSo09.Text = deso[1].Truong_09;
                    uC_AT1.uc_AT_Rows2.txt_TruongSo10.Text = deso[1].Truong_10;

                    uC_AT1.uc_AT_Rows3.txt_TruongSo07.Text = deso[2].Truong_07;
                    uC_AT1.uc_AT_Rows3.txt_TruongSo08.Text = deso[2].Truong_08;
                    uC_AT1.uc_AT_Rows3.txt_TruongSo09.Text = deso[2].Truong_09;
                    uC_AT1.uc_AT_Rows3.txt_TruongSo10.Text = deso[2].Truong_10;

                    uC_AT1.uc_AT_Rows4.txt_TruongSo07.Text = deso[3].Truong_07;
                    uC_AT1.uc_AT_Rows4.txt_TruongSo08.Text = deso[3].Truong_08;
                    uC_AT1.uc_AT_Rows4.txt_TruongSo09.Text = deso[3].Truong_09;
                    uC_AT1.uc_AT_Rows4.txt_TruongSo10.Text = deso[3].Truong_10;

                    uC_AT1.uc_AT_Rows5.txt_TruongSo07.Text = deso[4].Truong_07;
                    uC_AT1.uc_AT_Rows5.txt_TruongSo08.Text = deso[4].Truong_08;
                    uC_AT1.uc_AT_Rows5.txt_TruongSo09.Text = deso[4].Truong_09;
                    uC_AT1.uc_AT_Rows5.txt_TruongSo10.Text = deso[4].Truong_10;

                    uC_AT1.uc_AT_Rows6.txt_TruongSo07.Text = deso[5].Truong_07;
                    uC_AT1.uc_AT_Rows6.txt_TruongSo08.Text = deso[5].Truong_08;
                    uC_AT1.uc_AT_Rows6.txt_TruongSo09.Text = deso[5].Truong_09;
                    uC_AT1.uc_AT_Rows6.txt_TruongSo10.Text = deso[5].Truong_10;

                    uC_AT1.uc_AT_Rows7.txt_TruongSo07.Text = deso[6].Truong_07;
                    uC_AT1.uc_AT_Rows7.txt_TruongSo08.Text = deso[6].Truong_08;
                    uC_AT1.uc_AT_Rows7.txt_TruongSo09.Text = deso[6].Truong_09;
                    uC_AT1.uc_AT_Rows7.txt_TruongSo10.Text = deso[6].Truong_10;

                    uC_AT1.uc_AT_Rows8.txt_TruongSo07.Text = deso[7].Truong_07;
                    uC_AT1.uc_AT_Rows8.txt_TruongSo08.Text = deso[7].Truong_08;
                    uC_AT1.uc_AT_Rows8.txt_TruongSo09.Text = deso[7].Truong_09;
                    uC_AT1.uc_AT_Rows8.txt_TruongSo10.Text = deso[7].Truong_10;

                    uC_AT1.uc_AT_Rows9.txt_TruongSo07.Text = deso[8].Truong_07;
                    uC_AT1.uc_AT_Rows9.txt_TruongSo08.Text = deso[8].Truong_08;
                    uC_AT1.uc_AT_Rows9.txt_TruongSo09.Text = deso[8].Truong_09;
                    uC_AT1.uc_AT_Rows9.txt_TruongSo10.Text = deso[8].Truong_10;

                    uC_AT1.uc_AT_Rows10.txt_TruongSo07.Text = deso[9].Truong_07;
                    uC_AT1.uc_AT_Rows10.txt_TruongSo08.Text = deso[9].Truong_08;
                    uC_AT1.uc_AT_Rows10.txt_TruongSo09.Text = deso[9].Truong_09;
                    uC_AT1.uc_AT_Rows10.txt_TruongSo10.Text = deso[9].Truong_10;

                    //Load user 2

                    tabcontrol_DeSo2.SelectedTabPage = tp_AE_DeSo2;
                    uC_AT2.txt_TruongSo02.Text = deso[10].Truong_02;
                    uC_AT2.txt_TruongSo03.Text = deso[10].Truong_03;
                    uC_AT2.txt_TruongSo04.Text = deso[10].Truong_04;
                    uC_AT2.txt_TruongSo05.Text = deso[10].Truong_05;

                    uC_AT2.uc_AT_Rows1.txt_TruongSo07.Text = deso[10].Truong_07;
                    uC_AT2.uc_AT_Rows1.txt_TruongSo08.Text = deso[10].Truong_08;
                    uC_AT2.uc_AT_Rows1.txt_TruongSo09.Text = deso[10].Truong_09;
                    uC_AT2.uc_AT_Rows1.txt_TruongSo10.Text = deso[10].Truong_10;

                    uC_AT2.uc_AT_Rows2.txt_TruongSo07.Text = deso[11].Truong_07;
                    uC_AT2.uc_AT_Rows2.txt_TruongSo08.Text = deso[11].Truong_08;
                    uC_AT2.uc_AT_Rows2.txt_TruongSo09.Text = deso[11].Truong_09;
                    uC_AT2.uc_AT_Rows2.txt_TruongSo10.Text = deso[11].Truong_10;

                    uC_AT2.uc_AT_Rows3.txt_TruongSo07.Text = deso[12].Truong_07;
                    uC_AT2.uc_AT_Rows3.txt_TruongSo08.Text = deso[12].Truong_08;
                    uC_AT2.uc_AT_Rows3.txt_TruongSo09.Text = deso[12].Truong_09;
                    uC_AT2.uc_AT_Rows3.txt_TruongSo10.Text = deso[12].Truong_10;

                    uC_AT2.uc_AT_Rows4.txt_TruongSo07.Text = deso[13].Truong_07;
                    uC_AT2.uc_AT_Rows4.txt_TruongSo08.Text = deso[13].Truong_08;
                    uC_AT2.uc_AT_Rows4.txt_TruongSo09.Text = deso[13].Truong_09;
                    uC_AT2.uc_AT_Rows4.txt_TruongSo10.Text = deso[13].Truong_10;

                    uC_AT2.uc_AT_Rows5.txt_TruongSo07.Text = deso[14].Truong_07;
                    uC_AT2.uc_AT_Rows5.txt_TruongSo08.Text = deso[14].Truong_08;
                    uC_AT2.uc_AT_Rows5.txt_TruongSo09.Text = deso[14].Truong_09;
                    uC_AT2.uc_AT_Rows5.txt_TruongSo10.Text = deso[14].Truong_10;

                    uC_AT2.uc_AT_Rows6.txt_TruongSo07.Text = deso[15].Truong_07;
                    uC_AT2.uc_AT_Rows6.txt_TruongSo08.Text = deso[15].Truong_08;
                    uC_AT2.uc_AT_Rows6.txt_TruongSo09.Text = deso[15].Truong_09;
                    uC_AT2.uc_AT_Rows6.txt_TruongSo10.Text = deso[15].Truong_10;

                    uC_AT2.uc_AT_Rows7.txt_TruongSo07.Text = deso[16].Truong_07;
                    uC_AT2.uc_AT_Rows7.txt_TruongSo08.Text = deso[16].Truong_08;
                    uC_AT2.uc_AT_Rows7.txt_TruongSo09.Text = deso[16].Truong_09;
                    uC_AT2.uc_AT_Rows7.txt_TruongSo10.Text = deso[16].Truong_10;

                    uC_AT2.uc_AT_Rows8.txt_TruongSo07.Text = deso[17].Truong_07;
                    uC_AT2.uc_AT_Rows8.txt_TruongSo08.Text = deso[17].Truong_08;
                    uC_AT2.uc_AT_Rows8.txt_TruongSo09.Text = deso[17].Truong_09;
                    uC_AT2.uc_AT_Rows8.txt_TruongSo10.Text = deso[17].Truong_10;

                    uC_AT2.uc_AT_Rows9.txt_TruongSo07.Text = deso[18].Truong_07;
                    uC_AT2.uc_AT_Rows9.txt_TruongSo08.Text = deso[18].Truong_08;
                    uC_AT2.uc_AT_Rows9.txt_TruongSo09.Text = deso[18].Truong_09;
                    uC_AT2.uc_AT_Rows9.txt_TruongSo10.Text = deso[18].Truong_10;

                    uC_AT2.uc_AT_Rows10.txt_TruongSo07.Text = deso[19].Truong_07;
                    uC_AT2.uc_AT_Rows10.txt_TruongSo08.Text = deso[19].Truong_08;
                    uC_AT2.uc_AT_Rows10.txt_TruongSo09.Text = deso[19].Truong_09;
                    uC_AT2.uc_AT_Rows10.txt_TruongSo10.Text = deso[19].Truong_10;
                    uC_AT1.txt_TruongSo02.Focus();
                }
                //Compare AE
                Compare_TextBox(uc_AE1.txt_TruongSo02, uc_AE2.txt_TruongSo02);
                Compare_TextBox(uc_AE1.txt_TruongSo03, uc_AE2.txt_TruongSo03);
                Compare_TextBox(uc_AE1.txt_TruongSo04, uc_AE2.txt_TruongSo04);
                Compare_TextBox(uc_AE1.txt_TruongSo05, uc_AE2.txt_TruongSo05);
                Compare_TextBox(uc_AE1.uc_AE_Rows1.txt_TruongSo09, uc_AE2.uc_AE_Rows1.txt_TruongSo09);
                Compare_TextBox(uc_AE1.uc_AE_Rows2.txt_TruongSo09, uc_AE2.uc_AE_Rows2.txt_TruongSo09);
                Compare_TextBox(uc_AE1.uc_AE_Rows3.txt_TruongSo09, uc_AE2.uc_AE_Rows3.txt_TruongSo09);
                Compare_TextBox(uc_AE1.uc_AE_Rows4.txt_TruongSo09, uc_AE2.uc_AE_Rows4.txt_TruongSo09);
                Compare_TextBox(uc_AE1.uc_AE_Rows5.txt_TruongSo09, uc_AE2.uc_AE_Rows5.txt_TruongSo09);
                Compare_TextBox(uc_AE1.uc_AE_Rows6.txt_TruongSo09, uc_AE2.uc_AE_Rows6.txt_TruongSo09);
                Compare_TextBox(uc_AE1.uc_AE_Rows7.txt_TruongSo09, uc_AE2.uc_AE_Rows7.txt_TruongSo09);
                Compare_TextBox(uc_AE1.uc_AE_Rows8.txt_TruongSo09, uc_AE2.uc_AE_Rows8.txt_TruongSo09);
                Compare_TextBox(uc_AE1.uc_AE_Rows9.txt_TruongSo09, uc_AE2.uc_AE_Rows9.txt_TruongSo09);
                Compare_TextBox(uc_AE1.uc_AE_Rows10.txt_TruongSo09, uc_AE2.uc_AE_Rows10.txt_TruongSo09);

                //Compare AT
                Compare_TextBox(uC_AT1.txt_TruongSo02, uC_AT2.txt_TruongSo02);
                Compare_TextBox(uC_AT1.txt_TruongSo03, uC_AT2.txt_TruongSo03);
                Compare_TextBox(uC_AT1.txt_TruongSo04, uC_AT2.txt_TruongSo04);
                Compare_TextBox(uC_AT1.txt_TruongSo05, uC_AT2.txt_TruongSo05);

                Compare_TextBox(uC_AT1.uc_AT_Rows1.txt_TruongSo07, uC_AT2.uc_AT_Rows1.txt_TruongSo07);
                Compare_TextBox(uC_AT1.uc_AT_Rows2.txt_TruongSo07, uC_AT2.uc_AT_Rows2.txt_TruongSo07);
                Compare_TextBox(uC_AT1.uc_AT_Rows3.txt_TruongSo07, uC_AT2.uc_AT_Rows3.txt_TruongSo07);
                Compare_TextBox(uC_AT1.uc_AT_Rows4.txt_TruongSo07, uC_AT2.uc_AT_Rows4.txt_TruongSo07);
                Compare_TextBox(uC_AT1.uc_AT_Rows5.txt_TruongSo07, uC_AT2.uc_AT_Rows5.txt_TruongSo07);
                Compare_TextBox(uC_AT1.uc_AT_Rows6.txt_TruongSo07, uC_AT2.uc_AT_Rows6.txt_TruongSo07);
                Compare_TextBox(uC_AT1.uc_AT_Rows7.txt_TruongSo07, uC_AT2.uc_AT_Rows7.txt_TruongSo07);
                Compare_TextBox(uC_AT1.uc_AT_Rows8.txt_TruongSo07, uC_AT2.uc_AT_Rows8.txt_TruongSo07);
                Compare_TextBox(uC_AT1.uc_AT_Rows9.txt_TruongSo07, uC_AT2.uc_AT_Rows9.txt_TruongSo07);
                Compare_TextBox(uC_AT1.uc_AT_Rows10.txt_TruongSo07, uC_AT2.uc_AT_Rows10.txt_TruongSo07);

                Compare_TextBox(uC_AT1.uc_AT_Rows1.txt_TruongSo08, uC_AT2.uc_AT_Rows1.txt_TruongSo08);
                Compare_TextBox(uC_AT1.uc_AT_Rows2.txt_TruongSo08, uC_AT2.uc_AT_Rows2.txt_TruongSo08);
                Compare_TextBox(uC_AT1.uc_AT_Rows3.txt_TruongSo08, uC_AT2.uc_AT_Rows3.txt_TruongSo08);
                Compare_TextBox(uC_AT1.uc_AT_Rows4.txt_TruongSo08, uC_AT2.uc_AT_Rows4.txt_TruongSo08);
                Compare_TextBox(uC_AT1.uc_AT_Rows5.txt_TruongSo08, uC_AT2.uc_AT_Rows5.txt_TruongSo08);
                Compare_TextBox(uC_AT1.uc_AT_Rows6.txt_TruongSo08, uC_AT2.uc_AT_Rows6.txt_TruongSo08);
                Compare_TextBox(uC_AT1.uc_AT_Rows7.txt_TruongSo08, uC_AT2.uc_AT_Rows7.txt_TruongSo08);
                Compare_TextBox(uC_AT1.uc_AT_Rows8.txt_TruongSo08, uC_AT2.uc_AT_Rows8.txt_TruongSo08);
                Compare_TextBox(uC_AT1.uc_AT_Rows9.txt_TruongSo08, uC_AT2.uc_AT_Rows9.txt_TruongSo08);
                Compare_TextBox(uC_AT1.uc_AT_Rows10.txt_TruongSo08, uC_AT2.uc_AT_Rows10.txt_TruongSo08);

                Compare_TextBox(uC_AT1.uc_AT_Rows1.txt_TruongSo09, uC_AT2.uc_AT_Rows1.txt_TruongSo09);
                Compare_TextBox(uC_AT1.uc_AT_Rows2.txt_TruongSo09, uC_AT2.uc_AT_Rows2.txt_TruongSo09);
                Compare_TextBox(uC_AT1.uc_AT_Rows3.txt_TruongSo09, uC_AT2.uc_AT_Rows3.txt_TruongSo09);
                Compare_TextBox(uC_AT1.uc_AT_Rows4.txt_TruongSo09, uC_AT2.uc_AT_Rows4.txt_TruongSo09);
                Compare_TextBox(uC_AT1.uc_AT_Rows5.txt_TruongSo09, uC_AT2.uc_AT_Rows5.txt_TruongSo09);
                Compare_TextBox(uC_AT1.uc_AT_Rows6.txt_TruongSo09, uC_AT2.uc_AT_Rows6.txt_TruongSo09);
                Compare_TextBox(uC_AT1.uc_AT_Rows7.txt_TruongSo09, uC_AT2.uc_AT_Rows7.txt_TruongSo09);
                Compare_TextBox(uC_AT1.uc_AT_Rows8.txt_TruongSo09, uC_AT2.uc_AT_Rows8.txt_TruongSo09);
                Compare_TextBox(uC_AT1.uc_AT_Rows9.txt_TruongSo09, uC_AT2.uc_AT_Rows9.txt_TruongSo09);
                Compare_TextBox(uC_AT1.uc_AT_Rows10.txt_TruongSo09, uC_AT2.uc_AT_Rows10.txt_TruongSo09);

                Compare_TextBox(uC_AT1.uc_AT_Rows1.txt_TruongSo10, uC_AT2.uc_AT_Rows1.txt_TruongSo10);
                Compare_TextBox(uC_AT1.uc_AT_Rows2.txt_TruongSo10, uC_AT2.uc_AT_Rows2.txt_TruongSo10);
                Compare_TextBox(uC_AT1.uc_AT_Rows3.txt_TruongSo10, uC_AT2.uc_AT_Rows3.txt_TruongSo10);
                Compare_TextBox(uC_AT1.uc_AT_Rows4.txt_TruongSo10, uC_AT2.uc_AT_Rows4.txt_TruongSo10);
                Compare_TextBox(uC_AT1.uc_AT_Rows5.txt_TruongSo10, uC_AT2.uc_AT_Rows5.txt_TruongSo10);
                Compare_TextBox(uC_AT1.uc_AT_Rows6.txt_TruongSo10, uC_AT2.uc_AT_Rows6.txt_TruongSo10);
                Compare_TextBox(uC_AT1.uc_AT_Rows7.txt_TruongSo10, uC_AT2.uc_AT_Rows7.txt_TruongSo10);
                Compare_TextBox(uC_AT1.uc_AT_Rows8.txt_TruongSo10, uC_AT2.uc_AT_Rows8.txt_TruongSo10);
                Compare_TextBox(uC_AT1.uc_AT_Rows9.txt_TruongSo10, uC_AT2.uc_AT_Rows9.txt_TruongSo10);
                Compare_TextBox(uC_AT1.uc_AT_Rows10.txt_TruongSo10, uC_AT2.uc_AT_Rows10.txt_TruongSo10);

                var soloi = (from w in Global.db.GetSoLoi_CheckDeSo(Global.StrBatch) select w.Column1).FirstOrDefault();
                lb_Loi.Text = soloi + " Lỗi";
            }
            catch (Exception i)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + i.Message);
            }
        }

        private string GetImage_DeSo()
        {
            var temp = (from w in Global.db.tbl_MissCheck_DESOs
                where w.fBatchName == Global.StrBatch && w.UserName == Global.StrUsername && w.Submit == 0
                select w.IdImage).FirstOrDefault();
            if (string.IsNullOrEmpty(temp))
            {
                var getFilename =
                (from w in Global.db.GetImageCheck_DeSo(Global.StrBatch, Global.StrUsername)
                    select w.Column1).FirstOrDefault();
                if (string.IsNullOrEmpty(getFilename))
                {
                    return "NULL";
                }
                else
                {
                    lb_Image.Text = getFilename;
                    uc_PictureBox1.imageBox1.Image = null;
                    if (uc_PictureBox1.LoadImage(Global.Webservice + Global.StrBatch + "/" + getFilename, getFilename,
                            Properties.Settings.Default.ZoomImage) == "Error")
                    {
                        uc_PictureBox1.imageBox1.Image = Resources.svn_deleted;
                        return "Error";
                    }
                }
            }
            else
            {
                lb_Image.Text = temp;
                uc_PictureBox1.imageBox1.Image = null;
                if (uc_PictureBox1.LoadImage(Global.Webservice + Global.StrBatch + "/" + temp, temp,
                        Properties.Settings.Default.ZoomImage) == "Error")
                {
                    uc_PictureBox1.imageBox1.Image = Resources.svn_deleted;
                    return "Error";
                }
            }
            return "ok";
        }


        private void btn_Luu_DeSo1_Click(object sender, EventArgs e)
        {
            try
            {
                Global.db_BPO.UpdateTimeLastRequest(Global.Strtoken);
                Global.db.LuuDESo(lb_Image.Text, Global.StrBatch, lb_username1.Text, lb_username2.Text,
                    Global.StrUsername);
                ResetData();

                var soloi = (from w in Global.db.GetSoLoi_CheckDeSo(Global.StrBatch) select w.Column1).FirstOrDefault();
                lb_Loi.Text = soloi + " Lỗi";
                string temp = GetImage_DeSo();

                if (temp == "NULL")
                {
                    uc_PictureBox1.imageBox1.Dispose();
                    MessageBox.Show("Hết Hình!");
                    btn_Luu_DeSo1.Visible = false;
                    btn_Luu_DeSo2.Visible = false;
                    btn_SuaVaLuu_User1.Visible = false;
                    btn_SuaVaLuu_User2.Visible = false;
                    return;
                }
                if (temp == "Error")
                {
                    MessageBox.Show("Lỗi load hình");
                    btn_Luu_DeSo1.Visible = false;
                    btn_Luu_DeSo2.Visible = false;
                    btn_SuaVaLuu_User1.Visible = false;
                    btn_SuaVaLuu_User2.Visible = false;
                    return;
                }
                Load_DeSo(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;
            }
            catch (Exception i)
            {
                MessageBox.Show("Lỗi : " + i.Message);
            }
        }

        private void btn_Luu_DeSo2_Click(object sender, EventArgs e)
        {
            try
            {
                Global.db_BPO.UpdateTimeLastRequest(Global.Strtoken);
                Global.db.LuuDESo(lb_Image.Text, Global.StrBatch, lb_username2.Text, lb_username1.Text,
                    Global.StrUsername);

                var soloi = (from w in Global.db.GetSoLoi_CheckDeSo(Global.StrBatch) select w.Column1).FirstOrDefault();
                lb_Loi.Text = soloi + " Lỗi";
                ResetData();
                string temp = GetImage_DeSo();

                if (temp == "NULL")
                {
                    uc_PictureBox1.imageBox1.Dispose();
                    MessageBox.Show("Hết Hình!");
                    btn_Luu_DeSo1.Visible = false;
                    btn_Luu_DeSo2.Visible = false;
                    btn_SuaVaLuu_User1.Visible = false;
                    btn_SuaVaLuu_User2.Visible = false;
                    return;
                }
                if (temp == "Error")
                {
                    MessageBox.Show("Lỗi load hình");
                    btn_Luu_DeSo1.Visible = false;
                    btn_Luu_DeSo2.Visible = false;
                    btn_SuaVaLuu_User1.Visible = false;
                    btn_SuaVaLuu_User2.Visible = false;
                    return;
                }
                Load_DeSo(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;
            }
            catch (Exception i)
            {
                MessageBox.Show("Lỗi : " + i.Message);
            }
        }

        private void btn_SuaVaLuu_User1_Click(object sender, EventArgs e)
        {
            try
            {
                Global.db_BPO.UpdateTimeLastRequest(Global.Strtoken);

                if (tabcontrol_DeSo1.SelectedTabPage == tp_AE_DeSo1)
                {
                    uc_AE1.SuaVaLuu(lb_username1.Text, lb_username2.Text, lb_Image.Text);
                }
                else if (tabcontrol_DeSo1.SelectedTabPage == tp_AT_DeSo1)
                {
                    uC_AT1.SuaVaLuu(lb_username1.Text, lb_username2.Text, lb_Image.Text);
                }

                ResetData();

                var soloi = (from w in Global.db.GetSoLoi_CheckDeSo(Global.StrBatch) select w.Column1).FirstOrDefault();
                lb_Loi.Text = soloi + " Lỗi";
                if (GetImage_DeSo() == "NULL")
                {
                    uc_PictureBox1.imageBox1.Dispose();
                    MessageBox.Show("Hết Hình!");
                    btn_Luu_DeSo1.Visible = false;
                    btn_Luu_DeSo2.Visible = false;
                    btn_SuaVaLuu_User1.Visible = false;
                    btn_SuaVaLuu_User2.Visible = false;
                    return;
                }
                Load_DeSo(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;
            }
            catch (Exception i)
            {
                MessageBox.Show("Lỗi : " + i.Message);
            }
        }

        private void btn_SuaVaLuu_User2_Click(object sender, EventArgs e)
        {
            try
            {
                Global.db_BPO.UpdateTimeLastRequest(Global.Strtoken);

                if (tabcontrol_DeSo2.SelectedTabPage == tp_AE_DeSo2)
                {
                    uc_AE2.SuaVaLuu(lb_username2.Text, lb_username1.Text, lb_Image.Text);
                }
                else if (tabcontrol_DeSo2.SelectedTabPage == tp_AT_DeSo2)
                {
                    uC_AT2.SuaVaLuu(lb_username2.Text, lb_username1.Text, lb_Image.Text);
                }

                ResetData();

                var soloi = (from w in Global.db.GetSoLoi_CheckDeSo(Global.StrBatch) select w.Column1).FirstOrDefault();
                lb_Loi.Text = soloi + " Lỗi";
                if (GetImage_DeSo() == "NULL")
                {
                    uc_PictureBox1.imageBox1.Dispose();
                    MessageBox.Show("Hết Hình!");
                    btn_Luu_DeSo1.Visible = false;
                    btn_Luu_DeSo2.Visible = false;
                    btn_SuaVaLuu_User1.Visible = false;
                    btn_SuaVaLuu_User2.Visible = false;
                    return;
                }
                Load_DeSo(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;
            }
            catch (Exception i)
            {
                MessageBox.Show("Lỗi : " + i.Message);
            }
        }

        private void uc_AE1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.HorizontalScroll)
                uc_AE1.HorizontalScroll.Value = e.NewValue;
            else if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.VerticalScroll)
                this.uc_AE2.VerticalScroll.Value = e.NewValue;
        }

        private void uC_AT1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.HorizontalScroll)
                uC_AT1.HorizontalScroll.Value = e.NewValue;
            else if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.VerticalScroll)
                this.uC_AT2.VerticalScroll.Value = e.NewValue;
        }

        private void uc_AE2_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.HorizontalScroll)
                uc_AE2.HorizontalScroll.Value = e.NewValue;
            else if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.VerticalScroll)
                this.uc_AE1.VerticalScroll.Value = e.NewValue;
        }

        private void uC_AT2_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.HorizontalScroll)
                uC_AT2.HorizontalScroll.Value = e.NewValue;
            else if (e.ScrollOrientation == System.Windows.Forms.ScrollOrientation.VerticalScroll)
                this.uC_AT1.VerticalScroll.Value = e.NewValue;
        }
    }
}