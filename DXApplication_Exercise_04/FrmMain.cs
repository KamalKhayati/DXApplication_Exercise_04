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
using System.Data.Entity;

namespace DXApplication_Exercise_04
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //SettingsBag Settings { get; } = JsonSettings.Construct<SettingsBag>(AppVariable.fileName + @"\config.json").EnableAutosave().WithEncryption("asdjklasjdkajsd654654").LoadNow();
        SettingsBag Settings { get; } = JsonSettings.Construct<SettingsBag>(AppVariable.fileName + @"\config.json").EnableAutosave().LoadNow();

        public FrmMain()
        {
            InitializeComponent();

            #region کدهای مربوط به ارسال گزارشات ارور logify
            LogifyAlert client = LogifyAlert.Instance;
            client.ApiKey = "F7A2405F27594DBFBFB0864884C51E53";
            client.OfflineReportsEnabled = true;
            client.OfflineReportsCount = 20;
            client.OfflineReportsDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            client.SendOfflineReports();
            client.StartExceptionsHandling();
            #endregion کدهای مربوط به ارسال گزارشات ارور logify

            #region کدهای مربوط به ذخیره تم های فرم اصلی برنامه 

            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(skinRibbonGalleryBarItem1, true, true);
            skinRibbonGalleryBarItem2.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(skinRibbonGalleryBarItem2_GalleryItemClick);

            try
            {
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(Settings[AppVariable.SkinName].ToString() ?? "The Bezier");

            }
            catch (Exception)
            {

            }

            #endregion کدهای مربوط به ذخیره تم های فرم اصلی برنامه 

            using (var db=new MyContext())
            {
                db.Database.Initialize(true);
            }

        }


        private void skinRibbonGalleryBarItem2_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            Settings[AppVariable.SkinName] = DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName;

        }

        private void btnAddUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUser f = new FrmUser();
            f.btnAdd.Text = "جدید";
           f.ShowDialog();
        }

        private void btnAddGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new FrmGroup().ShowDialog();
        }

        private void btnAddSoal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new FrmQuestion().ShowDialog();
        }

        private void btnEditUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUser f = new FrmUser();
            f.btnAdd.Text = "ویرایش";
            f.btnDelete.Visible = true;
            f.ShowDialog();

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new FrmListQuestions().ShowDialog();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new FrmAzmoon().ShowDialog();
        }
    }
}
