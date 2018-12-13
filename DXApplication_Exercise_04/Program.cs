/****************************** Ghost.github.io ******************************\
*	Module Name:	Program.cs
*	Project:		DXApplication_Exercise_04
*	Copyright (C) 2018 Kamal Khayati, All rights reserved.
*	This software may be modified and distributed under the terms of the MIT license.  See LICENSE file for details.
*
*	Written by Kamal Khayati <Kamal1355@gmail.com>,  2018 / 11 / 27   01:10 ق.ظ
*	
***********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Threading;
using nucs.JsonSettings;
using nucs.JsonSettings.Fluent;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;

namespace DXApplication_Exercise_04
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool instance = false;
            Mutex mtx = new Mutex(true, Application.ProductName, out instance);

            if (instance)
            {

                //فعال کردن زبان فارسی در برنامه 
                //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fa");
                //Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture;
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fa");

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                BonusSkins.Register();

                // ساخت پوشه مسیر دایرکتوری فایل کانفیگ
                SkinManager.EnableFormSkins();
                if (!System.IO.Directory.Exists(AppVariable.fileName))
                    System.IO.Directory.CreateDirectory(AppVariable.fileName);
                    //Application.Run(new FrmMain());
                Application.Run(new AppContext());

                mtx.ReleaseMutex();
            }
            else
            {
                XtraMessageBox.Show("برنامه در حال اجرا است");
            }

        }

        public class AppContext : ApplicationContext
        {
            public AppContext()
            {
                Application.Idle += new EventHandler(Application_Idle);
                new FrmLogin().Show();
            }

            private void Application_Idle(object sender, EventArgs e)
            {
                if (Application.OpenForms.Count == 0)
                {
                    Application.Exit();
                }
            }
        }

    }
}
