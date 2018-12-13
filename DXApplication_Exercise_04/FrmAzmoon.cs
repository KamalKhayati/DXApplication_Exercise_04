/****************************** Ghost.github.io ******************************\
*	Module Name:	FrmAzmoon.cs
*	Project:		DXApplication_Exercise_04
*	Copyright (C) 2018 Kamal Khayati, All rights reserved.
*	This software may be modified and distributed under the terms of the MIT license.  See LICENSE file for details.
*
*	Written by Kamal Khayati <Kamal1355@gmail.com>,  2018 / 11 / 30   11:59 ب.ظ
*	
***********************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Globalization;

namespace DXApplication_Exercise_04
{
    public partial class FrmAzmoon : DevExpress.XtraEditors.XtraForm
    {
        public FrmAzmoon()
        {
            InitializeComponent();
        }

        private void FrmAzmoon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_EFCF_DXApplication_Exercise_04DataSet2.Users' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dB_EFCF_DXApplication_Exercise_04DataSet1.Users' table. You can move, or remove it, as needed.
            FillUserAndGroup();
        }
        public void FillUserAndGroup()
        {
            using (var db = new MyContext())
            {
                var qUser = db.Users.Select(p => new { p.Id, p.FName, p.LName });
                var qGroup = db.Groups.Select(x => x);
                //if (q.Any())
                //{
                //    foreach (var item in q)
                //    {
                //        cmbUser.Properties.Items.Add(item.FName + " " + item.LName);
                //        cmbUser.Properties.Items.Add(item.FName);
                //    }

                //    for (int i = 0; i < q.Count; i++)
                //    {
                //        cmbUser.Properties.Items.Insert(i, q[i].FName + " " + q[i].LName);
                //    }
                //}
                lupUser.Properties.DataSource = qUser.Any() ? qUser.ToList() : null;
                lupUser.Properties.DisplayMember = "FName";
                lupUser.Properties.ValueMember = "Id";
                lupUser.ItemIndex = 0;

                lupGroup.Properties.DataSource = qGroup.Any() ? qGroup.ToList() : null;
                lupGroup.Properties.DisplayMember = "GroupName";
                lupGroup.Properties.ValueMember = "Id";
                lupGroup.ItemIndex = 0;

            }

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            groupControl1.Enabled = true;

        }
        int QN = 0;
        int _UserId = 0;
        int _GroupId = 0;
        Users q1 = null;
        Group q2 = null;
        List<Question> q3 = null;
        ListBox answerList = null;
        int isgozine = 0;
        private void btnGenerat_Click(object sender, EventArgs e)
        {
            answerList = new ListBox();

            if (String.IsNullOrWhiteSpace(lupUser.Text) || lupUser.Text == "انتخاب دانش آموز")
            {
                XtraMessageBox.Show("لطفاً نام دانش آموز را انتخاب کنید");
            }
            else if (String.IsNullOrWhiteSpace(lupGroup.Text) || lupGroup.Text == "انتخاب گروه")
            {
                XtraMessageBox.Show("لطفاً نام گروه را انتخاب کنید");
            }
            else if (String.IsNullOrWhiteSpace(txtSoal.Text) || txtSoal.Text == "0" || txtSoal.Text == "تعداد سئوالات")
            {
                XtraMessageBox.Show("لطفاً تعداد سئوالات را وارد کنید");
            }
            else if (checkEdit1.Checked)
            {
                try
                {
                    using (var db = new MyContext())
                    {
                        _UserId = Convert.ToInt32(lupUser.EditValue);
                        q1 = db.Users.Where(p => p.Id == _UserId).SingleOrDefault();
                        _GroupId = Convert.ToInt32(lupGroup.EditValue);
                        q2 = db.Groups.Where(p => p.Id == _GroupId).SingleOrDefault();

                        if (checkEdit2.Checked)
                        {
                            q3 = db.Questions.Where(p => p.Class == q1.Class && p.GroupId == q2.Id)
                               .OrderBy(x => Guid.NewGuid()).Take(Convert.ToInt32(txtSoal.Text)).ToList();
                            if (q3 != null)
                                lblTime.Text = (Convert.ToInt32(txtTime.Text) * q3.Count()).ToString();
                            timer1.Enabled = true;

                        }
                        else
                        {
                            q3 = db.Questions.Where(p => p.Class == q1.Class && p.GroupId == q2.Id)
                               .OrderBy(x => Guid.NewGuid()).Take(Convert.ToInt32(txtSoal.Text)).ToList();
                            lblTime.Text = "نامحدود";
                        }

                        if (q3 != null)
                        {
                            for (int i = 0; i < q3.Count; i++)
                            {
                                answerList.Items.Add("0");
                            }

                            lblQNumber.Text = (QN + 1).ToString();
                            lblTextSoal.Text = q3[QN].QuestionText;
                            rdb1.Text = q3[QN].Case1;
                            rdb2.Text = q3[QN].Case2;
                            rdb3.Text = q3[QN].Case3;
                            rdb4.Text = q3[QN].Case4;
                            groupControl1.Enabled = false;
                            btnNext.Visible = true;
                            btnFinish.Visible = true;
                            groupControl2.Enabled = true;

                        }
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("عملیات با خطا مواجه شد" + "\n" + ex.Message,
                        "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (!checkEdit1.Checked)
            {
                try
                {
                    using (var db = new MyContext())
                    {
                        _UserId = Convert.ToInt32(lupUser.EditValue);
                        q1 = db.Users.Where(p => p.Id == _UserId).SingleOrDefault();
                        _GroupId = Convert.ToInt32(lupGroup.EditValue);
                        q2 = db.Groups.Where(p => p.Id == _GroupId).SingleOrDefault();
                        if (checkEdit2.Checked)
                        {
                            q3 = db.Questions.Where(p => p.Class == q1.Class && p.GroupId == q2.Id)
                               .Take(Convert.ToInt32(txtSoal.Text)).ToList();
                            if (q3 != null)
                                lblTime.Text = (Convert.ToInt32(txtTime.Text) * q3.Count()).ToString();
                            timer1.Enabled = true;
                        }
                        else
                        {
                            q3 = db.Questions.Where(p => p.Class == q1.Class && p.GroupId == q2.Id)
                               .Take(Convert.ToInt32(txtSoal.Text)).ToList();
                            lblTime.Text = "نامحدود ";
                        }
                        if (q3 != null)
                        {
                            lblQNumber.Text = (QN + 1).ToString();
                            lblTextSoal.Text = q3[QN].QuestionText;
                            rdb1.Text = q3[QN].Case1;
                            rdb2.Text = q3[QN].Case2;
                            rdb3.Text = q3[QN].Case3;
                            rdb4.Text = q3[QN].Case4;
                            groupControl1.Enabled = false;
                            btnNext.Visible = true;
                            btnFinish.Visible = true;
                            groupControl2.Enabled = true;

                        }
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("عملیات با خطا مواجه شد" + "\n" + ex.Message,
                        "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            txtTime.Enabled = checkEdit2.Checked ? true : false;
        }

        public void ClearCheck()
        {
            rdb1.Checked = false;
            rdb2.Checked = false;
            rdb3.Checked = false;
            rdb4.Checked = false;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rdb1.Checked)
                isgozine = 1;
            else if (rdb2.Checked)
                isgozine = 2;
            else if (rdb3.Checked)
                isgozine = 3;
            else if (rdb4.Checked)
                isgozine = 4;
            else
                isgozine = 0;

            answerList.Items[QN] = isgozine.ToString();


            btnPrev.Visible = true;
            btnPrev.Enabled = true;
            if (QN < q3.Count - 1)
                QN++;
            if (QN == q3.Count - 1)
            {
                btnNext.Enabled = false;

            }


            lblQNumber.Text = (QN + 1).ToString();
            lblTextSoal.Text = q3[QN].QuestionText;
            rdb1.Text = q3[QN].Case1;
            rdb2.Text = q3[QN].Case2;
            rdb3.Text = q3[QN].Case3;
            rdb4.Text = q3[QN].Case4;

            if (Convert.ToInt32(answerList.Items[QN].ToString()) == 0)
                ClearCheck();
            else if (Convert.ToInt32(answerList.Items[QN].ToString()) == 1)
                rdb1.Checked = true;
            else if (Convert.ToInt32(answerList.Items[QN].ToString()) == 2)
                rdb2.Checked = true;
            else if (Convert.ToInt32(answerList.Items[QN].ToString()) == 3)
                rdb3.Checked = true;
            else if (Convert.ToInt32(answerList.Items[QN].ToString()) == 4)
                rdb4.Checked = true;
            if (answerList.Items[QN] == null)
            {
                ClearCheck();

            }
        }


        private void btnPrev_Click(object sender, EventArgs e)
        {
            //------------------------------------
            if (rdb1.Checked)
                isgozine = 1;
            else if (rdb2.Checked)
                isgozine = 2;
            else if (rdb3.Checked)
                isgozine = 3;
            else if (rdb4.Checked)
                isgozine = 4;
            else
                isgozine = 0;

            answerList.Items[QN] = isgozine.ToString();

            btnNext.Enabled = true;
            if (QN > 0)
                QN--;
            if (QN == 0)
                btnPrev.Enabled = false;

            lblQNumber.Text = (QN + 1).ToString();
            lblTextSoal.Text = q3[QN].QuestionText;
            rdb1.Text = q3[QN].Case1;
            rdb2.Text = q3[QN].Case2;
            rdb3.Text = q3[QN].Case3;
            rdb4.Text = q3[QN].Case4;


            if (Convert.ToInt32(answerList.Items[QN].ToString()) == 0)
                ClearCheck();
            else if (Convert.ToInt32(answerList.Items[QN].ToString()) == 1)
                rdb1.Checked = true;
            else if (Convert.ToInt32(answerList.Items[QN].ToString()) == 2)
                rdb2.Checked = true;
            else if (Convert.ToInt32(answerList.Items[QN].ToString()) == 3)
                rdb3.Checked = true;
            else if (Convert.ToInt32(answerList.Items[QN].ToString()) == 4)
                rdb4.Checked = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblTime.Text) > 0)
            {
                lblTime.Text = (Convert.ToInt32(lblTime.Text) - 1).ToString();
            }
            else
            {
                btnFinish_Click(null, null);
            }
        }
        PersianCalendar pc = new PersianCalendar();
        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (lblTime.Text == "نامحدود")
            {
                timer1.Stop();
                var r = XtraMessageBox.Show("آیا از ادامه آزمون منصرف شدید", "پیغام توقف آزمون", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.No)
                    timer1.Start();
            }
            else
            {
                timer1.Stop();
                timer1.Enabled = false;
                XtraMessageBox.Show("زمان آزمون به پایان رسید");
            }

            btnFinish.Visible = btnNext.Visible = btnPrev.Visible = false;
            groupControl1.Enabled = true;
            groupControl2.Enabled = false;
            btnNext.Enabled = true;


            if (rdb1.Checked)
                isgozine = 1;
            else if (rdb2.Checked)
                isgozine = 2;
            else if (rdb3.Checked)
                isgozine = 3;
            else if (rdb4.Checked)
                isgozine = 4;
            else
                isgozine = 0;

            answerList.Items[QN] = isgozine.ToString();

            int sahih = 0;
            int galat = 0;
            int none = 0;

            for (int i = 0; i < Convert.ToInt32(answerList.Items.Count); i++)
            {
                if (answerList.Items[i].ToString() == q3[i].Answer.ToString())
                {
                    sahih += 1;
                }
                else if (Convert.ToInt32(answerList.Items[i].ToString()) == 0)
                {
                    none += 1;
                }
                else
                {
                    galat += 1;
                }
            }

            var date = pc.GetYear(DateTime.Now).ToString("0000") + "/" + pc.GetMonth(DateTime.Now).ToString("00") + "/" + pc.GetDayOfMonth(DateTime.Now).ToString("00");
            FrmResultAzemon fm = new FrmResultAzemon(this);
            fm.labelControl1.Text = string.Format(fm.labelControl1.Text, date);
            fm.labelControl2.Text = string.Format(fm.labelControl2.Text, q2.GroupName);
            fm.labelControl3.Text = string.Format(fm.labelControl3.Text, q1.FName + " " + q1.LName);
            fm.labelControl4.Text = string.Format(fm.labelControl4.Text, sahih);
            fm.labelControl5.Text = string.Format(fm.labelControl5.Text, galat);
            fm.labelControl6.Text = string.Format(fm.labelControl6.Text, none);
            fm.ShowDialog(this);

            using (var db = new MyContext())
            {
                try
                {
                    var ad = new Histor()
                    {
                        UserId = _UserId,
                        DatePass = date,
                        GroupName = q2.GroupName,
                        TrueItem=sahih,
                        FalseItem=galat,
                        NoneItem=none
                    };
                    db.Histores.Add(ad);
                    db.SaveChanges();
                    //XtraMessageBox.Show("عملیات باموفقیت انجام شد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("عملیات با خطا مواجه شد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            QN = 0;
            isgozine = 0;
            q1 = null;
            q2 = null;
            q3 = null;
            lblQNumber.Text = "0";
            lblTextSoal.Text = "0";
            lblTime.Text = "0";
            ClearCheck();
            answerList = null;
            _GroupId = _UserId = 0;
        }
    }
}
