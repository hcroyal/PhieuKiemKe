﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PhieuKiemKe.MyForm
{
    public partial class frm_CreateBatch : DevExpress.XtraEditors.XtraForm
    {
        private string _csvpath = "";
        private string[] _lFileNames;
        private bool _multi;
        private int soluonghinh;
        public frm_CreateBatch()
        {
            InitializeComponent();
        }

        private void frm_CreateBatch_Load(object sender, EventArgs e)
        {
            txt_UserCreate.Text = Global.StrUsername;
            txt_DateCreate.Text = DateTime.Now.ToShortDateString() + "  -  " + DateTime.Now.ToShortTimeString();
        }

        private void btn_BrowserImage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_BatchName.Text))
            {
                MessageBox.Show("Vui lòng điền tên batch", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Types Image|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";

            dlg.Multiselect = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _lFileNames = dlg.FileNames;
                txt_ImagePath.Text = Path.GetDirectoryName(dlg.FileName);
            }
            soluonghinh = 0;
            soluonghinh = dlg.FileNames.Length;
            lb_SoLuongHinh.Text = dlg.FileNames.Length + " files ";
        }

        private void btn_CreateBatch_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            UpLoadSingle();
            
        }
      
        private void UpLoadSingle()
        {
            progressBarControl1.EditValue = 0;
            progressBarControl1.Properties.Step = 1;
            progressBarControl1.Properties.PercentView = true;
            progressBarControl1.Properties.Maximum = _lFileNames.Length;
            progressBarControl1.Properties.Minimum = 0;
            var batch = (from w in Global.db.tbl_Batches.Where(w => w.fBatchName == txt_BatchName.Text) select w.fBatchName).FirstOrDefault();
            if (!string.IsNullOrEmpty(txt_ImagePath.Text))
            {
                if (string.IsNullOrEmpty(batch))
                {
                    var fBatch = new tbl_Batch
                    {
                        fBatchName = txt_BatchName.Text,
                        fusercreate = txt_UserCreate.Text,
                        fdatecreated = DateTime.Now,
                        fPathPicture = txt_ImagePath.Text,
                        fLocation = txt_Location.Text,
                        fSoLuongAnh = soluonghinh.ToString(),
                        LoaiBatch = rg_LoaiBatch.Properties.Items[rg_LoaiBatch.SelectedIndex].Description

                    };
                    Global.db.tbl_Batches.InsertOnSubmit(fBatch);
                    Global.db.SubmitChanges();




                }
                else
                {
                    MessageBox.Show("Batch đã tồn tại vui lòng điền tên batch khác!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn hình ảnh!");
                return;
            }
            string temp = Global.StrPath + "\\" + txt_BatchName.Text;
            if (!Directory.Exists(temp))
            {
                Directory.CreateDirectory(temp);
            }
            else
            {
                MessageBox.Show("Bị trùng tên batch!");
                return;
            }
            foreach (string i in _lFileNames)
            {
                FileInfo fi = new FileInfo(i);

                tbl_Image tempImage = new tbl_Image
                {
                    fbatchname = txt_BatchName.Text,
                    idimage = Path.GetFileName(fi.ToString()),
                    ReadImageDESo = 0,
                    CheckedDESo = 0,
                    TienDoDESO = "Hình chưa nhập",
                    ReadImageDESO_Good = 1,
                    ReadImageDESO_NotGood = 1
                };
                Global.db.tbl_Images.InsertOnSubmit(tempImage);
                Global.db.SubmitChanges();


                string des = temp + @"\" + Path.GetFileName(fi.ToString());
                fi.CopyTo(des);
                progressBarControl1.PerformStep();
                progressBarControl1.Update();
            }
            MessageBox.Show("Tạo batch mới thành công!");
            progressBarControl1.EditValue = 0;
            txt_BatchName.Text = "";
            txt_ImagePath.Text = "";
            lb_SoLuongHinh.Text = "";
        }

        //private void UpLoadMulti()
        //{
        //    List<string> lStrBath = new List<string>();
        //    lStrBath.AddRange(Directory.GetDirectories(txt_PathFolder.Text));
        //    progressBarControl1.EditValue = 0;
        //    progressBarControl1.Properties.Step = 1;
        //    progressBarControl1.Properties.PercentView = true;
        //    progressBarControl1.Properties.Maximum = lStrBath.Count;
        //    progressBarControl1.Properties.Minimum = 0;
        //    foreach (string item in lStrBath)
        //    {
        //        var fBatch = new tbl_Batch
        //        {
        //            fBatchName = new DirectoryInfo(item).Name,
        //            fusercreate = txt_UserCreate.Text,
        //            fdatecreated = DateTime.Now,
        //            fPathPicture = item,
        //            fLocation = txt_Location.Text,
        //            fSoLuongAnh = Directory.GetFiles(item).Length.ToString()
        //        };
        //        Global.db.tbl_Batches.InsertOnSubmit(fBatch);
        //        Global.db.SubmitChanges();

        //        string searchFolder = txt_PathFolder.Text + "\\" + new DirectoryInfo(item).Name;
        //        var filters = new String[] { "jpg", "jpeg", "png", "gif", "tiff", "bmp" };
        //        string[] tmp = GetFilesFrom(searchFolder, filters, false);
        //        string temp = Global.StrPath + "\\" + new DirectoryInfo(item).Name;
        //        Directory.CreateDirectory(temp);
        //        string imageJPG = "";
        //        foreach (string i in tmp)
        //        {
        //            FileInfo fi = new FileInfo(i);
        //            tbl_Image tempImage = new tbl_Image
        //            {
        //                fbatchname = new DirectoryInfo(item).Name,
        //                idimage = Path.GetFileName(fi.ToString()),
        //                ReadImageDESo = 0,
        //                CheckedDESo = 0,
        //                TienDoDESO = "Hình chưa nhập",
        //                ReadImageDESO_Good = 0,
        //                ReadImageDESO_NotGood = 0
        //            };
        //            Global.db.tbl_Images.InsertOnSubmit(tempImage);
        //            Global.db.SubmitChanges();
        //            string des = temp + @"\" + Path.GetFileName(fi.ToString());
        //            fi.CopyTo(des);
        //            progressBarControl1.PerformStep();
        //            progressBarControl1.Update();
        //        }
        //        progressBarControl1.PerformStep();
        //        progressBarControl1.Update();
        //    }
        //    MessageBox.Show("Tạo batch mới thành công!");
        //    progressBarControl1.EditValue = 0;
        //    txt_BatchName.Text = "";
        //    txt_ImagePath.Text = "";
        //    lb_SoLuongHinh.Text = "";
        //}
        public static string[] GetFilesFrom(string searchFolder, string[] filters, bool isRecursive)
        {
            List<string> filesFound = new List<string>();
            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(searchFolder, $"*.{filter}", searchOption));
            }
            return filesFound.ToArray();
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}