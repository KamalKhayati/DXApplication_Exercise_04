/****************************** Ghost.github.io ******************************\
*	Module Name:	AppVariable.cs
*	Project:		DXApplication_Exercise_04
*	Copyright (C) 2018 Kamal Khayati, All rights reserved.
*	This software may be modified and distributed under the terms of the MIT license.  See LICENSE file for details.
*
*	Written by Kamal Khayati <Kamal1355@gmail.com>,  2018 / 11 / 27   02:24 ب.ظ
*	
***********************************************************************************/
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace DXApplication_Exercise_04
{
    class AppVariable
    {
        // مسیر دایکتوری ذخیره فایل کانفیگ 
        public static string fileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
            + @"\" + Assembly.GetExecutingAssembly().GetName().Name;

        #region Setting Keys

        public static string SkinName = "Skin";
        public static string ConnectionPath = "dbConnection";

        #endregion Setting Keys

        #region توابع ذخیره و خواندن تنظیمات در فایل کانفیگ خود برنامه

        public static string ReadSettings(string Key)
        {
            string result = string.Empty;
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                result = appSettings[Key] ?? "0";
            }
            catch (ConfigurationErrorsException)
            {
                result = "Error reading app settings";
            }
            return result;
        }

        public static void AddorUpdateSettings(string Key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[Key] == null)
                    settings.Add(Key, value);
                else
                    settings[Key].Value = value;
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (Exception)
            {
            }
        }

        #endregion توابع ذخیره و خواندن تنظیمات در فایل کانفیگ خود برنامه

    }
}
