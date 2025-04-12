using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

namespace WPF_Review
{
    /// <summary>
    /// Interaction logic for Start.xaml
    /// </summary>
    public partial class Start : Page
    {
        MainWindow window = (MainWindow)Application.Current.MainWindow; //calls MainWindow cs properties
        public Start()
        {
            InitializeComponent();
        }

        private void SetPlayerName()
        {
            Output.Text = $"Chao! {window.player.PersonName} \n";
            Output.Text += "Enter your name in the box below.";
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (Input.Text != "")
            {
                window.player.PersonName = Input.Text;
                ShowPlayerInfo();
            }
            else
            {
                Output.Text = "No name entered, ok Anon!";
            }
        }

        private void ShowPlayerInfo()
        {
            Output.Text = $"{window.player.PersonName}";
        }

        private void StartGrid_Loaded(object sender, RoutedEventArgs e)
        {
            SetPlayerName();
        }
    }
}
