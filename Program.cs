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
            Bitmap first = new Bitmap("../../testImages/test3.png");
            Bitmap second = new Bitmap("../../testImages/test2.png");
           
           Console.WriteLine(Comparer.compareTwoImages(first, second));
        }
    }
}
