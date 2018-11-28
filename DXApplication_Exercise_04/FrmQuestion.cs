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
        public FrmQuestion()
        {
            InitializeComponent();
        }

        private void FrmQuestion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_EFCF_DXApplication_Exercise_04DataSet.Groups' table. You can move, or remove it, as needed.
            this.groupsTableAdapter.Fill(this.dB_EFCF_DXApplication_Exercise_04DataSet.Groups);

        }
        int _Answer = 0;
        private void btnAdd_Click(object sender, EventArgs e)
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