﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using AppSettings = WDM.Properties.Settings;
namespace WDM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            Current.DispatcherUnhandledException += Current_DispatcherUnhandledException;
            CheckUpgrade();
            CheckReportingTemplatesSettings();
            if (!e.Args.Any())
            {
               // ConnectionString.ServerName = ".";
            }
            else
            {
               // ConnectionString.ServerName = e.Args[0];
            }
            AppSettings.Default.Save();

            //Logger.LogFilePath = AppSettings.Default.LogFilePath;
            //GlobalConst.CurrentYear = AppSettings.Default.CurrentYear;
            //base.OnStartup(e);
            Bootstrapper bootstrapper = new Bootstrapper();
            bootstrapper.Run();
        }
        private void CheckUpgrade()
        {
            if (AppSettings.Default.UpgradedVersion)
            {
                AppSettings.Default.Upgrade();
                AppSettings.Default.UpgradedVersion = false;
                AppSettings.Default.Save();
            }
        }
        private void CheckReportingTemplatesSettings()
        {
            string templatesDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Templates";
            string paymentTransTemplate = templatesDirectory + "\\PaymReport.xltx";
            if (File.Exists(paymentTransTemplate))
            {
                //AppSettings.Default.PaymReportPath = paymentTransTemplate;
                //AppSettings.Default.Save();
            }

        }
        private void Current_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            //string msg = Helper.ProcessExceptionMessages(e.Exception);
            //Logger.Log(LogMessageTypes.Error,
            //    msg,
            //    e.Exception.TargetSite.ToString(),
            //    e.Exception.StackTrace);
        }
    }
}
