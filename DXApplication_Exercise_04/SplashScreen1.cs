/****************************** Ghost.github.io ******************************\
*	Module Name:	SplashScreen1.cs
*	Project:		DXApplication_Exercise_04
*	Copyright (C) 2018 Kamal Khayati, All rights reserved.
*	This software may be modified and distributed under the terms of the MIT license.  See LICENSE file for details.
*
*	Written by Kamal Khayati <Kamal1355@gmail.com>,  2018 / 11 / 27   10:53 ب.ظ
*	
***********************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraSplashScreen;
using nucs.JsonSettings;
using nucs.JsonSettings.Fluent;

namespace DXApplication_Exercise_04
{
    public partial class SplashScreen1 : SplashScreen
    {
        //SettingsBag Settings { get; } = JsonSettings.Construct<SettingsBag>(AppVariable.fileName + @"\config.json").EnableAutosave().WithEncryption("asdjklasjdkajsd654654").LoadNow();
        SettingsBag Settings { get; } = JsonSettings.Construct<SettingsBag>(AppVariable.fileName + @"\config.json").EnableAutosave().LoadNow();
        public SplashScreen1()
        {
            InitializeComponent();
            this.labelControl1.Text = "Copyright Kamal Khayati © 1998-" + DateTime.Now.Year.ToString();

            //تنظیم تم اسپلش با تم فرم اصلی برنامه که متاسفانه کار نمیده
            try
            {
                UserLookAndFeel.Default.SetSkinStyle(Settings[AppVariable.SkinName].ToString() ?? "The Bezier");
            }
            catch (Exception)
            {

            }


        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}