namespace DXApplication_Exercise_04
{
    partial class FrmQuestion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuestion));
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.cmbAnswer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbClass = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtSoal = new DevExpress.XtraEditors.MemoEdit();
            this.cmbGroupName = new DevExpress.XtraEditors.LookUpEdit();
            this.dB_EFCF_DXApplication_Exercise_04DataSet = new DXApplication_Exercise_04.DB_EFCF_DXApplication_Exercise_04DataSet();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupsTableAdapter = new DXApplication_Exercise_04.DB_EFCF_DXApplication_Exercise_04DataSetTableAdapters.GroupsTableAdapter();
            this.txtCase1 = new DevExpress.XtraEditors.TextEdit();
            this.txtCase2 = new DevExpress.XtraEditors.TextEdit();
            this.txtCase3 = new DevExpress.XtraEditors.TextEdit();
            this.txtCase4 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAnswer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGroupName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EFCF_DXApplication_Exercise_04DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCase1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCase2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCase3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCase4.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Location = new System.Drawing.Point(43, 463);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(320, 40);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "ثبت";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbAnswer
            // 
            this.cmbAnswer.Location = new System.Drawing.Point(43, 394);
            this.cmbAnswer.Margin = new System.Windows.Forms.Padding(5);
            this.cmbAnswer.Name = "cmbAnswer";
            this.cmbAnswer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAnswer.Properties.Appearance.Options.UseFont = true;
            this.cmbAnswer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAnswer.Properties.Items.AddRange(new object[] {
            "گزینه 1",
            "گزینه 2",
            "گزینه 3",
            "گزینه 4"});
            this.cmbAnswer.Properties.MaxLength = 50;
            this.cmbAnswer.Properties.NullText = "جواب صحیح";
            this.cmbAnswer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbAnswer.Size = new System.Drawing.Size(320, 32);
            this.cmbAnswer.TabIndex = 7;
            // 
            // cmbClass
            // 
            this.cmbClass.Location = new System.Drawing.Point(43, 56);
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
            this.cmbClass.TabIndex = 1;
            // 
            // txtSoal
            // 
            this.txtSoal.Location = new System.Drawing.Point(43, 96);
            this.txtSoal.Name = "txtSoal";
            this.txtSoal.Properties.NullText = "متن سئوال";
            this.txtSoal.Size = new System.Drawing.Size(320, 87);
            this.txtSoal.TabIndex = 2;
            // 
            // cmbGroupName
            // 
            this.cmbGroupName.Location = new System.Drawing.Point(43, 13);
            this.cmbGroupName.Name = "cmbGroupName";
            this.cmbGroupName.Properties.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmbGroupName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGroupName.Properties.Appearance.Options.UseFont = true;
            this.cmbGroupName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbGroupName.Properties.DataSource = this.groupsBindingSource;
            this.cmbGroupName.Properties.DisplayMember = "GroupName";
            this.cmbGroupName.Properties.NullText = "انتخاب گروه";
            this.cmbGroupName.Properties.ValueMember = "Id";
            this.cmbGroupName.Size = new System.Drawing.Size(320, 30);
            this.cmbGroupName.TabIndex = 0;
            // 
            // dB_EFCF_DXApplication_Exercise_04DataSet
            // 
            this.dB_EFCF_DXApplication_Exercise_04DataSet.DataSetName = "DB_EFCF_DXApplication_Exercise_04DataSet";
            this.dB_EFCF_DXApplication_Exercise_04DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "Groups";
            this.groupsBindingSource.DataSource = this.dB_EFCF_DXApplication_Exercise_04DataSet;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // txtCase1
            // 
            this.txtCase1.Location = new System.Drawing.Point(43, 191);
            this.txtCase1.Margin = new System.Windows.Forms.Padding(5);
            this.txtCase1.Name = "txtCase1";
            this.txtCase1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCase1.Properties.Appearance.Options.UseFont = true;
            this.txtCase1.Properties.MaxLength = 50;
            this.txtCase1.Properties.NullText = "گزینه 1";
            this.txtCase1.Size = new System.Drawing.Size(320, 32);
            this.txtCase1.TabIndex = 3;
            // 
            // txtCase2
            // 
            this.txtCase2.Location = new System.Drawing.Point(43, 233);
            this.txtCase2.Margin = new System.Windows.Forms.Padding(5);
            this.txtCase2.Name = "txtCase2";
            this.txtCase2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCase2.Properties.Appearance.Options.UseFont = true;
            this.txtCase2.Properties.MaxLength = 50;
            this.txtCase2.Properties.NullText = "گزینه 2";
            this.txtCase2.Size = new System.Drawing.Size(320, 32);
            this.txtCase2.TabIndex = 4;
            // 
            // txtCase3
            // 
            this.txtCase3.Location = new System.Drawing.Point(43, 275);
            this.txtCase3.Margin = new System.Windows.Forms.Padding(5);
            this.txtCase3.Name = "txtCase3";
            this.txtCase3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCase3.Properties.Appearance.Options.UseFont = true;
            this.txtCase3.Properties.MaxLength = 50;
            this.txtCase3.Properties.NullText = "گزینه 3";
            this.txtCase3.Size = new System.Drawing.Size(320, 32);
            this.txtCase3.TabIndex = 5;
            // 
            // txtCase4
            // 
            this.txtCase4.Location = new System.Drawing.Point(43, 317);
            this.txtCase4.Margin = new System.Windows.Forms.Padding(5);
            this.txtCase4.Name = "txtCase4";
            this.txtCase4.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCase4.Properties.Appearance.Options.UseFont = true;
            this.txtCase4.Properties.MaxLength = 50;
            this.txtCase4.Properties.NullText = "گزینه 4";
            this.txtCase4.Size = new System.Drawing.Size(320, 32);
            this.txtCase4.TabIndex = 6;
            // 
            // FrmQuestion
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 519);
            this.Controls.Add(this.cmbGroupName);
            this.Controls.Add(this.txtSoal);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCase4);
            this.Controls.Add(this.txtCase3);
            this.Controls.Add(this.txtCase2);
            this.Controls.Add(this.txtCase1);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.cmbAnswer);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQuestion";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQuestion";
            this.Load += new System.EventHandler(this.FrmQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbAnswer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGroupName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EFCF_DXApplication_Exercise_04DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCase1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCase2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCase3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCase4.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAnswer;
        private DevExpress.XtraEditors.ComboBoxEdit cmbClass;
        private DevExpress.XtraEditors.MemoEdit txtSoal;
        private DevExpress.XtraEditors.LookUpEdit cmbGroupName;
        private DB_EFCF_DXApplication_Exercise_04DataSet dB_EFCF_DXApplication_Exercise_04DataSet;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private DB_EFCF_DXApplication_Exercise_04DataSetTableAdapters.GroupsTableAdapter groupsTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtCase1;
        private DevExpress.XtraEditors.TextEdit txtCase2;
        private DevExpress.XtraEditors.TextEdit txtCase3;
        private DevExpress.XtraEditors.TextEdit txtCase4;
    }
}