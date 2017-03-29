using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Entity.Model;
using DevExpress.XtraEditors;
using Microsoft.Office.Interop.Excel;

namespace PhieuKiemKe.MyForm
{
    public partial class frm_ExportExcel : DevExpress.XtraEditors.XtraForm
    {
        public frm_ExportExcel()
        {
            InitializeComponent();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbb_Batch.Text))
            {
                MessageBox.Show("Chưa chọn batch.");
                return;
            }

            var result = Global.db.InputFinish(cbb_Batch.Text);
            if (result == 1)
            {
                MessageBox.Show("Batch này chưa nhập xong. Vui lòng nhập cho xong trước đã.");
                return;
            }
            var userMissimage = (from w in Global.db.MissImage_DESO(cbb_Batch.Text) select w.username).ToList();
            string sss = "";
            foreach (var item in userMissimage)
            {
                sss += item + "\r\n";
            }

            if (userMissimage.Count > 0)
            {
                MessageBox.Show("Những user lấy hình về nhưng không nhập: \r\n" + sss);
                return;
            }

            //Kiểm tra check xong chưa
            var xyz = Global.db.CheckerFinish(cbb_Batch.Text);
            if (xyz != 0)
            {
                MessageBox.Show("Chưa check xong hoặc có user lấy về nhưng chưa check. Vui lòng check trước");

                var u = (from w in Global.db.UserMissImagecheck(cbb_Batch.Text)
                    select w.username).ToList();
                string sssss = "";
                foreach (var item in u)
                {
                    sssss += item + "\r\n";
                }

                if (u.Count > 0)
                {
                    MessageBox.Show("Danh sách checker lấy hình về nhưng chưa check: \r\n" + sssss);
                }

                return;
            }
            if (
                System.IO.File.Exists(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) +
                                      "\\ExportExcel.xlsx"))
            {
                System.IO.File.Delete(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) +
                                      "\\ExportExcel.xlsx");
                System.IO.File.WriteAllBytes(
                (System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) +
                 "/ExportExcel.xlsx"), Properties.Resources.ExportExcel);
            }
            else
            {
                System.IO.File.WriteAllBytes(
                (System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) +
                 "/ExportExcel.xlsx"), Properties.Resources.ExportExcel);
            }
            var Loai =
                (from w in Global.db.tbl_Batches where w.fBatchName == cbb_Batch.Text select w.LoaiBatch).FirstOrDefault
                ();
            if (Loai == "AE")
            {
                TableToExcel_AE(
                    System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) +
                    "\\ExportExcel.xlsx", "AE");
            }
            else if (Loai == "AT")
            {
                TableToExcel_AT(
                    System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) +
                    "\\ExportExcel.xlsx", "AT");
            }


        }

        private void frm_ExportExcel_Load(object sender, EventArgs e)
        {
            cbb_Batch.Items.Clear();
            var result = from w in Global.db.tbl_Batches
                select w.fBatchName;

            if (result.Count() > 0)
            {
                cbb_Batch.Items.AddRange(result.ToArray());
                cbb_Batch.DisplayMember = "fBatchName";
                cbb_Batch.ValueMember = "fbatchname";
                cbb_Batch.Text = Global.StrBatch;
            }
        }

        public bool TableToExcel_AE(String strfilename, string TruongCoDinh)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Global.db.ExportExcel_AE(cbb_Batch.Text);
                Microsoft.Office.Interop.Excel.Application App = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook book = App.Workbooks.Open(strfilename, 0, true, 5, "", "", false,
                    Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                Microsoft.Office.Interop.Excel.Sheets _sheet = (Microsoft.Office.Interop.Excel.Sheets) book.Sheets;
                Microsoft.Office.Interop.Excel.Worksheet wrksheet =
                    (Microsoft.Office.Interop.Excel.Worksheet) book.ActiveSheet;
                int h = 2;
                string idimage = "";
                int i = 0;


                progressBarControl1.EditValue = 0;
                progressBarControl1.Properties.Step = 1;
                progressBarControl1.Properties.PercentView = true;
                progressBarControl1.Properties.Maximum = dataGridView1.Rows.Count;
                progressBarControl1.Properties.Minimum = 0;
                progressBarControl1.Properties.StartColor = Color.DarkRed; // choose the color 
                progressBarControl1.Properties.EndColor = Color.Green; // choose the color


                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {


                    wrksheet.Cells[h, 1] = dr.Cells[0].Value != null ? dr.Cells[0].Value.ToString() : ""; //tên image
                    wrksheet.Cells[h, 2] = TruongCoDinh; //TruongCoDinh 1
                    wrksheet.Cells[h, 3] = dr.Cells[2].Value != null ? dr.Cells[2].Value.ToString() : ""; //2
                    wrksheet.Cells[h, 4] = dr.Cells[3].Value != null ? dr.Cells[3].Value.ToString() : ""; //3
                    wrksheet.Cells[h, 5] = dr.Cells[4].Value != null ? dr.Cells[4].Value.ToString() : ""; //4
                    wrksheet.Cells[h, 6] = dr.Cells[5].Value != null ? dr.Cells[5].Value.ToString() : ""; //5
                    wrksheet.Cells[h, 7] = dr.Cells[6].Value != null ? dr.Cells[6].Value.ToString() : ""; //6
                    wrksheet.Cells[h, 8] = dr.Cells[7].Value != null ? dr.Cells[7].Value.ToString() : ""; //7
                    wrksheet.Cells[h, 9] = dr.Cells[8].Value != null ? dr.Cells[8].Value.ToString() : ""; //8
                    wrksheet.Cells[h, 10] = dr.Cells[9].Value != null ? dr.Cells[9].Value.ToString() : ""; //9
                    wrksheet.Cells[h, 11] = dr.Cells[10].Value != null ? dr.Cells[10].Value.ToString() : ""; //10
                    wrksheet.Cells[h, 12] = dr.Cells[11].Value != null ? dr.Cells[11].Value.ToString() : ""; //11
                    if (!string.IsNullOrEmpty(dr.Cells[20].Value.ToString()))
                    {
                        string[] temp = dr.Cells[20].Value.ToString().Split('\\');
                        switch (temp[2])
                        {
                            case "SOKA":
                                wrksheet.Cells[h, 13] = "EA1";
                                break;
                            case "TUKU":
                                wrksheet.Cells[h, 13] = "EA2";
                                break;
                            case "SIMO":
                                wrksheet.Cells[h, 13] = "EA8";
                                break;
                            case "YAMA":
                                wrksheet.Cells[h, 13] = "EA3";
                                break;
                            case "TONO":
                                wrksheet.Cells[h, 13] = "EA5";
                                break;
                            case "KAMA":
                                wrksheet.Cells[h, 13] = "EA4";
                                break;
                            case "BUTU":
                                wrksheet.Cells[h, 13] = "EA6";
                                break;
                            default:
                                wrksheet.Cells[h, 13] = dr.Cells[12].Value != null ? dr.Cells[12].Value.ToString() : ""; //12
                                break;
                        }
                    }

                    wrksheet.Cells[h, 14] = dr.Cells[13].Value != null ? dr.Cells[13].Value.ToString() : ""; //trong
                    wrksheet.Cells[h, 15] = dr.Cells[14].Value != null ? dr.Cells[14].Value.ToString() : ""; //trong
                    wrksheet.Cells[h, 16] = dr.Cells[15].Value != null ? dr.Cells[15].Value.ToString() : ""; //trong
                    wrksheet.Cells[h, 17] = dr.Cells[16].Value != null ? dr.Cells[16].Value.ToString() : ""; //trong
                    wrksheet.Cells[h, 18] = dr.Cells[17].Value != null ? dr.Cells[17].Value.ToString() : ""; //trong
                    wrksheet.Cells[h, 19] = dr.Cells[18].Value != null ? dr.Cells[18].Value.ToString() : ""; //trong
                    wrksheet.Cells[h, 20] = dr.Cells[19].Value != null ? dr.Cells[19].Value.ToString() : ""; //Path



                    lb_SoDong.Text = (h - 3) + "/" + dataGridView1.Rows.Count;
                    Range rowHead = wrksheet.get_Range("A2", "T" + h);
                    rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                    i++;
                    h++;
                    progressBarControl1.PerformStep();
                    progressBarControl1.Update();
                }
                string savePath = "";
                saveFileDialog1.Title = "Save Excel Files";
                saveFileDialog1.Filter = "Excel files (*.xls)|*.xls";
                saveFileDialog1.FileName = cbb_Batch.Text;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    book.SaveCopyAs(saveFileDialog1.FileName);
                    book.Saved = true;
                    savePath = Path.GetDirectoryName(saveFileDialog1.FileName);
                    App.Quit();
                }
                else
                {
                    MessageBox.Show("Lỗi khi xuất excel!");
                    return false;
                }
                Process.Start(savePath);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool TableToExcel_AT(String strfilename, string TruongCoDinh)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Global.db.ExportExcel_AE(cbb_Batch.Text);
                Microsoft.Office.Interop.Excel.Application App = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook book = App.Workbooks.Open(strfilename, 0, true, 5, "", "", false,
                    Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                Microsoft.Office.Interop.Excel.Sheets _sheet = (Microsoft.Office.Interop.Excel.Sheets)book.Sheets;
                Microsoft.Office.Interop.Excel.Worksheet wrksheet =
                    (Microsoft.Office.Interop.Excel.Worksheet)book.ActiveSheet;
                int h = 2;
                string idimage = "";
                int i = 0;


                progressBarControl1.EditValue = 0;
                progressBarControl1.Properties.Step = 1;
                progressBarControl1.Properties.PercentView = true;
                progressBarControl1.Properties.Maximum = dataGridView1.Rows.Count;
                progressBarControl1.Properties.Minimum = 0;
                progressBarControl1.Properties.StartColor = Color.DarkRed; // choose the color 
                progressBarControl1.Properties.EndColor = Color.Green; // choose the color


                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {


                    wrksheet.Cells[h, 1] = dr.Cells[0].Value != null ? dr.Cells[0].Value.ToString() : ""; //tên image
                    wrksheet.Cells[h, 2] = TruongCoDinh; //TruongCoDinh 1
                    wrksheet.Cells[h, 3] = dr.Cells[2].Value != null ? dr.Cells[2].Value.ToString() : "";
                    ; //2
                    wrksheet.Cells[h, 4] = dr.Cells[3].Value != null ? dr.Cells[3].Value.ToString() : "";
                    ; //3
                    wrksheet.Cells[h, 5] = dr.Cells[4].Value != null ? dr.Cells[4].Value.ToString() : "";
                    ; //4
                    wrksheet.Cells[h, 6] = dr.Cells[5].Value != null ? dr.Cells[5].Value.ToString() : "";
                    ; //5
                    wrksheet.Cells[h, 7] = dr.Cells[6].Value != null ? dr.Cells[6].Value.ToString() : "";
                    ; //6
                    wrksheet.Cells[h, 8] = dr.Cells[7].Value != null ? dr.Cells[7].Value.ToString() : "";
                    ; //7
                    wrksheet.Cells[h, 9] = dr.Cells[8].Value != null ? dr.Cells[8].Value.ToString() : "";
                    ; //8
                    wrksheet.Cells[h, 10] = dr.Cells[9].Value != null ? dr.Cells[9].Value.ToString() : "";
                    ; //9
                    wrksheet.Cells[h, 11] = dr.Cells[10].Value != null ? dr.Cells[10].Value.ToString() : "";
                    ; //10
                    wrksheet.Cells[h, 12] = dr.Cells[11].Value != null ? dr.Cells[11].Value.ToString() : "";
                    ; //11
                    wrksheet.Cells[h, 13] = dr.Cells[12].Value != null ? dr.Cells[12].Value.ToString() : "";
                    ; //12
                    wrksheet.Cells[h, 14] = dr.Cells[13].Value != null ? dr.Cells[13].Value.ToString() : "";
                    ; //trong
                    wrksheet.Cells[h, 15] = dr.Cells[14].Value != null ? dr.Cells[14].Value.ToString() : "";
                    ; //trong
                    wrksheet.Cells[h, 16] = dr.Cells[15].Value != null ? dr.Cells[15].Value.ToString() : "";
                    ; //trong
                    wrksheet.Cells[h, 17] = dr.Cells[16].Value != null ? dr.Cells[16].Value.ToString() : "";
                    ; //trong
                    wrksheet.Cells[h, 18] = dr.Cells[17].Value != null ? dr.Cells[17].Value.ToString() : "";
                    ; //trong
                    wrksheet.Cells[h, 19] = dr.Cells[18].Value != null ? dr.Cells[18].Value.ToString() : "";
                    ; //trong
                    wrksheet.Cells[h, 20] = dr.Cells[19].Value != null ? dr.Cells[19].Value.ToString() : "";
                    ; //Path



                    lb_SoDong.Text = (h - 3) + "/" + dataGridView1.Rows.Count;
                    Range rowHead = wrksheet.get_Range("A2", "T" + h);
                    rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                    i++;
                    h++;
                    progressBarControl1.PerformStep();
                    progressBarControl1.Update();
                }
                string savePath = "";
                saveFileDialog1.Title = "Save Excel Files";
                saveFileDialog1.Filter = "Excel files (*.xls)|*.xls";
                saveFileDialog1.FileName = cbb_Batch.Text;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    book.SaveCopyAs(saveFileDialog1.FileName);
                    book.Saved = true;
                    savePath = Path.GetDirectoryName(saveFileDialog1.FileName);
                    App.Quit();
                }
                else
                {
                    MessageBox.Show("Lỗi khi xuất excel!");
                    return false;
                }
                Process.Start(savePath);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


    }
}