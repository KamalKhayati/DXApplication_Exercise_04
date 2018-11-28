/****************************** Ghost.github.io ******************************\
*	Module Name:	FrmGroup.cs
*	Project:		DXApplication_Exercise_04
*	Copyright (C) 2018 Kamal Khayati, All rights reserved.
*	This software may be modified and distributed under the terms of the MIT license.  See LICENSE file for details.
*
*	Written by Kamal Khayati <Kamal1355@gmail.com>,  2018 / 11 / 28   08:42 ب.ظ
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
    public partial class FrmGroup : DevExpress.XtraEditors.XtraForm
    {
        public FrmGroup()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtGroupName.Text==string.Empty)
            {
                XtraMessageBox.Show("اطلاعات را بصورت کامل وارد کنید", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

            }
            else
            {
                try
                {
                    using (var db = new MyContext())
                    {
                        var ad = new Group()
                        {
                            GroupName = txtGroupName.Text
                        };
                        db.Groups.Add(ad);
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