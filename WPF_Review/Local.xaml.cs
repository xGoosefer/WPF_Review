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

namespace WPF_Review
{
    /// <summary>
    /// Interaction logic for Local.xaml
    /// </summary>
    public partial class Local : Page
    {
        MainWindow window = (MainWindow)Application.Current.MainWindow; //calls MainWindow cs properties
        public Local()
        {
            InitializeComponent();
        }

        private void ShowPlayerInfo()
        {
            PlayerInfo.Text = $"{window.player.PersonName}";
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            ShowPlayerInfo();
            LocalName.Text = $"{window.regions[window.player.CurrentLocation].regionName}";
            LocalDescrip.Text = $"{window.regions[window.player.CurrentLocation].regionDescript}";
            //if img
      //      PlayerAvatar.Source = new BitmapImage(new Uri(window.player.AvatarIconLocal));
            //if stored as bitmap
            PlayerAvatar.Source = window.player.AvatarIcon;
        }

        private void btnOnw_Click(object sender, RoutedEventArgs e)
        {
            btnOnw.Visibility = Visibility.Hidden;
            EnemyAvatar.Visibility = Visibility.Visible;
            EnemyHealth.Visibility = Visibility.Visible;
            EnemyHealthB.Visibility = Visibility.Visible;
            EnemyName.Visibility = Visibility.Visible;
        }

       
    }
}
