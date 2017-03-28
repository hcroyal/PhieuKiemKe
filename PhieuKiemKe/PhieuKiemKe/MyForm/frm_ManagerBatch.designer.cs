﻿namespace PhieuKiemKe.MyForm
{
    partial class frm_ManagerBatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ManagerBatch));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_TaoBatch = new DevExpress.XtraEditors.SimpleButton();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDBatch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fBatchName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fdatecreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fusercreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fPathPicture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fSoLuongAnh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChiaUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit3)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit1.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_TaoBatch);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 376);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(840, 65);
            this.panelControl1.TabIndex = 1;
            // 
            // btn_TaoBatch
            // 
            this.btn_TaoBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TaoBatch.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_TaoBatch.Appearance.Options.UseFont = true;
            this.btn_TaoBatch.Location = new System.Drawing.Point(351, 5);
            this.btn_TaoBatch.Name = "btn_TaoBatch";
            this.btn_TaoBatch.Size = new System.Drawing.Size(126, 55);
            this.btn_TaoBatch.TabIndex = 0;
            this.btn_TaoBatch.Text = "Tạo Batch";
            this.btn_TaoBatch.Click += new System.EventHandler(this.btn_TaoBatch_Click);
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.AutoHeight = false;
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit2.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            this.repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit3});
            this.gridControl1.Size = new System.Drawing.Size(840, 376);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDBatch,
            this.fBatchName,
            this.fdatecreated,
            this.fusercreate,
            this.fPathPicture,
            this.fLocation,
            this.fSoLuongAnh,
            this.ChiaUser,
            this.gridColumn8});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // IDBatch
            // 
            this.IDBatch.Caption = "IDBatch";
            this.IDBatch.FieldName = "IDBatch";
            this.IDBatch.Name = "IDBatch";
            this.IDBatch.Visible = true;
            this.IDBatch.VisibleIndex = 0;
            // 
            // fBatchName
            // 
            this.fBatchName.Caption = "Tên Batch";
            this.fBatchName.FieldName = "fBatchName";
            this.fBatchName.Name = "fBatchName";
            this.fBatchName.Visible = true;
            this.fBatchName.VisibleIndex = 1;
            // 
            // fdatecreated
            // 
            this.fdatecreated.Caption = "Ngày tạo Batch";
            this.fdatecreated.FieldName = "fdatecreated";
            this.fdatecreated.Name = "fdatecreated";
            this.fdatecreated.Visible = true;
            this.fdatecreated.VisibleIndex = 2;
            // 
            // fusercreate
            // 
            this.fusercreate.Caption = "User tạo Batch";
            this.fusercreate.FieldName = "fusercreate";
            this.fusercreate.Name = "fusercreate";
            this.fusercreate.Visible = true;
            this.fusercreate.VisibleIndex = 3;
            // 
            // fPathPicture
            // 
            this.fPathPicture.Caption = "Đường dẫn up Batch";
            this.fPathPicture.FieldName = "fPathPicture";
            this.fPathPicture.Name = "fPathPicture";
            this.fPathPicture.Visible = true;
            this.fPathPicture.VisibleIndex = 4;
            // 
            // fLocation
            // 
            this.fLocation.Caption = "Path xuất trong excel";
            this.fLocation.FieldName = "fLocation";
            this.fLocation.Name = "fLocation";
            this.fLocation.Visible = true;
            this.fLocation.VisibleIndex = 5;
            // 
            // fSoLuongAnh
            // 
            this.fSoLuongAnh.Caption = "Số lượng ảnh";
            this.fSoLuongAnh.FieldName = "fSoLuongAnh";
            this.fSoLuongAnh.Name = "fSoLuongAnh";
            this.fSoLuongAnh.Visible = true;
            this.fSoLuongAnh.VisibleIndex = 6;
            // 
            // ChiaUser
            // 
            this.ChiaUser.Caption = "ChiaUser";
            this.ChiaUser.FieldName = "ChiaUser";
            this.ChiaUser.Name = "ChiaUser";
            this.ChiaUser.Visible = true;
            this.ChiaUser.VisibleIndex = 7;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Xoá Batch";
            this.gridColumn8.ColumnEdit = this.repositoryItemButtonEdit3;
            this.gridColumn8.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 8;
            // 
            // repositoryItemButtonEdit3
            // 
            this.repositoryItemButtonEdit3.AutoHeight = false;
            this.repositoryItemButtonEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit3.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.repositoryItemButtonEdit3.Name = "repositoryItemButtonEdit3";
            this.repositoryItemButtonEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit3.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit3_ButtonClick);
            // 
            // frm_ManagerBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 441);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frm_ManagerBatch";
            this.Text = "frm_ManagerBatch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_ManagerBatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_TaoBatch;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn IDBatch;
        private DevExpress.XtraGrid.Columns.GridColumn fBatchName;
        private DevExpress.XtraGrid.Columns.GridColumn fdatecreated;
        private DevExpress.XtraGrid.Columns.GridColumn fusercreate;
        private DevExpress.XtraGrid.Columns.GridColumn fPathPicture;
        private DevExpress.XtraGrid.Columns.GridColumn fLocation;
        private DevExpress.XtraGrid.Columns.GridColumn fSoLuongAnh;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn ChiaUser;
    }
}