using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PhieuKiemKe.MyForm;
using PhieuKiemKe.Properties;

namespace PhieuKiemKe
{
    public partial class frm_Main : DevExpress.XtraEditors.XtraForm
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        private void setValue()
        {
            if (Global.StrRole == "DESO")
            {
                lb_SoHinhConLai.Text = (from w in Global.db.tbl_Images
                                        where w.ReadImageDESo < 2 && w.fbatchname == Global.StrBatch && (w.UserNameDESo != Global.StrUsername || w.UserNameDESo == null || w.UserNameDESo == "")
                                        select w.idimage).Count().ToString();
                lb_SoHinhLamDuoc.Text = (from w in Global.db.tbl_MissImage_DESOs
                                         where w.UserName == Global.StrUsername && w.fBatchName == Global.StrBatch
                                         select w.IdImage).Count().ToString();
            }
        }

        public string GetImage()
        {
            if (Global.StrRole == "DESO")
            {
                string temp = (from w in Global.db.tbl_MissImage_DESOs
                               where w.fBatchName == Global.StrBatch && w.UserName == Global.StrUsername && w.Submit == 0
                               select w.IdImage).FirstOrDefault();
                if (string.IsNullOrEmpty(temp))
                {
                    try
                    {
                        var getFilename =
                            (from w in Global.db.LayHinhMoi_DeSo(Global.StrBatch, Global.StrUsername)
                             select w.Column1).FirstOrDefault();
                        if (string.IsNullOrEmpty(getFilename))
                        {
                            return "NULL";
                        }
                        lb_IdImage.Text = getFilename;
                        uc_PictureBox1.imageBox1.Image = null;
                        if (uc_PictureBox1.LoadImage(Global.Webservice + Global.StrBatch + "/" + getFilename, getFilename,
                            Settings.Default.ZoomImage) == "Error")
                        {
                            uc_PictureBox1.imageBox1.Image = Resources.svn_deleted;
                            return "Error";

                        }
                    }
                    catch (Exception i)
                    {
                        return "NULL";
                    }
                }
                else
                {
                    lb_IdImage.Text = temp;
                    uc_PictureBox1.imageBox1.Image = null;
                    if (uc_PictureBox1.LoadImage(Global.Webservice + Global.StrBatch + "/" + temp, temp,
                        Settings.Default.ZoomImage) == "Error")
                    {
                        uc_PictureBox1.imageBox1.Image = Resources.svn_deleted;
                        return "Error";
                    }
                }
                

            }
            return "OK";
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            try
            {
                Global.LoaiPhieu =(from w in Global.db.tbl_Batches where w.fBatchName == Global.StrBatch select w.LoaiBatch).FirstOrDefault();
                lb_IdImage.Text = "";
                lb_fBatchName.Text = Global.StrBatch;
                lb_UserName.Text = Global.StrUsername;
                lb_TongSoHinh.Text =(from w in Global.db.tbl_Images where w.fbatchname == Global.StrBatch select w.idimage).Count().ToString();
                lb_SoHinhConLai.Text = (from w in Global.db.tbl_Images where w.ReadImageDESo < 2 && w.fbatchname == Global.StrBatch &&
                                        (w.UserNameDESo != Global.StrUsername || w.UserNameDESo == null || w.UserNameDESo == "")
                                        select w.idimage).Count().ToString();
                lb_SoHinhLamDuoc.Text = (from w in Global.db.tbl_MissImage_DESOs
                                         where w.UserName == Global.StrUsername && w.fBatchName == Global.StrBatch
                                         select w.IdImage).Count().ToString();

                tp_AE_Main.PageVisible = false;
                tp_AT_Main.PageVisible = false;

                btn_quanmly.Enabled = false;
                if (Global.StrRole == "DESO")
                {
                    if (Global.LoaiPhieu == "AE")
                        tp_AE_Main.PageVisible = true;
                    else if (Global.LoaiPhieu == "AT")
                        tp_AT_Main.PageVisible = true;
                }
                else
                {
                    btn_Start_Submit.Enabled = false;
                    btn_Submit_Logout.Enabled = false;
                    btn_quanmly.Enabled = true;
                }
                setValue();
            }
            catch (Exception i)
            {
                MessageBox.Show("Lỗi Load Main: " + i.Message);
            }
        }

        private void btn_Start_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                Global.db_BPO.UpdateTimeLastRequest(Global.Strtoken);
                //Kiểm tra token
                var token = (from w in Global.db_BPO.tbl_TokenLogins
                    where w.UserName == Global.StrUsername && w.IDProject == Global.StrIdProject
                    select w.Token).FirstOrDefault();

