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
using System.Windows.Shapes;

namespace GoldenSquirrelCasino
{
    /// <summary>
    /// Interaction logic for Bonus.xaml
    /// </summary>
    public partial class Bonus : Window
    {
        private int rand { get; set; }
        public int win { get; set; }

       
        public Bonus()
        {
            InitializeComponent();
            rand = 0;
            win = 0;
        }


        private void WindowBonus_Loaded(object sender, RoutedEventArgs e)
        {

            
        }

        public int BonusGame()
        {
            int[] b = { 20, 5, 25, 50, 75 };
            rand = 0;
            Random r = new Random();
            rand = r.Next(0, 5);
            win = b[rand];
            return (win);
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void WindowBonus_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show($"YOU WON!!!!!!!");
            //WindowBonus.Close(); 

            
        }
    }
}
