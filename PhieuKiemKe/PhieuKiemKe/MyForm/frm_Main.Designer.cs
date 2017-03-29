namespace PhieuKiemKe
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btn_Logout = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Exit = new DevExpress.XtraBars.BarButtonItem();
            this.btn_quanmly = new DevExpress.XtraBars.BarSubItem();
            this.btn_QuanLyBatch = new DevExpress.XtraBars.BarButtonItem();
            this.btn_QuanLyUser = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Check = new DevExpress.XtraBars.BarButtonItem();
            this.btn_NangSuat = new DevExpress.XtraBars.BarButtonItem();
            this.btn_TienDo = new DevExpress.XtraBars.BarButtonItem();
            this.btn_XuatExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ZoomImage = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lb_SoHinhLamDuoc = new DevExpress.XtraEditors.LabelControl();
            this.lb_SoHinhConLai = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lb_TongSoHinh = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lb_UserName = new DevExpress.XtraEditors.LabelControl();
            this.lb_IdImage = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lb_fBatchName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.tabControl_Main = new DevExpress.XtraTab.XtraTabControl();
            this.tp_AE_Main = new DevExpress.XtraTab.XtraTabPage();
            this.uc_AE1 = new PhieuKiemKe.MyUserControl.uc_AE();
            this.tp_AT_Main = new DevExpress.XtraTab.XtraTabPage();
            this.uC_AT1 = new PhieuKiemKe.MyUserControl.UC_AT();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Pause = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Submit_Logout = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Start_Submit = new DevExpress.XtraEditors.SimpleButton();
            this.uc_PictureBox1 = new PhieuKiemKe.MyUserControl.uc_PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl_Main)).BeginInit();
            this.tabControl_Main.SuspendLayout();
            this.tp_AE_Main.SuspendLayout();
            this.tp_AT_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.btn_quanmly,
            this.barSubItem3,
            this.btn_ZoomImage,
            this.btn_Logout,
            this.btn_Exit,
            this.btn_QuanLyBatch,
            this.btn_QuanLyUser,
            this.btn_Check,
            this.btn_NangSuat,
            this.btn_TienDo,
            this.btn_XuatExcel});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 13;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_quanmly),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ZoomImage)});
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Menu";
            this.barSubItem1.Id = 1;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Logout),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Exit)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btn_Logout
            // 
            this.btn_Logout.Caption = "&Logout";
            this.btn_Logout.Id = 5;
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Logout_ItemClick);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Caption = "&Exit";
            this.btn_Exit.Id = 6;
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Exit_ItemClick);
            // 
            // btn_quanmly
            // 
            this.btn_quanmly.Caption = "Quản Lý";
            this.btn_quanmly.Id = 2;
            this.btn_quanmly.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_QuanLyBatch),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_QuanLyUser),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Check),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_NangSuat),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_TienDo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_XuatExcel)});
            this.btn_quanmly.Name = "btn_quanmly";
            // 
            // btn_QuanLyBatch
            // 
            this.btn_QuanLyBatch.Caption = "Quản lý &Batch";
            this.btn_QuanLyBatch.Id = 7;
            this.btn_QuanLyBatch.Name = "btn_QuanLyBatch";
            this.btn_QuanLyBatch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_QuanLyBatch_ItemClick);
            // 
            // btn_QuanLyUser
            // 
            this.btn_QuanLyUser.Caption = "Quản lý &User";
            this.btn_QuanLyUser.Id = 8;
            this.btn_QuanLyUser.Name = "btn_QuanLyUser";
            this.btn_QuanLyUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_QuanLyUser_ItemClick);
            // 
            // btn_Check
            // 
            this.btn_Check.Caption = "&Check";
            this.btn_Check.Id = 9;
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Check_ItemClick);
            // 
            // btn_NangSuat
            // 
            this.btn_NangSuat.Caption = "&Năng suất";
            this.btn_NangSuat.Id = 10;
            this.btn_NangSuat.Name = "btn_NangSuat";
            this.btn_NangSuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_NangSuat_ItemClick);
            // 
            // btn_TienDo
            // 
            this.btn_TienDo.Caption = "&Tiến độ";
            this.btn_TienDo.Id = 11;
            this.btn_TienDo.Name = "btn_TienDo";
            // 
            // btn_XuatExcel
            // 
            this.btn_XuatExcel.Caption = "Xuất &Excel";
            this.btn_XuatExcel.Id = 12;
            this.btn_XuatExcel.Name = "btn_XuatExcel";
            this.btn_XuatExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_XuatExcel_ItemClick);
            // 
            // btn_ZoomImage
            // 
            this.btn_ZoomImage.Caption = "ZoomImage";
            this.btn_ZoomImage.Id = 4;
            this.btn_ZoomImage.Name = "btn_ZoomImage";
            this.btn_ZoomImage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ZoomImage_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1062, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 541);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1062, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 519);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1062, 22);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 519);
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "barSubItem3";
            this.barSubItem3.Id = 3;
            this.barSubItem3.Name = "barSubItem3";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lb_SoHinhLamDuoc);
            this.panelControl1.Controls.Add(this.lb_SoHinhConLai);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.lb_TongSoHinh);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.lb_UserName);
            this.panelControl1.Controls.Add(this.lb_IdImage);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.lb_fBatchName);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 22);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1062, 29);
            this.panelControl1.TabIndex = 4;
            // 
            // lb_SoHinhLamDuoc
            // 
            this.lb_SoHinhLamDuoc.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb_SoHinhLamDuoc.Appearance.Options.UseForeColor = true;
            this.lb_SoHinhLamDuoc.Location = new System.Drawing.Point(301, 8);
            this.lb_SoHinhLamDuoc.Name = "lb_SoHinhLamDuoc";
            this.lb_SoHinhLamDuoc.Size = new System.Drawing.Size(24, 13);
            this.lb_SoHinhLamDuoc.TabIndex = 13;
            this.lb_SoHinhLamDuoc.Text = "1000";
            // 
            // lb_SoHinhConLai
            // 
            this.lb_SoHinhConLai.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.lb_SoHinhConLai.Appearance.Options.UseForeColor = true;
            this.lb_SoHinhConLai.Location = new System.Drawing.Point(181, 8);
            this.lb_SoHinhConLai.Name = "lb_SoHinhConLai";
            this.lb_SoHinhConLai.Size = new System.Drawing.Size(24, 13);
            this.lb_SoHinhConLai.TabIndex = 14;
            this.lb_SoHinhConLai.Text = "1000";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(241, 8);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(58, 13);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "Số hình làm:";
            // 
            // lb_TongSoHinh
            // 
            this.lb_TongSoHinh.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lb_TongSoHinh.Appearance.Options.UseForeColor = true;
            this.lb_TongSoHinh.Location = new System.Drawing.Point(61, 8);
            this.lb_TongSoHinh.Name = "lb_TongSoHinh";
            this.lb_TongSoHinh.Size = new System.Drawing.Size(24, 13);
            this.lb_TongSoHinh.TabIndex = 16;
            this.lb_TongSoHinh.Text = "1000";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(121, 8);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 13);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Số hình còn:";
            // 
            // lb_UserName
            // 
            this.lb_UserName.Location = new System.Drawing.Point(932, 8);
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(49, 13);
            this.lb_UserName.TabIndex = 18;
            this.lb_UserName.Text = "UserName";
            // 
            // lb_IdImage
            // 
            this.lb_IdImage.Location = new System.Drawing.Point(647, 8);
            this.lb_IdImage.Name = "lb_IdImage";
            this.lb_IdImage.Size = new System.Drawing.Size(6, 13);
            this.lb_IdImage.TabIndex = 19;
            this.lb_IdImage.Text = "0";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(873, 8);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 13);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "UserName:";
            // 
            // lb_fBatchName
            // 
            this.lb_fBatchName.Location = new System.Drawing.Point(-174, 6);
            this.lb_fBatchName.Name = "lb_fBatchName";
            this.lb_fBatchName.Size = new System.Drawing.Size(31, 13);
            this.lb_fBatchName.TabIndex = 21;
            this.lb_fBatchName.Text = "Batch:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(597, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 13);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "IdImage:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 23;
            this.labelControl2.Text = "Tổng hình:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(-211, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Batch:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.tabControl_Main);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(607, 51);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(455, 490);
            this.panelControl2.TabIndex = 5;
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Location = new System.Drawing.Point(2, 2);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedTabPage = this.tp_AE_Main;
            this.tabControl_Main.Size = new System.Drawing.Size(451, 460);
            this.tabControl_Main.TabIndex = 1;
            this.tabControl_Main.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tp_AE_Main,
            this.tp_AT_Main});
            // 
            // tp_AE_Main
            // 
            this.tp_AE_Main.Controls.Add(this.uc_AE1);
            this.tp_AE_Main.Name = "tp_AE_Main";
            this.tp_AE_Main.Size = new System.Drawing.Size(445, 432);
            this.tp_AE_Main.Text = "AE";
            // 
            // uc_AE1
            // 
            this.uc_AE1.AutoScroll = true;
            this.uc_AE1.AutoSize = true;
            this.uc_AE1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_AE1.Location = new System.Drawing.Point(0, 0);
            this.uc_AE1.Name = "uc_AE1";
            this.uc_AE1.Size = new System.Drawing.Size(445, 432);
            this.uc_AE1.TabIndex = 0;
            // 
            // tp_AT_Main
            // 
            this.tp_AT_Main.Controls.Add(this.uC_AT1);
            this.tp_AT_Main.Name = "tp_AT_Main";
            this.tp_AT_Main.Size = new System.Drawing.Size(445, 432);
            this.tp_AT_Main.Text = "AT";
            // 
            // uC_AT1
            // 
            this.uC_AT1.AutoScroll = true;
            this.uC_AT1.AutoSize = true;
            this.uC_AT1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_AT1.Location = new System.Drawing.Point(0, 0);
            this.uC_AT1.Name = "uC_AT1";
            this.uC_AT1.Size = new System.Drawing.Size(445, 432);
            this.uC_AT1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btn_Pause);
            this.panelControl3.Controls.Add(this.btn_Submit_Logout);
            this.panelControl3.Controls.Add(this.btn_Start_Submit);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(2, 462);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(451, 26);
            this.panelControl3.TabIndex = 0;
            // 
            // btn_Pause
            // 
            this.btn_Pause.Location = new System.Drawing.Point(249, 2);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(95, 23);
            this.btn_Pause.TabIndex = 14;
            this.btn_Pause.Text = "Tạm dừng (ESC)";
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_Submit_Logout
            // 
            this.btn_Submit_Logout.Location = new System.Drawing.Point(133, 3);
            this.btn_Submit_Logout.Name = "btn_Submit_Logout";
            this.btn_Submit_Logout.Size = new System.Drawing.Size(90, 21);
            this.btn_Submit_Logout.TabIndex = 12;
            this.btn_Submit_Logout.Text = "Submit + Logout";
            this.btn_Submit_Logout.Click += new System.EventHandler(this.btn_Submit_Logout_Click);
            // 
            // btn_Start_Submit
            // 
            this.btn_Start_Submit.Location = new System.Drawing.Point(3, 3);
            this.btn_Start_Submit.Name = "btn_Start_Submit";
            this.btn_Start_Submit.Size = new System.Drawing.Size(90, 21);
            this.btn_Start_Submit.TabIndex = 13;
            this.btn_Start_Submit.Text = "Start";
            this.btn_Start_Submit.Click += new System.EventHandler(this.btn_Start_Submit_Click);
            // 
            // uc_PictureBox1
            // 
            this.uc_PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_PictureBox1.Location = new System.Drawing.Point(0, 51);
            this.uc_PictureBox1.Name = "uc_PictureBox1";
            this.uc_PictureBox1.Size = new System.Drawing.Size(607, 490);
            this.uc_PictureBox1.TabIndex = 10;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 541);
            this.Controls.Add(this.uc_PictureBox1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.Name = "frm_Main";
            this.Text = "Phiếu kiểm kê";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Main_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl_Main)).EndInit();
            this.tabControl_Main.ResumeLayout(false);
            this.tp_AE_Main.ResumeLayout(false);
            this.tp_AE_Main.PerformLayout();
            this.tp_AT_Main.ResumeLayout(false);
            this.tp_AT_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btn_Logout;
        private DevExpress.XtraBars.BarButtonItem btn_Exit;
        private DevExpress.XtraBars.BarSubItem btn_quanmly;
        private DevExpress.XtraBars.BarButtonItem btn_QuanLyBatch;
        private DevExpress.XtraBars.BarButtonItem btn_QuanLyUser;
        private DevExpress.XtraBars.BarButtonItem btn_Check;
        private DevExpress.XtraBars.BarButtonItem btn_NangSuat;
        private DevExpress.XtraBars.BarButtonItem btn_TienDo;
        private DevExpress.XtraBars.BarButtonItem btn_XuatExcel;
        private DevExpress.XtraBars.BarButtonItem btn_ZoomImage;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lb_SoHinhLamDuoc;
        private DevExpress.XtraEditors.LabelControl lb_SoHinhConLai;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lb_TongSoHinh;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lb_UserName;
        private DevExpress.XtraEditors.LabelControl lb_IdImage;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lb_fBatchName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private MyUserControl.uc_PictureBox uc_PictureBox1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_Pause;
        private DevExpress.XtraEditors.SimpleButton btn_Submit_Logout;
        private DevExpress.XtraEditors.SimpleButton btn_Start_Submit;
        private DevExpress.XtraTab.XtraTabControl tabControl_Main;
        private DevExpress.XtraTab.XtraTabPage tp_AE_Main;
        private DevExpress.XtraTab.XtraTabPage tp_AT_Main;
        private MyUserControl.uc_AE uc_AE1;
        private MyUserControl.UC_AT uC_AT1;
    }
}