                if (token != Global.Strtoken)
                {
                    MessageBox.Show("User đã đăng nhập ở PC khác, bạn vui lòng đăng nhập lại!");
                    DialogResult = DialogResult.Yes;
                }
                if (btn_Start_Submit.Text == "Start")
                {
                    if (string.IsNullOrEmpty(Global.StrBatch))
                    {
                        MessageBox.Show("Vui lòng đăng nhập lại và chọn Batch!");
                        return;
                    }

                    string temp = GetImage();
                    if (temp == "NULL")
                    {
                        MessageBox.Show("Hết Hình!");
                        btn_Logout_ItemClick(null, null);
                    }
                    else if (temp == "Error")
                    {
                        MessageBox.Show("Không thể load hình!");
                        btn_Logout_ItemClick(null, null);
                    }
                    if (tabControl_Main.SelectedTabPage == tp_AE_Main)
                    {
                        uc_AE1.ResetData();
                    }
                    else if (tabControl_Main.SelectedTabPage == tp_AT_Main)
                    {
                        uC_AT1.resetData();
                    }
                    btn_Start_Submit.Text = "Submit";
                    btn_Submit_Logout.Visible = true;
                }
                else
                {
                    if (Global.StrRole == "DESO")
                    {
                        if (tabControl_Main.SelectedTabPage == tp_AE_Main)
                        {
                            if (uc_AE1.IsEmpty())
                            {
                                if (MessageBox.Show("Bạn đang để trống nhiều trường. Bạn có muốn submit không? \r\nYes = Submit và chuyển qua hình khác<Nhấn Enter>\r\nNo = nhập lại trường trống cho hình này.<nhấn phím N>","Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==DialogResult.No)
                                    return;
                            }
                            uc_AE1.SaveData_AE(lb_IdImage.Text);
                            uc_AE1.ResetData();
                        }
                        else if (tabControl_Main.SelectedTabPage == tp_AT_Main)
                        {
                            if (uC_AT1.isEmpty())
                            {
                                if (MessageBox.Show("Bạn đang để trống 1 hoặc nhiều trường. Bạn có muốn submit không? \r\nYes = Submit và chuyển qua hình khác<Nhấn Enter>\r\nNo = nhập lại trường trống cho hình này.<nhấn phím N>", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                                    return;
                            }
                            uC_AT1.SaveData(lb_IdImage.Text);
                            uC_AT1.resetData();
                        }


                        //    uc_ASAHI1.ResetData();//}
                        string temp = GetImage();
                        if (temp == "NULL")
                        {
                            MessageBox.Show("Hết Hình!");
                            btn_Logout_ItemClick(null, null);
                        }
                        else if (temp == "Error")
                        {
                            MessageBox.Show("Không thể load hình!");
                            btn_Logout_ItemClick(null, null);
                        }
                    }
                    setValue();
                }
            }
            catch (Exception i)
            {
                MessageBox.Show("Lỗi khi Submit" + i.Message);
            }
        }

        private void btn_Submit_Logout_Click(object sender, EventArgs e)
        {
            try
            {
                Global.db_BPO.UpdateTimeLastRequest(Global.Strtoken);//Kiểm tra token
                var token = (from w in Global.db_BPO.tbl_TokenLogins
                             where w.UserName == Global.StrUsername && w.IDProject == Global.StrIdProject
                             select w.Token).FirstOrDefault();

                if (token != Global.Strtoken)
                {
                    MessageBox.Show("User đã đăng nhập ở PC khác, bạn vui lòng đăng nhập lại!");
                    DialogResult = DialogResult.Yes;
                }

                if (Global.StrRole == "DESO")
                {
                    if (tabControl_Main.SelectedTabPage == tp_AE_Main)
                    {
                        if (uc_AE1.IsEmpty())
                        {
                            if (MessageBox.Show("Bạn đang để trống nhiều trường. Bạn có muốn submit không? \r\nYes = Submit và chuyển qua hình khác<Nhấn Enter>\r\nNo = nhập lại trường trống cho hình này.<nhấn phím N>", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                                return;
                        }
                        uc_AE1.SaveData_AE(lb_IdImage.Text);
                    }
                    else if (tabControl_Main.SelectedTabPage == tp_AT_Main)
                    {
                        if (uC_AT1.isEmpty())
                        {
                            if (MessageBox.Show("Bạn đang để trống 1 hoặc nhiều trường. Bạn có muốn submit không? \r\nYes = Submit và chuyển qua hình khác<Nhấn Enter>\r\nNo = nhập lại trường trống cho hình này.<nhấn phím N>", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                                return;
                        }
                        uC_AT1.SaveData(lb_IdImage.Text);
                        uC_AT1.resetData();
                    }

                }
                btn_Logout_ItemClick(null, null);
            }
            catch (Exception i)
            {
                MessageBox.Show("Lỗi khi Submit_Logout" + i.Message);
            }
        }

        private void frm_Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
                btn_Start_Submit_Click(null, null);
            if (e.Control && e.KeyCode == Keys.PageUp)
                uc_PictureBox1.btn_Xoaytrai_Click(null, null);
            if (e.Control && e.KeyCode == Keys.PageDown)
                uc_PictureBox1.btn_xoayphai_Click(null, null);
            if (e.KeyCode == Keys.Escape)
            {
                new frm_FreeTime().ShowDialog();
                Global.db_BPO.UpdateTimeFree(Global.Strtoken, Global.FreeTime);
            }
        }

        private void btn_Logout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void btn_QuanLyUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frm_User().ShowDialog();
        }

        private void btn_ZoomImage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frm_ChangeZoom().ShowDialog();
        }
        private void btn_QuanLyBatch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frm_ManagerBatch().ShowDialog();
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            new frm_FreeTime().ShowDialog();
            Global.db_BPO.UpdateTimeFree(Global.Strtoken, Global.FreeTime);
        }

        private void btn_Exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.db_BPO.UpdateTimeLastRequest(Global.Strtoken);
            Global.db_BPO.UpdateTimeLogout(Global.Strtoken);
            Global.db_BPO.ResetToken(Global.StrUsername, Global.StrIdProject, Global.Strtoken);
            Settings.Default.Save();
        }

        private void btn_Check_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {new frm_Check_DeSo().ShowDialog();
        }
    }
}
