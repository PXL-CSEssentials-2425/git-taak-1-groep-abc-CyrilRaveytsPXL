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

        private void redColor_MouseDown(object sender, MouseButtonEventArgs e)
        {
            kleurcode.Text = "#FF0000";
            informatie.Text = "Rood is de kleur van warmte";
        }

        private void yellowColor_MouseDown(object sender, MouseButtonEventArgs e)
        {
            kleurcode.Text = "#FFFF00";
            informatie.Text = "Geel is de kleur van levenslust";
        }

        private void greenColor_MouseDown(object sender, MouseButtonEventArgs e)
        {
            kleurcode.Text = "#008000";
            informatie.Text = "Groen is de kleur van genezing";
        }

        private void blueColor_MouseDown(object sender, MouseButtonEventArgs e)
        {
            kleurcode.Text = "#0000FF";
            informatie.Text = "Blauw is de kleur van intelligentie";
        }
    }
}