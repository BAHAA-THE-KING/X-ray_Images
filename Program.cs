﻿using System;
using System.Windows.Forms;
using X_ray_Images.Classes;

namespace X_ray_Images
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());            
        }
    }
}
