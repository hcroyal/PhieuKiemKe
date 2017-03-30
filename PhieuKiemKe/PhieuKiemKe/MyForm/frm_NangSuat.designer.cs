namespace PhieuKiemKe.MyForm
{
    partial class frm_NangSuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NangSuat));
            this.gridControl_LoaiAE = new DevExpress.XtraGrid.GridControl();
            this.dgv_Loai1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtp_EndDay = new System.Windows.Forms.DateTimePicker();
            this.dtp_FirstDay = new System.Windows.Forms.DateTimePicker();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tp_DeSo_LoaiAE = new DevExpress.XtraTab.XtraTabPage();
            this.tp_DeSo_LoaiAT = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl_LoaiAT = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_LoaiAE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Loai1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tp_DeSo_LoaiAE.SuspendLayout();
            this.tp_DeSo_LoaiAT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_LoaiAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_LoaiAE
            // 
            this.gridControl_LoaiAE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_LoaiAE.Location = new System.Drawing.Point(0, 0);
            this.gridControl_LoaiAE.MainView = this.dgv_Loai1;
            this.gridControl_LoaiAE.Name = "gridControl_LoaiAE";
            this.gridControl_LoaiAE.Size = new System.Drawing.Size(923, 531);
            this.gridControl_LoaiAE.TabIndex = 3;
            this.gridControl_LoaiAE.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_Loai1});
            // 
            // dgv_Loai1
            // 
            this.dgv_Loai1.Appearance.OddRow.BackColor = System.Drawing.Color.SeaShell;
            this.dgv_Loai1.Appearance.OddRow.BackColor2 = System.Drawing.Color.SeaShell;
            this.dgv_Loai1.Appearance.OddRow.Options.UseBackColor = true;
            this.dgv_Loai1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn6,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn7});
            this.dgv_Loai1.GridControl = this.gridControl_LoaiAE;
            this.dgv_Loai1.Name = "dgv_Loai1";
            this.dgv_Loai1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgv_Loai1.OptionsBehavior.Editable = false;
            this.dgv_Loai1.OptionsFind.AlwaysVisible = true;
            this.dgv_Loai1.OptionsView.EnableAppearanceOddRow = true;
            this.dgv_Loai1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "UserName";
            this.gridColumn1.FieldName = "UserName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 149;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Họ và tên";
            this.gridColumn2.FieldName = "FullName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 132;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Số phiếu nhập được";
            this.gridColumn6.FieldName = "SoPhieuNhap";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 138;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Số phiếu đúng";
            this.gridColumn3.FieldName = "PhieuDung";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 122;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Số phiếu sai";
            this.gridColumn4.FieldName = "PhieuSai";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 120;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn5.Caption = "Thời gian (h)";
            this.gridColumn5.FieldName = "ThoiGian";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 117;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Hiệu Suất";
            this.gridColumn7.FieldName = "HieuSuat";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 127;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dataGridView1);
            this.panelControl1.Controls.Add(this.dtp_EndDay);
            this.panelControl1.Controls.Add(this.dtp_FirstDay);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(929, 88);
            this.panelControl1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(600, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(56, 74);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            // 
            // dtp_EndDay
            // 
            this.dtp_EndDay.CustomFormat = "dd/MM/yyyy";
            this.dtp_EndDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_EndDay.Location = new System.Drawing.Point(278, 50);
            this.dtp_EndDay.Name = "dtp_EndDay";
            this.dtp_EndDay.Size = new System.Drawing.Size(143, 21);
            this.dtp_EndDay.TabIndex = 4;
            this.dtp_EndDay.ValueChanged += new System.EventHandler(this.dtp_EndDay_ValueChanged);
            // 
            // dtp_FirstDay
            // 
            this.dtp_FirstDay.CustomFormat = "dd/MM/yyyy";
            this.dtp_FirstDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_FirstDay.Location = new System.Drawing.Point(278, 18);
            this.dtp_FirstDay.Name = "dtp_FirstDay";
            this.dtp_FirstDay.Size = new System.Drawing.Size(143, 21);
            this.dtp_FirstDay.TabIndex = 4;
            this.dtp_FirstDay.ValueChanged += new System.EventHandler(this.dtp_FirstDay_ValueChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(439, 22);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(83, 45);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Xuất Excel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(221, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Đến ngày:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(228, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Từ ngày:";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 88);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tp_DeSo_LoaiAE;
            this.xtraTabControl1.Size = new System.Drawing.Size(929, 559);
            this.xtraTabControl1.TabIndex = 3;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tp_DeSo_LoaiAE,
            this.tp_DeSo_LoaiAT});
            // 
            // tp_DeSo_LoaiAE
            // 
            this.tp_DeSo_LoaiAE.Controls.Add(this.gridControl_LoaiAE);
            this.tp_DeSo_LoaiAE.Name = "tp_DeSo_LoaiAE";
            this.tp_DeSo_LoaiAE.Size = new System.Drawing.Size(923, 531);
            this.tp_DeSo_LoaiAE.Text = "Loại AE";
            // 
            // tp_DeSo_LoaiAT
            // 
            this.tp_DeSo_LoaiAT.Controls.Add(this.gridControl_LoaiAT);
            this.tp_DeSo_LoaiAT.Name = "tp_DeSo_LoaiAT";
            this.tp_DeSo_LoaiAT.Size = new System.Drawing.Size(923, 531);
            this.tp_DeSo_LoaiAT.Text = "Loại AT";
            // 
            // gridControl_LoaiAT
            // 
            this.gridControl_LoaiAT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_LoaiAT.Location = new System.Drawing.Point(0, 0);
            this.gridControl_LoaiAT.MainView = this.gridView1;
            this.gridControl_LoaiAT.Name = "gridControl_LoaiAT";
            this.gridControl_LoaiAT.Size = new System.Drawing.Size(923, 531);
            this.gridControl_LoaiAT.TabIndex = 4;
            this.gridControl_LoaiAT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.SeaShell;
            this.gridView1.Appearance.OddRow.BackColor2 = System.Drawing.Color.SeaShell;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14});
            this.gridView1.GridControl = this.gridControl_LoaiAT;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "UserName";
            this.gridColumn8.FieldName = "UserName";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            this.gridColumn8.Width = 149;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Họ và tên";
            this.gridColumn9.FieldName = "FullName";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 1;
            this.gridColumn9.Width = 132;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Số phiếu nhập được";
            this.gridColumn10.FieldName = "SoPhieuNhap";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 2;
            this.gridColumn10.Width = 138;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Số phiếu đúng";
            this.gridColumn11.FieldName = "PhieuDung";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 3;
            this.gridColumn11.Width = 122;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Số phiếu sai";
            this.gridColumn12.FieldName = "PhieuSai";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 4;
            this.gridColumn12.Width = 120;
            // 
            // gridColumn13
            // 
            this.gridColumn13.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn13.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn13.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn13.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn13.Caption = "Thời gian (h)";
            this.gridColumn13.FieldName = "ThoiGian";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 5;
            this.gridColumn13.Width = 117;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Hiệu Suất";
            this.gridColumn14.FieldName = "HieuSuat";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 6;
            this.gridColumn14.Width = 127;
            // 
            // frm_NangSuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 647);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_NangSuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Năng suất";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_NangSuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_LoaiAE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Loai1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tp_DeSo_LoaiAE.ResumeLayout(false);
            this.tp_DeSo_LoaiAT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_LoaiAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_LoaiAE;
        private DevExpress.XtraGrid.Views.Grid.GridView dgv_Loai1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtp_EndDay;
        private System.Windows.Forms.DateTimePicker dtp_FirstDay;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tp_DeSo_LoaiAE;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraTab.XtraTabPage tp_DeSo_LoaiAT;
        private DevExpress.XtraGrid.GridControl gridControl_LoaiAT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
    }
}