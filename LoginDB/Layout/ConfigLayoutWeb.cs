using CefSharp.WinForms;
using CefSharp;
using System;
using System.Windows.Forms;

namespace LoginDB.Layout
{
    public partial class ConfigLayoutWeb : Form
    {
        private ChromiumWebBrowser browser;
        public ConfigLayoutWeb()
        {
            InitializeComponent();
        }
        private void CarregaWeb(object sender, EventArgs e)
        {
            // Inicializa o CefSharp
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);

            // Cria e adiciona o controle no browser
            browser = new ChromiumWebBrowser("about:blank")
            {
                Dock = DockStyle.Fill,
            };
            this.Controls.Add(browser);

            // Carrega o conteúdo HTML
            string htmlContent = "<html><head><style>body { background-color: lightblue; }</style></head><body><h1>Página Web</h1></body></html>";
            browser.LoadHtml(htmlContent, "http://localhost");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Fechar o CefSharp
            Cef.Shutdown();
            base.OnFormClosing(e);
        }
    }
}