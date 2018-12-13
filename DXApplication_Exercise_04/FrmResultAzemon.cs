/****************************** Ghost.github.io ******************************\
*	Module Name:	FrmResultAzemon.cs
*	Project:		DXApplication_Exercise_04
*	Copyright (C) 2018 Kamal Khayati, All rights reserved.
*	This software may be modified and distributed under the terms of the MIT license.  See LICENSE file for details.
*
*	Written by Kamal Khayati <Kamal1355@gmail.com>,  2018 / 12 / 3   01:20 ق.ظ
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
    public partial class FrmResultAzemon : DevExpress.XtraEditors.XtraForm
    {
        FrmAzmoon FrmAzmoon;
        public FrmResultAzemon(FrmAzmoon frmAzmoon)
        {
            InitializeComponent();
            FrmAzmoon = frmAzmoon;
        }
        public FrmResultAzemon()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}