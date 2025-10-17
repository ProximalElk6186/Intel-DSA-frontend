namespace Intel_DSA_frontend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Resize += Form1Resize;
            webView21.Width = this.ClientSize.Width - 20;
            webView21.Height = this.ClientSize.Height - 20;
            webView21.Top = 10;
            webView21.Left = 10;
            webView21.Source = new Uri("https://www.intel.com/content/www/us/en/support/intel-driver-support-assistant.html");
            this.Text = "Intel Driver & Support Assistant";
        }
        void Form1Resize(object sender, EventArgs e)
        {
            webView21.Top = 10;
            webView21.Left = 10;
            webView21.Width = this.ClientSize.Width - 20;
            webView21.Height = this.ClientSize.Height - 20;
        }
    }
}
