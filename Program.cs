using System.Diagnostics;

namespace X_ray_Images
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //string startupPath = Application.StartupPath;
            //string currentDirectory = Environment.CurrentDirectory;

            //Debug.WriteLine("Start: " + startupPath);
            //Debug.WriteLine("Directory: " + currentDirectory);

            //MessageBox.Show("Start: " + startupPath + "\nDirectory: " + currentDirectory);


            
        }
    }
}
