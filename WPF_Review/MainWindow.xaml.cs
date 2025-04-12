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
        Person player = new Person();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainGrid_Loaded(object sender, RoutedEventArgs e)
        {
            SetPlayerName();
            
            //Output.Text += "\nThis is kittyotik (me when I lie)";
            //Output.Text += player.GetInventoryItem();
        }

        private void SetPlayerName()
        {
            Output.Text = $"Chao! {player.PersonName} \n";
            Output.Text += "Enter your name in the box below.";
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (Input.Text != "")
            {
                player.PersonName = Input.Text;
                ShowPlayerInfo();
            }
            else
            {
                Output.Text = "No name entered, ok Anon!";
            }
        }

        private void ShowPlayerInfo()
        {
            Output.Text = $"{player.PersonName}";
        }

        private void Input_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}