/****************************** Ghost.github.io ******************************\
*	Module Name:	FrmListQuestions.cs
*	Project:		DXApplication_Exercise_04
*	Copyright (C) 2018 Kamal Khayati, All rights reserved.
*	This software may be modified and distributed under the terms of the MIT license.  See LICENSE file for details.
*
*	Written by Kamal Khayati <Kamal1355@gmail.com>,  2018 / 11 / 29   05:58 ب.ظ
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
    public partial class FrmListQuestions : DevExpress.XtraEditors.XtraForm
    {
        public FrmListQuestions()
        {
            InitializeComponent();
            FillGridView();
        }
        public void FillGridView()
        {
            using (var db = new MyContext())
            {
                var q = db.Questions.Any();
                if (q)
                {
                    gridControlQuestion.DataSource = db.Questions.ToList();
                }
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmQuestion f = new FrmQuestion(this);
            f.ShowDialog(this);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                FrmQuestion fm = new FrmQuestion(this);
                fm.btnAdd.Text = "ویرایش";
                fm.txtSerial.Text = gridView1.GetFocusedRowCellValue(gridView1.Columns[1]).ToString();
                fm.cmbGroupName.EditValue = gridView1.GetFocusedRowCellValue(gridView1.Columns[2]).ToString();
                fm.cmbClass.EditValue = gridView1.GetFocusedRowCellValue(gridView1.Columns[3]).ToString();
                fm.txtSoal.Text = gridView1.GetFocusedRowCellValue(gridView1.Columns[4]).ToString();
                fm.txtCase1.Text = gridView1.GetFocusedRowCellValue(gridView1.Columns[5]).ToString();
                fm.txtCase2.Text = gridView1.GetFocusedRowCellValue(gridView1.Columns[6]).ToString();
                fm.txtCase3.Text = gridView1.GetFocusedRowCellValue(gridView1.Columns[7]).ToString();
                fm.txtCase4.Text = gridView1.GetFocusedRowCellValue(gridView1.Columns[8]).ToString();
                fm.cmbAnswer.EditValue = gridView1.GetFocusedRowCellValue(gridView1.Columns[9]).ToString();
                fm.ShowDialog(this);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                var r = XtraMessageBox.Show("آیا ردیف جاری حذف گردد ؟", "پیغام حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    int _code = Convert.ToInt32(gridView1.GetFocusedRowCellValue(gridView1.Columns[1]));
                    try
                    {
                        using (var db = new MyContext())
                        {
                            var q = db.Questions.SingleOrDefault(p => p.Code == _code);
                            if (q != null)
                                db.Questions.Remove(q);

                            db.SaveChanges();
                            FillGridView();
                            XtraMessageBox.Show("عملیات باموفقیت انجام شد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

                        }
                    }
                    catch (Exception)
                    {
                        XtraMessageBox.Show("عملیات با خطا مواجه شد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
