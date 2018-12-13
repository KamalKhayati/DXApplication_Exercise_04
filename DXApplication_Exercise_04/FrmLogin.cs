/****************************** Ghost.github.io ******************************\
*	Module Name:	FrmLogin.cs
*	Project:		DXApplication_Exercise_04
*	Copyright (C) 2018 Kamal Khayati, All rights reserved.
*	This software may be modified and distributed under the terms of the MIT license.  See LICENSE file for details.
*
*	Written by Kamal Khayati <Kamal1355@gmail.com>,  2018 / 12 / 6   12:57 ق.ظ
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
using nucs.JsonSettings;
using nucs.JsonSettings.Fluent;

namespace DXApplication_Exercise_04
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        SettingsBag settings { get; } = JsonSettings.Construct<SettingsBag>(AppVariable.fileName
           + @"\config.json").EnableAutosave().LoadNow();

        public FrmLogin()
        {
            InitializeComponent();
        }

        FolderBrowserDialog Folder = new FolderBrowserDialog();
        private void btnBrowser_Click(object sender, EventArgs e)
        {
            if (Folder.ShowDialog() == DialogResult.OK)
            {
                txtDBPath.Text = Folder.SelectedPath;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDBPath.Text != string.Empty)
            {
                settings[AppVariable.ConnectionPath] = Folder.SelectedPath;
            }
            else
            {
                settings[AppVariable.ConnectionPath] = null;
            }

            FrmMain fm = new FrmMain();
            fm.Show();
            this.Close();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}