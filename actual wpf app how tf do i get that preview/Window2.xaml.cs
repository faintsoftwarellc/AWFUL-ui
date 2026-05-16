using System.Diagnostics;
using System.Windows;

namespace actual_wpf_app_how_tf_do_i_get_that_preview
{
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void OpenLinkButton_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/faintsoftwarellc",
                UseShellExecute = true
            });
        }
    }
}
