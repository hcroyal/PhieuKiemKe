namespace PhieuKiemKe.MyUserControl
{
    partial class uc_AE_Rows
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_TruongSo09 = new DevExpress.XtraEditors.TextEdit();
            this.txt_STT = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TruongSo09.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_STT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_TruongSo09
            // 
            this.txt_TruongSo09.Location = new System.Drawing.Point(31, 1);
            this.txt_TruongSo09.Name = "txt_TruongSo09";
            this.txt_TruongSo09.Size = new System.Drawing.Size(173, 20);
            this.txt_TruongSo09.TabIndex = 0;
            // 
            // txt_STT
            // 
            this.txt_STT.Location = new System.Drawing.Point(1, 1);
            this.txt_STT.Name = "txt_STT";
            this.txt_STT.Size = new System.Drawing.Size(30, 20);
            this.txt_STT.TabIndex = 1;
            this.txt_STT.TabStop = false;
            // 
            // uc_AE_Rows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txt_STT);
            this.Controls.Add(this.txt_TruongSo09);
            this.Name = "uc_AE_Rows";
            this.Size = new System.Drawing.Size(207, 24);
            ((System.ComponentModel.ISupportInitialize)(this.txt_TruongSo09.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_STT.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_TruongSo09;
        public DevExpress.XtraEditors.TextEdit txt_STT;
    }
}
