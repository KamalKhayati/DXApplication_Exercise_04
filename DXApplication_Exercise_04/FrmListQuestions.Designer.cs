namespace DXApplication_Exercise_04
{
    partial class FrmListQuestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListQuestions));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlQuestion = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnGroupId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnClass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnQuestionText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCase1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCase2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCase3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCase4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnAnswer = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(798, 629);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.simpleButton4);
            this.panelControl2.Controls.Add(this.simpleButton3);
            this.panelControl2.Controls.Add(this.simpleButton2);
            this.panelControl2.Controls.Add(this.simpleButton1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(794, 100);
            this.panelControl2.TabIndex = 1;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gridControlQuestion);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 102);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(794, 525);
            this.panelControl3.TabIndex = 2;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(633, 12);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(153, 73);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "ثبت";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.Location = new System.Drawing.Point(327, 12);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(5);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(153, 73);
            this.simpleButton3.TabIndex = 0;
            this.simpleButton3.Text = "حذف";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(480, 12);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(5);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(153, 73);
            this.simpleButton2.TabIndex = 0;
            this.simpleButton2.Text = "ویرایش";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton4.ImageOptions.SvgImage")));
            this.simpleButton4.Location = new System.Drawing.Point(7, 12);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(5);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(153, 73);
            this.simpleButton4.TabIndex = 0;
            this.simpleButton4.Text = "بستن فرم";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // gridControlQuestion
            // 
            this.gridControlQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlQuestion.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControlQuestion.Location = new System.Drawing.Point(2, 2);
            this.gridControlQuestion.MainView = this.gridView1;
            this.gridControlQuestion.Name = "gridControlQuestion";
            this.gridControlQuestion.Size = new System.Drawing.Size(790, 521);
            this.gridControlQuestion.TabIndex = 0;
            this.gridControlQuestion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControlQuestion.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnId,
            this.ColumnCode,
            this.ColumnGroupId,
            this.ColumnClass,
            this.ColumnQuestionText,
            this.ColumnCase1,
            this.ColumnCase2,
            this.ColumnCase3,
            this.ColumnCase4,
            this.ColumnAnswer});
            this.gridView1.GridControl = this.gridControlQuestion;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // ColumnId
            // 
            this.ColumnId.Caption = "آیدی";
            this.ColumnId.FieldName = "Code";
            this.ColumnId.Name = "ColumnId";
            // 
            // ColumnCode
            // 
            this.ColumnCode.Caption = "سریال";
            this.ColumnCode.FieldName = "Code";
            this.ColumnCode.Name = "ColumnCode";
            this.ColumnCode.Visible = true;
            this.ColumnCode.VisibleIndex = 0;
            // 
            // ColumnGroupId
            // 
            this.ColumnGroupId.Caption = "آیدی گروه";
            this.ColumnGroupId.FieldName = "GroupId";
            this.ColumnGroupId.Name = "ColumnGroupId";
            this.ColumnGroupId.Visible = true;
            this.ColumnGroupId.VisibleIndex = 1;
            // 
            // ColumnClass
            // 
            this.ColumnClass.Caption = "کلاس";
            this.ColumnClass.FieldName = "Class";
            this.ColumnClass.Name = "ColumnClass";
            this.ColumnClass.Visible = true;
            this.ColumnClass.VisibleIndex = 2;
            // 
            // ColumnQuestionText
            // 
            this.ColumnQuestionText.Caption = "متن سئوال";
            this.ColumnQuestionText.FieldName = "QuestionText";
            this.ColumnQuestionText.Name = "ColumnQuestionText";
            this.ColumnQuestionText.Visible = true;
            this.ColumnQuestionText.VisibleIndex = 3;
            // 
            // ColumnCase1
            // 
            this.ColumnCase1.Caption = "گزینه 1";
            this.ColumnCase1.FieldName = "Case1";
            this.ColumnCase1.Name = "ColumnCase1";
            this.ColumnCase1.Visible = true;
            this.ColumnCase1.VisibleIndex = 4;
            // 
            // ColumnCase2
            // 
            this.ColumnCase2.Caption = "گزینه 2";
            this.ColumnCase2.FieldName = "Case2";
            this.ColumnCase2.Name = "ColumnCase2";
            this.ColumnCase2.Visible = true;
            this.ColumnCase2.VisibleIndex = 5;
            // 
            // ColumnCase3
            // 
            this.ColumnCase3.Caption = "گزینه 3";
            this.ColumnCase3.FieldName = "Case3";
            this.ColumnCase3.Name = "ColumnCase3";
            this.ColumnCase3.Visible = true;
            this.ColumnCase3.VisibleIndex = 6;
            // 
            // ColumnCase4
            // 
            this.ColumnCase4.Caption = "گزینه 4";
            this.ColumnCase4.FieldName = "Case4";
            this.ColumnCase4.Name = "ColumnCase4";
            this.ColumnCase4.Visible = true;
            this.ColumnCase4.VisibleIndex = 7;
            // 
            // ColumnAnswer
            // 
            this.ColumnAnswer.Caption = "جواب صحیح";
            this.ColumnAnswer.FieldName = "Answer";
            this.ColumnAnswer.Name = "ColumnAnswer";
            this.ColumnAnswer.Visible = true;
            this.ColumnAnswer.VisibleIndex = 8;
            // 
            // FrmListQuestions
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 629);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmListQuestions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست سئوالات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControlQuestion;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnId;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCode;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnGroupId;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnClass;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnQuestionText;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCase1;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCase2;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCase3;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCase4;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnAnswer;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}