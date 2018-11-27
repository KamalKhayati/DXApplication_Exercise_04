/****************************** Ghost.github.io ******************************\
*	Module Name:	FrmMain.cs
*	Project:		DXApplication_Exercise_04
*	Copyright (C) 2018 Kamal Khayati, All rights reserved.
*	This software may be modified and distributed under the terms of the MIT license.  See LICENSE file for details.
*
*	Written by Kamal Khayati <Kamal1355@gmail.com>,  2018 / 11 / 27   01:10 ق.ظ
*	
***********************************************************************************/
using DevExpress.Logify.Win;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using nucs.JsonSettings;
using nucs.JsonSettings.Fluent;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using System.Reflection;
using System.Xml.Linq;

namespace DXApplication_Exercise_04
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        SettingsBag settings { get; } = JsonSettings.Construct<SettingsBag>(AppVariable.fileName + @"\config.json").EnableAutosave().WithEncryption("asdjklasjdkajsd654654").LoadNow();

        public FrmMain()
        {
            InitializeComponent();
            LogifyAlert client = LogifyAlert.Instance;
            client.ApiKey = "F7A2405F27594DBFBFB0864884C51E53";
            client.OfflineReportsEnabled = true;
            client.OfflineReportsCount = 20;
            client.OfflineReportsDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            client.SendOfflineReports();
            client.StartExceptionsHandling();

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

    }
}
