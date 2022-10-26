#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace DatEditor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
       [STAThread]
        static void Main(string[] args)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHNqVVhkW1pFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF9iSXxQdkFmWnteeHVVTg==;Mgo+DSMBPh8sVXJ0S0V+XE9AcVRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS3xSdkdgWXtbc3BVTmJdWQ==;ORg4AjUWIQA/Gnt2VVhjQlFaclhJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxRd0VhWn9adXdRRmhfVUw=;NzQ1Nzk2QDMyMzAyZTMzMmUzMEpiYU9hNlZTajZWRHNUeWM1R2NKU1FwaDRielNncTA3bWRudW00NHhZM1U9;NzQ1Nzk3QDMyMzAyZTMzMmUzMEE0YS9sL0lyY1VjWjNVMWxJWW1vK0c3VytyQklrMG8vaUoxelBHQTJxU2c9;NRAiBiAaIQQuGjN/V0Z+X09EaFtFVmJLYVB3WmpQdldgdVRMZVVbQX9PIiBoS35RdERjW3xedHFWQmBUWEx+;NzQ1Nzk5QDMyMzAyZTMzMmUzMEIxb05BYjFhRHVUWTNpSUF2ODdrZnFJUkRzalI2cUs1Wnk2NUlmL1lqMFE9;NzQ1ODAwQDMyMzAyZTMzMmUzMFJsOGJaTVJDVWNvVy9GNGJZdFZVN2MxWjJ4NXZaMkNFZHJVL2RPVDdtN1U9;Mgo+DSMBMAY9C3t2VVhjQlFaclhJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxRd0VhWn9adXdRRmlbWEw=;NzQ1ODAyQDMyMzAyZTMzMmUzMEUwUjZrenZnREpBdXJFblE1Wk40dXJCOThKbDhQdlgweUtUSVVTU1ovVkk9;NzQ1ODAzQDMyMzAyZTMzMmUzMGJGcFdlemcrUjhMMGs4Y0Zsd0ZuQS95bGU5emxRU01BRUR1MFIydXZYMHM9;NzQ1ODA0QDMyMzAyZTMzMmUzMEIxb05BYjFhRHVUWTNpSUF2ODdrZnFJUkRzalI2cUs1Wnk2NUlmL1lqMFE9");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            if (args.Length != 0)
            {
                
                try
                {
                    new Editor(args[0]);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    Application.Run(new MainForm());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
