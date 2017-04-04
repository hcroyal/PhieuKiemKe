using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;

namespace PhieuKiemKe.MyUserControl
{
    partial class uc_AT_Rows
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.txt_STT = new DevExpress.XtraEditors.TextEdit();
            this.txt_TruongSo10 = new DevExpress.XtraEditors.TextEdit();
            this.txt_TruongSo08 = new DevExpress.XtraEditors.TextEdit();
            this.txt_TruongSo09 = new DevExpress.XtraEditors.TextEdit();
            this.txt_TruongSo07 = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_STT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TruongSo10.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TruongSo08.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TruongSo09.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TruongSo07.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_STT
            // 
            this.txt_STT.Location = new System.Drawing.Point(1, 1);
            this.txt_STT.Name = "txt_STT";
            this.txt_STT.Properties.ReadOnly = true;
            this.txt_STT.Size = new System.Drawing.Size(30, 20);
            this.txt_STT.TabIndex = 0;
            this.txt_STT.TabStop = false;
            // 
            // txt_TruongSo10
            // 
            this.txt_TruongSo10.Location = new System.Drawing.Point(229, 1);
            this.txt_TruongSo10.Name = "txt_TruongSo10";
            this.txt_TruongSo10.Size = new System.Drawing.Size(30, 20);
            this.txt_TruongSo10.TabIndex = 2;
            this.txt_TruongSo10.EditValueChanged += new System.EventHandler(this.txt_TruongSo10_EditValueChanged);
            this.txt_TruongSo10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_TruongSo10_KeyDown);
            // 
            // txt_TruongSo08
            // 
            this.txt_TruongSo08.Location = new System.Drawing.Point(258, 1);
            this.txt_TruongSo08.Name = "txt_TruongSo08";
            this.txt_TruongSo08.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_TruongSo08.Size = new System.Drawing.Size(100, 20);
            this.txt_TruongSo08.TabIndex = 3;
            this.txt_TruongSo08.EditValueChanged += new System.EventHandler(this.txt_TruongSo08_EditValueChanged);
            this.txt_TruongSo08.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_TruongSo08_KeyDown);
            // 
            // txt_TruongSo09
            // 
            this.txt_TruongSo09.Location = new System.Drawing.Point(357, 1);
            this.txt_TruongSo09.Name = "txt_TruongSo09";
            this.txt_TruongSo09.Size = new System.Drawing.Size(78, 20);
            this.txt_TruongSo09.TabIndex = 4;
            this.txt_TruongSo09.EditValueChanged += new System.EventHandler(this.txt_TruongSo09_EditValueChanged);
            this.txt_TruongSo09.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_TruongSo09_KeyDown);
            // 
            // txt_TruongSo07
            // 
            this.txt_TruongSo07.Location = new System.Drawing.Point(30, 1);
            this.txt_TruongSo07.Name = "txt_TruongSo07";
            this.txt_TruongSo07.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txt_TruongSo07.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.txt_TruongSo07.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_TruongSo07.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_TruongSo07.Properties.NullText = "";
            this.txt_TruongSo07.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txt_TruongSo07.Size = new System.Drawing.Size(200, 20);
            this.txt_TruongSo07.TabIndex = 1;
            this.txt_TruongSo07.TextChanged += new System.EventHandler(this.txt_TruongSo07_TextChanged);
            this.txt_TruongSo07.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_TruongSo07_KeyDown);
            // 
            // uc_AT_Rows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txt_TruongSo07);
            this.Controls.Add(this.txt_TruongSo09);
            this.Controls.Add(this.txt_TruongSo08);
            this.Controls.Add(this.txt_TruongSo10);
            this.Controls.Add(this.txt_STT);
            this.Name = "uc_AT_Rows";
            this.Size = new System.Drawing.Size(436, 21);
            this.Load += new System.EventHandler(this.uc_AT_Rows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_STT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TruongSo10.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TruongSo08.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TruongSo09.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TruongSo07.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public TextEdit txt_STT;
        public TextEdit txt_TruongSo10;
        public TextEdit txt_TruongSo08;
        public TextEdit txt_TruongSo09;
        public LookUpEdit txt_TruongSo07;
    }
}
