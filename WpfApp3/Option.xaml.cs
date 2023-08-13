using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for Option.xaml
    /// </summary>
    public partial class Option : Page

    {

        private MainWindow mainWindow;
        public Option()
        {
            InitializeComponent();
            mainWindow = new MainWindow();

        }
        private void Btn_to_Menu(object sender, RoutedEventArgs e)
        {
            mainWindow.Show();
            Window.GetWindow(this).Hide();
        }
    }
}
