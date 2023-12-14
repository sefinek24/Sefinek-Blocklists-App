namespace SefinekBlocklistsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Initialize();

            Application.Run(new MainWindow());
        }

        private static void Initialize()
        {
            ApplicationConfiguration.Initialize();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
        }
    }
}
