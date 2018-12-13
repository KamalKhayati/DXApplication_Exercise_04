namespace DXApplication_Exercise_04
{
    partial class FrmLogin
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
            this.txtDBPath = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnBrowser = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtDBPath.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDBPath
            // 
            this.txtDBPath.Location = new System.Drawing.Point(14, 14);
            this.txtDBPath.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDBPath.Name = "txtDBPath";
            this.txtDBPath.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txtDBPath.Properties.Appearance.Options.UseFont = true;
            this.txtDBPath.Size = new System.Drawing.Size(348, 30);
            this.txtDBPath.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(14, 68);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(423, 54);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "ذخیره مسیر فایل دیتابیس";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(368, 12);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(69, 32);
            this.btnBrowser.TabIndex = 2;
            this.btnBrowser.Text = "...";
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // FrmLogin
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 148);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDBPath);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogin_FormClosed);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDBPath.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnBrowser;
        public DevExpress.XtraEditors.TextEdit txtDBPath;
    }
}