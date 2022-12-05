﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RtfDomParser.Test
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Defaults.FontName = System.Windows.Forms.Control.DefaultFont.Name;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmRTFTest());
        }
    }
}