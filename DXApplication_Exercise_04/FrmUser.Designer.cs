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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            this.txtFName = new DevExpress.XtraEditors.TextEdit();
            this.txtLName = new DevExpress.XtraEditors.TextEdit();
            this.cmbClass = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_EFCF_DXApplication_Exercise_04DataSet11 = new DXApplication_Exercise_04.DB_EFCF_DXApplication_Exercise_04DataSet1();
            this.usersTableAdapter1 = new DXApplication_Exercise_04.DB_EFCF_DXApplication_Exercise_04DataSet1TableAdapters.UsersTableAdapter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtFName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EFCF_DXApplication_Exercise_04DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFName
            // 
            this.txtFName.Enabled = false;
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
            this.txtLName.Enabled = false;
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
            this.cmbClass.Enabled = false;
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
            this.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Location = new System.Drawing.Point(185, 176);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 40);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ثبت";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dB_EFCF_DXApplication_Exercise_04DataSet11;
            this.usersBindingSource.Sort = "";
            // 
            // dB_EFCF_DXApplication_Exercise_04DataSet11
            // 
            this.dB_EFCF_DXApplication_Exercise_04DataSet11.DataSetName = "DB_EFCF_DXApplication_Exercise_04DataSet1";
            this.dB_EFCF_DXApplication_Exercise_04DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Location = new System.Drawing.Point(14, 228);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(319, 266);
            this.panelControl1.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.usersBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(315, 262);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl1_KeyDown);
            this.gridControl1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridControl1_KeyUp);
            this.gridControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFName,
            this.colLName,
            this.colClass});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsNavigation.AutoMoveRowFocus = false;
            this.gridView1.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.FocusedRowLoaded += new DevExpress.XtraGrid.Views.Base.RowEventHandler(this.gridView1_FocusedRowLoaded);
            // 
            // colId
            // 
            this.colId.Caption = "آیدی";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colFName
            // 
            this.colFName.Caption = "نام";
            this.colFName.FieldName = "FName";
            this.colFName.Name = "colFName";
            this.colFName.Visible = true;
            this.colFName.VisibleIndex = 1;
            // 
            // colLName
            // 
            this.colLName.Caption = "نام خانوادگی";
            this.colLName.FieldName = "LName";
            this.colLName.Name = "colLName";
            this.colLName.Visible = true;
            this.colLName.VisibleIndex = 2;
            // 
            // colClass
            // 
            this.colClass.Caption = "کلاس";
            this.colClass.FieldName = "Class";
            this.colClass.Name = "colClass";
            this.colClass.Visible = true;
            this.colClass.VisibleIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnDelete.Location = new System.Drawing.Point(14, 176);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 40);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "حذف";
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmUser
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 503);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panelControl1);
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
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EFCF_DXApplication_Exercise_04DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtFName;
        private DevExpress.XtraEditors.TextEdit txtLName;
        private DevExpress.XtraEditors.ComboBoxEdit cmbClass;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DB_EFCF_DXApplication_Exercise_04DataSet1 dB_EFCF_DXApplication_Exercise_04DataSet11;
        private DB_EFCF_DXApplication_Exercise_04DataSet1TableAdapters.UsersTableAdapter usersTableAdapter1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFName;
        private DevExpress.XtraGrid.Columns.GridColumn colLName;
        private DevExpress.XtraGrid.Columns.GridColumn colClass;
        public DevExpress.XtraEditors.SimpleButton btnAdd;
        public DevExpress.XtraEditors.SimpleButton btnDelete;
    }
}