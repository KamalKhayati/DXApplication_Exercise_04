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
                var qUser = db.Users.Select(p=> new { p.Id, p.FName , p.LName }).ToList();
                var qGroup = db.Groups.ToList();
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
                lueUser.Properties.DataSource = qUser;
                lueUser.Properties.DisplayMember = "FName";
                lueUser.Properties.ValueMember = "Id";

                lueGroup.Properties.DataSource = qGroup;
                lueGroup.Properties.DisplayMember = "GroupName";
                lueGroup.Properties.ValueMember = "Id";

            }

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}