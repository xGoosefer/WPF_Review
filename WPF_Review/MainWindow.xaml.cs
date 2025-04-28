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
        public List<Region> regions = new List<Region>();
        public Game game = new Game();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainGrid_Loaded(object sender, RoutedEventArgs e)
        {
            // used once for inital load
            NavFrame.Navigate(new Start());

            //+regions
            regions.Add(new Region() { regionName="City", regionDescript="Journey Begins"});
            regions.Add(new Region() { regionName = "Void", regionDescript = "????" });
            regions.Add(new Region() { regionName = "Coast Line", regionDescript = "The land by the ocean." });

            //Output.Text += "\nThis is kittyotik (me when I lie)";
            //Output.Text += player.GetInventoryItem();
        }

       

        
    }
}