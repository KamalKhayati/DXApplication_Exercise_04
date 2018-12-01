namespace DXApplication_Exercise_04
{
    partial class FrmAzmoon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAzmoon));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnGenerat = new DevExpress.XtraEditors.SimpleButton();
            this.txtTime = new DevExpress.XtraEditors.TextEdit();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.txtSoal = new DevExpress.XtraEditors.TextEdit();
            this.lupUser = new DevExpress.XtraEditors.LookUpEdit();
            this.lupGroup = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb4 = new System.Windows.Forms.RadioButton();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.lblTextSoal = new DevExpress.XtraEditors.LabelControl();
            this.lblQNumber = new DevExpress.XtraEditors.LabelControl();
            this.lblTime = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrev = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnFinish = new DevExpress.XtraEditors.SimpleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.btnGenerat);
            this.groupControl1.Controls.Add(this.txtTime);
            this.groupControl1.Controls.Add(this.checkEdit2);
            this.groupControl1.Controls.Add(this.checkEdit1);
            this.groupControl1.Controls.Add(this.txtSoal);
            this.groupControl1.Controls.Add(this.lupUser);
            this.groupControl1.Controls.Add(this.lupGroup);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1161, 109);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "تنظیمات آزمون";
            // 
            // btnGenerat
            // 
            this.btnGenerat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerat.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerat.Appearance.Options.UseFont = true;
            this.btnGenerat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGenerat.ImageOptions.SvgImage")));
            this.btnGenerat.Location = new System.Drawing.Point(13, 31);
            this.btnGenerat.Name = "btnGenerat";
            this.btnGenerat.Size = new System.Drawing.Size(161, 56);
            this.btnGenerat.TabIndex = 7;
            this.btnGenerat.Text = "برگزاری آزمون";
            this.btnGenerat.Click += new System.EventHandler(this.btnGenerat_Click);
            // 
            // txtTime
            // 
            this.txtTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTime.EditValue = "25";
            this.txtTime.Enabled = false;
            this.txtTime.Location = new System.Drawing.Point(223, 66);
            this.txtTime.Margin = new System.Windows.Forms.Padding(5);
            this.txtTime.Name = "txtTime";
            this.txtTime.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtTime.Properties.Appearance.Options.UseFont = true;
            this.txtTime.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTime.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTime.Properties.Mask.BeepOnError = true;
            this.txtTime.Properties.Mask.EditMask = "f0";
            this.txtTime.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTime.Properties.MaxLength = 50;
            this.txtTime.Size = new System.Drawing.Size(80, 30);
            this.txtTime.TabIndex = 6;
            // 
            // checkEdit2
            // 
            this.checkEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEdit2.Location = new System.Drawing.Point(311, 67);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit2.Properties.Appearance.Options.UseFont = true;
            this.checkEdit2.Properties.Caption = "محدودیت زمانی داشته باشد ؟";
            this.checkEdit2.Size = new System.Drawing.Size(272, 27);
            this.checkEdit2.TabIndex = 5;
            this.checkEdit2.CheckedChanged += new System.EventHandler(this.checkEdit2_CheckedChanged);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEdit1.EditValue = true;
            this.checkEdit1.Location = new System.Drawing.Point(350, 26);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Caption = "سئولات تصادفی باشد ؟";
            this.checkEdit1.Size = new System.Drawing.Size(233, 27);
            this.checkEdit1.TabIndex = 5;
            // 
            // txtSoal
            // 
            this.txtSoal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoal.Location = new System.Drawing.Point(602, 45);
            this.txtSoal.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoal.Name = "txtSoal";
            this.txtSoal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSoal.Properties.Appearance.Options.UseFont = true;
            this.txtSoal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSoal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtSoal.Properties.Mask.BeepOnError = true;
            this.txtSoal.Properties.Mask.EditMask = "f0";
            this.txtSoal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSoal.Properties.MaxLength = 50;
            this.txtSoal.Properties.NullText = "تعداد سئوالات";
            this.txtSoal.Size = new System.Drawing.Size(125, 30);
            this.txtSoal.TabIndex = 4;
            // 
            // lupUser
            // 
            this.lupUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lupUser.Location = new System.Drawing.Point(953, 45);
            this.lupUser.Name = "lupUser";
            this.lupUser.Properties.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lupUser.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lupUser.Properties.Appearance.Options.UseFont = true;
            this.lupUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupUser.Properties.NullText = "انتخاب دانش آموز";
            this.lupUser.Size = new System.Drawing.Size(196, 30);
            this.lupUser.TabIndex = 0;
            // 
            // lupGroup
            // 
            this.lupGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lupGroup.Location = new System.Drawing.Point(735, 45);
            this.lupGroup.Name = "lupGroup";
            this.lupGroup.Properties.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lupGroup.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lupGroup.Properties.Appearance.Options.UseFont = true;
            this.lupGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupGroup.Properties.NullText = "انتخاب گروه";
            this.lupGroup.Size = new System.Drawing.Size(196, 30);
            this.lupGroup.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.groupBox1);
            this.groupControl2.Controls.Add(this.lblTextSoal);
            this.groupControl2.Controls.Add(this.lblQNumber);
            this.groupControl2.Controls.Add(this.lblTime);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Location = new System.Drawing.Point(0, 115);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1161, 397);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "آزمون";
            this.groupControl2.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb4);
            this.groupBox1.Controls.Add(this.rdb3);
            this.groupBox1.Controls.Add(this.rdb2);
            this.groupBox1.Controls.Add(this.rdb1);
            this.groupBox1.Location = new System.Drawing.Point(5, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1151, 244);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // rdb4
            // 
            this.rdb4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb4.AutoSize = true;
            this.rdb4.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdb4.Location = new System.Drawing.Point(994, 203);
            this.rdb4.Name = "rdb4";
            this.rdb4.Size = new System.Drawing.Size(137, 33);
            this.rdb4.TabIndex = 1;
            this.rdb4.TabStop = true;
            this.rdb4.Text = "radioButton1";
            this.rdb4.UseVisualStyleBackColor = true;
            // 
            // rdb3
            // 
            this.rdb3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb3.AutoSize = true;
            this.rdb3.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdb3.Location = new System.Drawing.Point(994, 144);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(137, 33);
            this.rdb3.TabIndex = 2;
            this.rdb3.TabStop = true;
            this.rdb3.Text = "radioButton1";
            this.rdb3.UseVisualStyleBackColor = true;
            // 
            // rdb2
            // 
            this.rdb2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb2.AutoSize = true;
            this.rdb2.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdb2.Location = new System.Drawing.Point(994, 80);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(137, 33);
            this.rdb2.TabIndex = 3;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "radioButton1";
            this.rdb2.UseVisualStyleBackColor = true;
            // 
            // rdb1
            // 
            this.rdb1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb1.AutoSize = true;
            this.rdb1.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdb1.Location = new System.Drawing.Point(994, 17);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(137, 33);
            this.rdb1.TabIndex = 4;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "radioButton1";
            this.rdb1.UseVisualStyleBackColor = true;
            // 
            // lblTextSoal
            // 
            this.lblTextSoal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextSoal.Appearance.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTextSoal.Appearance.Options.UseFont = true;
            this.lblTextSoal.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTextSoal.Location = new System.Drawing.Point(13, 96);
            this.lblTextSoal.Name = "lblTextSoal";
            this.lblTextSoal.Size = new System.Drawing.Size(1072, 29);
            this.lblTextSoal.TabIndex = 0;
            this.lblTextSoal.Text = "متن سئوال ";
            // 
            // lblQNumber
            // 
            this.lblQNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQNumber.Appearance.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblQNumber.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblQNumber.Appearance.Options.UseFont = true;
            this.lblQNumber.Appearance.Options.UseForeColor = true;
            this.lblQNumber.Location = new System.Drawing.Point(1115, 96);
            this.lblQNumber.Name = "lblQNumber";
            this.lblQNumber.Size = new System.Drawing.Size(11, 29);
            this.lblQNumber.TabIndex = 0;
            this.lblQNumber.Text = "0";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.Appearance.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTime.Appearance.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblTime.Appearance.Options.UseFont = true;
            this.lblTime.Appearance.Options.UseForeColor = true;
            this.lblTime.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTime.Location = new System.Drawing.Point(881, 43);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(204, 29);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "0";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(1104, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 29);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "زمان";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnClose);
            this.groupControl3.Controls.Add(this.btnPrev);
            this.groupControl3.Controls.Add(this.btnNext);
            this.groupControl3.Controls.Add(this.btnFinish);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(0, 513);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1161, 125);
            this.groupControl3.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.Location = new System.Drawing.Point(13, 43);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(161, 50);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "بستن فرم";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Appearance.Options.UseFont = true;
            this.btnPrev.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrev.ImageOptions.SvgImage")));
            this.btnPrev.Location = new System.Drawing.Point(797, 43);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(161, 50);
            this.btnPrev.TabIndex = 14;
            this.btnPrev.Text = "سئوال قبلی";
            this.btnPrev.Visible = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Appearance.Options.UseFont = true;
            this.btnNext.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNext.ImageOptions.SvgImage")));
            this.btnNext.Location = new System.Drawing.Point(966, 43);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(161, 50);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "سئوال بعدی";
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinish.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Appearance.Options.UseFont = true;
            this.btnFinish.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnFinish.ImageOptions.SvgImage")));
            this.btnFinish.Location = new System.Drawing.Point(600, 43);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(161, 50);
            this.btnFinish.TabIndex = 16;
            this.btnFinish.Text = "پایان آزمون";
            this.btnFinish.Visible = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmAzmoon
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 638);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmAzmoon";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAzmoon";
            this.Load += new System.EventHandler(this.FrmAzmoon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        public DevExpress.XtraEditors.LookUpEdit lupGroup;
        public DevExpress.XtraEditors.LookUpEdit lupUser;
        public DevExpress.XtraEditors.TextEdit txtTime;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        public DevExpress.XtraEditors.TextEdit txtSoal;
        private DevExpress.XtraEditors.SimpleButton btnGenerat;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl lblTextSoal;
        private DevExpress.XtraEditors.LabelControl lblQNumber;
        private DevExpress.XtraEditors.LabelControl lblTime;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb4;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnPrev;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnFinish;
        private System.Windows.Forms.Timer timer1;
    }
}