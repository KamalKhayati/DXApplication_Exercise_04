/****************************** Ghost.github.io ******************************\
*	Module Name:	FrmQuestion.cs
*	Project:		DXApplication_Exercise_04
*	Copyright (C) 2018 Kamal Khayati, All rights reserved.
*	This software may be modified and distributed under the terms of the MIT license.  See LICENSE file for details.
*
*	Written by Kamal Khayati <Kamal1355@gmail.com>,  2018 / 11 / 28   08:51 ب.ظ
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

namespace DXApplication_Exercise_04
{
    public partial class FrmQuestion : DevExpress.XtraEditors.XtraForm
    {
        FrmListQuestions FmQ;
        public FrmQuestion()
        {
            InitializeComponent();
        }
        public FrmQuestion(FrmListQuestions fmQ)
        {
            InitializeComponent();
            FmQ = fmQ;
        }

        private void FrmQuestion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_EFCF_DXApplication_Exercise_04DataSet.Groups' table. You can move, or remove it, as needed.
            this.groupsTableAdapter.Fill(this.dB_EFCF_DXApplication_Exercise_04DataSet.Groups);
            //-------------------
            if (btnAdd.Text == "ثبت")
            {
                using (var db = new MyContext())
                {
                    var q = db.Questions.Max(p => p.Code);
                    if (q == 0)
                    {
                        txtSerial.Text = "1";
                    }
                    else
                    {
                        txtSerial.Text = (Convert.ToUInt32(q.ToString()) + 1).ToString();
                    }
                }

            }

        }
        int _Answer = 0;
        int index = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "ثبت")
            {
                if (cmbGroupName.Text == string.Empty || cmbClass.Text == string.Empty
                    || cmbAnswer.Text == string.Empty || txtSoal.Text == string.Empty
                    || txtCase1.Text == string.Empty || txtCase2.Text == string.Empty
                    || txtCase3.Text == string.Empty || txtCase4.Text == string.Empty)
                {
                    XtraMessageBox.Show("اطلاعات را بصورت کامل وارد کنید", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

                }
                else
                {
                    try
                    {
                         index = FmQ.gridView1.RowCount;

                        switch (cmbAnswer.SelectedIndex)
                        {
                            case 0:
                                _Answer = 1;
                                break;
                            case 1:
                                _Answer = 2;
                                break;
                            case 2:
                                _Answer = 3;
                                break;
                            case 3:
                                _Answer = 4;
                                break;
                        }
                        using (var db = new MyContext())
                        {
                            var ad = new Question()
                            {
                                Code = Convert.ToInt32(txtSerial.Text),
                                GroupId = Convert.ToInt32(cmbGroupName.EditValue),
                                Class = cmbClass.Text,
                                QuestionText = txtSoal.Text,
                                Case1 = txtCase1.Text,
                                Case2 = txtCase2.Text,
                                Case3 = txtCase3.Text,
                                Case4 = txtCase4.Text,
                                Answer = _Answer
                            };
                            db.Questions.Add(ad);
                            db.SaveChanges();

                            //FmQ.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                            //FmQ.gridView1.OptionsNavigation.AutoFocusNewRow = true;


                            //FmQ.gridView1.SetFocusedRowCellValue(FmQ.gridView1.Columns[1], Convert.ToInt32(txtSerial.Text));
                            //FmQ.gridView1.SetFocusedRowCellValue(FmQ.gridView1.Columns[2], Convert.ToInt32(cmbGroupName.EditValue));
                            //FmQ.gridView1.SetFocusedRowCellValue(FmQ.gridView1.Columns[3], cmbClass.Text);
                            //FmQ.gridView1.SetFocusedRowCellValue(FmQ.gridView1.Columns[4], txtSoal.Text);
                            //FmQ.gridView1.SetFocusedRowCellValue(FmQ.gridView1.Columns[5], txtCase1.Text);
                            //FmQ.gridView1.SetFocusedRowCellValue(FmQ.gridView1.Columns[6], txtCase2.Text);
                            //FmQ.gridView1.SetFocusedRowCellValue(FmQ.gridView1.Columns[7], txtCase3.Text);
                            //FmQ.gridView1.SetFocusedRowCellValue(FmQ.gridView1.Columns[8], txtCase4.Text);
                            //FmQ.gridView1.SetFocusedRowCellValue(FmQ.gridView1.Columns[9], _Answer);
                            //FmQ.gridView1.AddNewRow();
                            FmQ.FillGridView();
                            FmQ.gridView1.FocusedRowHandle = index;

                            XtraMessageBox.Show("عملیات باموفقیت انجام شد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

                        }
                    }
                    catch (Exception)
                    {
                        XtraMessageBox.Show("عملیات با خطا مواجه شد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    this.Close();
                }
            }
            else
            {
                try
                {
                    index = FmQ.gridView1.GetFocusedDataSourceRowIndex();
                    using (var db = new MyContext())
                    {
                        int _code = Convert.ToInt32(txtSerial.Text);
                        var q = db.Questions.SingleOrDefault(s => s.Code ==_code);
                        if (q != null)
                        {
                            
                            q.GroupId = Convert.ToInt32(cmbGroupName.EditValue);
                            q.Class = cmbClass.EditValue.ToString();
                            q.QuestionText = txtSoal.Text;
                            q.Case1 = txtCase1.Text;
                            q.Case2 = txtCase2.Text;
                            q.Case3 = txtCase3.Text;
                            q.Case4 = txtCase4.Text;
                            q.Answer = Convert.ToInt32(cmbAnswer.EditValue.ToString());
                            //db.Users.Attach(q);
                            //db.Entry(q).State = EntityState.Modified;
                            db.SaveChanges();
                            FmQ.FillGridView();
                            FmQ.gridView1.FocusedRowHandle = index;
                            XtraMessageBox.Show("عملیات باموفقیت انجام شد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    XtraMessageBox.Show("عملیات با خطا مواجه شد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();

            }

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}