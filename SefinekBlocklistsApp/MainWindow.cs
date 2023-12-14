using Microsoft.Web.WebView2.Core;

namespace SefinekBlocklistsApp;

public partial class MainWindow : Form
{
    private readonly string _appData = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Sefinek Blocklists");

    public MainWindow()
    {
        InitializeComponent();
        
    }
    
    private async void MainWindow_Load(object sender, EventArgs e)
    {
        webView21.CoreWebView2InitializationCompleted += WebView_CoreWebView2InitializationCompleted;

        CoreWebView2Environment webView2Environment = await CoreWebView2Environment.CreateAsync(null, _appData).ConfigureAwait(false);
        await webView21.EnsureCoreWebView2Async(webView2Environment).ConfigureAwait(false);
    }


    private void WebView_CoreWebView2InitializationCompleted(object? sender, CoreWebView2InitializationCompletedEventArgs e)
    {
        if (e.IsSuccess)
            webView21.Source = new Uri("https://sefinek.net/blocklist-generator");
        else
            MessageBox.Show(@"Failed to load WebView2.");
    }
}
