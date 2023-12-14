using System.Runtime.InteropServices;
using SefinekBlocklistsApp.Scripts;

namespace SefinekBlocklistsApp;

internal static class Program
{
    [DllImport("user32.dll")]
    private static extern bool SetProcessDpiAwarenessContext(IntPtr dpiContext);

    /// <summary>
    ///     The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        InitializeApplication();

        try
        {
            Application.Run(new MainWindow());
        }
        catch (Exception ex)
        {
            Utils.ShowErrorMessage($"Sorry, but something went wrong.\n\n{ex.Message}");
        }
    }

    private static void InitializeApplication()
    {
        SetProcessDpiAwarenessContext(new IntPtr(-4));

        ApplicationConfiguration.Initialize();
        // Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
    }
}
