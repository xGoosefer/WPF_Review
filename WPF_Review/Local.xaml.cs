using System;
using System.Collections.Generic;
using System.Drawing;
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
        int def;
        int poisoned;
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
            //EnemyAvatar.Source = window.enemy.EnemyIcon;
        }

        private void btnOnw_Click(object sender, RoutedEventArgs e)
        {
            btnOnw.Visibility = Visibility.Collapsed;
            EnemyAvatar.Visibility = Visibility.Visible;
            EnemyHealth.Visibility = Visibility.Visible;
            EnemyHealthB.Visibility = Visibility.Visible;
            EnemyName.Visibility = Visibility.Visible;
            window.enemy.SelectEnemy();
            EnemyAvatar.Source = window.enemy.EnemyIcon;

            if (window.enemy.EnemyStats() == 1)
            {
                EnemyName.Text = "Cor";
                EnemyHealthB.Maximum = 20;
                EnemyHealthB.Value = 20;
            }
            else if (window.enemy.EnemyStats() == 2)
            {
                EnemyName.Text = "Verz";
                EnemyHealthB.Maximum = 25;
                EnemyHealthB.Value = 25;
            }
            else 
            {
                EnemyName.Text = "Eiy";
                EnemyHealthB.Maximum = 18;
                EnemyHealthB.Value = 18;
            }
            
        }

        private void btnAtk_Click(object sender, RoutedEventArgs e)
        {
            int atk;
            atk = MainWindow.GetRandomIntenger(3, 8);
            EnemyHealthB.Value -= atk;

            EnemyTurn();
        }

        private void btnDef_Click(object sender, RoutedEventArgs e)
        {
            def = MainWindow.GetRandomIntenger(2, 10);
            EnemyTurn();
        }

        private async void EnemyTurn()
        {
            int atk;
            if (window.enemy.EnemyStats() == 1)
            {
                atk = MainWindow.GetRandomIntenger(5, 18);
                atk -= def;
                if (atk < 0) atk = 0;
                plHealthB.Value -= atk;
            }
            else if (window.enemy.EnemyStats() == 2)
            {
                atk = MainWindow.GetRandomIntenger(4, 9);
                atk -= def;
                if (atk < 0) atk = 0;
                plHealthB.Value -= atk;
                if (atk >= 1 && MainWindow.GetRandomIntenger(4) == 1)
                {
                    poisoned = 3;
                    await Task.Delay(100);
                }
                
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    atk = MainWindow.GetRandomIntenger(3, 11);
                    atk -= def;
                    if (atk < 0) atk = 0;
                    plHealthB.Value -= atk;
                    await Task.Delay(100);
                }
            }

            if (poisoned > 0)
            {
                poisoned--;
                atk = MainWindow.GetRandomIntenger(1, 5);
                plHealthB.Value -= atk;
            }

            if (EnemyHealthB.Value <= 0) 
            {
                btnOnw.Visibility = Visibility.Visible;
                EnemyAvatar.Visibility = Visibility.Hidden;
                EnemyHealth.Visibility = Visibility.Hidden;
                EnemyHealthB.Visibility = Visibility.Hidden;
                EnemyName.Visibility = Visibility.Hidden;
                plHealthB.Value += MainWindow.GetRandomIntenger(10, 25);
            }

            if (plHealthB.Value <= 0)
            {
                EndScrn.Visibility = Visibility.Visible;
                btnAtk.Visibility = Visibility.Hidden;
                btnDef.Visibility = Visibility.Hidden;
            }

        }
    }
}
