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

namespace git_oef
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void redColor_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = new SolidColorBrush(Colors.Red);
        }

        private void redColor_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void yellowColor_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = new SolidColorBrush((Color)Colors.Yellow);
        }

        private void yellowColor_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void greenColor_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = new SolidColorBrush((Color)Colors.Green);
        }

        private void greenColor_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = new SolidColorBrush ((Color)Colors.LightGray);
        }

        private void blueColor_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = new SolidColorBrush (Colors.Blue);
        }

        private void blueColor_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = new SolidColorBrush(Colors.LightGray);
        }
    }
}