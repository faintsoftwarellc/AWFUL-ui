using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace actual_wpf_app_how_tf_do_i_get_that_preview
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string selectedDllPath = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TitleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                if (e.ClickCount == 2)
                {
                    WindowState = (WindowState == WindowState.Normal)
                        ? WindowState.Maximized
                        : WindowState.Normal;

                    return;
                }

                try
                {
                    DragMove();
                }
                catch
                {
                    // Ignore if DragMove fails
                }
            }
        }

        private void OpenSidePanel_Click(object sender, RoutedEventArgs e)
        {
            SidePanel.Visibility = Visibility.Visible;
        }

        private void CloseSidePanel_Click(object sender, RoutedEventArgs e)
        {
            SidePanel.Visibility = Visibility.Collapsed;
        }

        private void OpenWindow1_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Owner = this;
            window1.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window1.Topmost = true;
            window1.Show();
        }

        private void OpenWindow2_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Owner = this;
            window2.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window2.Topmost = true;
            window2.Show();
        }

        private void SelectDll_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Select DLL to inject";
            openFileDialog.Filter = "DLL files (*.dll)|*.dll";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == true)
            {
                selectedDllPath = openFileDialog.FileName;
                SelectedDllTextBox.Text = selectedDllPath;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedDllPath))
            {
                MessageBox.Show("Please select a DLL first.");
                return;
            }

            MessageBox.Show("Selected DLL:\n" + selectedDllPath);

            // Put your injection code here later.
            // Use selectedDllPath as the DLL file path.
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
