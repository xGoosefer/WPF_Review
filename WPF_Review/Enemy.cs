using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WPF_Review
{
    public class Enemy
    {
        public BitmapImage EnemyIcon = new BitmapImage();
        
        int select;
        
        public BitmapImage SelectEnemy()
        {
            select = MainWindow.GetRandomIntenger(3);
            if (select == 1)
            {
                return EnemyIcon = new BitmapImage (new Uri("Cor.bmp", UriKind.Relative));
            }
            else if (select == 2) 
            {
                return EnemyIcon = new BitmapImage(new Uri("Verz.bmp", UriKind.Relative));
            }
            else 
            {
                return EnemyIcon = new BitmapImage(new Uri("Eiy.bmp", UriKind.Relative));
            }
        }

        public int EnemyStats()
        {
            int stat;
            return stat = select;
        }
    }
}
