namespace DXApplication_Exercise_04
{
    partial class FrmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            this.txtFName = new DevExpress.XtraEditors.TextEdit();
            this.txtLName = new DevExpress.XtraEditors.TextEdit();
            this.cmbClass = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtFName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbClass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(14, 14);
            this.txtFName.Margin = new System.Windows.Forms.Padding(5);
            this.txtFName.Name = "txtFName";
            this.txtFName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Properties.Appearance.Options.UseFont = true;
            this.txtFName.Properties.MaxLength = 50;
            this.txtFName.Properties.NullText = "نام";
            this.txtFName.Size = new System.Drawing.Size(320, 32);
            this.txtFName.TabIndex = 0;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(14, 69);
            this.txtLName.Margin = new System.Windows.Forms.Padding(5);
            this.txtLName.Name = "txtLName";
            this.txtLName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Properties.Appearance.Options.UseFont = true;
            this.txtLName.Properties.MaxLength = 50;
            this.txtLName.Properties.NullText = "نام خانوادگی";
            this.txtLName.Size = new System.Drawing.Size(320, 32);
            this.txtLName.TabIndex = 0;
            // 
            // cmbClass
            // 
            this.cmbClass.Location = new System.Drawing.Point(14, 125);
            this.cmbClass.Margin = new System.Windows.Forms.Padding(5);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClass.Properties.Appearance.Options.UseFont = true;
            this.cmbClass.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbClass.Properties.Items.AddRange(new object[] {
            "اول",
            "دوم",
            "سوم",
            "چهارم",
            "پنجم",
            "ششم",
            "هفتم",
            "هشتم",
            "نهم",
            "دهم"});
            this.cmbClass.Properties.MaxLength = 50;
            this.cmbClass.Properties.NullText = "انتخاب کلاس";
            this.cmbClass.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbClass.Size = new System.Drawing.Size(320, 32);
            this.cmbClass.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Location = new System.Drawing.Point(14, 176);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(320, 40);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ثبت";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmUser
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 232);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.cmbClass);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUser";
            ((System.ComponentModel.ISupportInitialize)(this.txtFName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbClass.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtFName;
        private DevExpress.XtraEditors.TextEdit txtLName;
        private DevExpress.XtraEditors.ComboBoxEdit cmbClass;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
    }
}