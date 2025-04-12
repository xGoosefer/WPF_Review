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

/*
    WPF Review
Roberto A. Ramirez
4/11/25
 */

namespace WPF_Review
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Person player = new Person();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainGrid_Loaded(object sender, RoutedEventArgs e)
        {
            // used once for inital load
            NavFrame.Navigate(new Start());
            
            //Output.Text += "\nThis is kittyotik (me when I lie)";
            //Output.Text += player.GetInventoryItem();
        }

       

        
    }
}