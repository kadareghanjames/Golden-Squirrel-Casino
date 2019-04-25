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

namespace GoldenSquirrelCasino
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] symbols = { "https://pbs.twimg.com/profile_images/1087746536665243649/hO-51lBr.jpg", @"https://media.glassdoor.com/sqll/192597/golden-acorn-casino-squarelogo-1462369646556.png", @"https://media1.tenor.com/images/df0c7e27c55ba3ade8f0ebe78718be76/tenor.gif?itemid=7442174", @"http://clipart-library.com/data_images/306858.png", @"http://www.clker.com/cliparts/Z/Q/1/5/y/e/green-tree-md.png", @"https://cdn.shopify.com/s/files/1/2040/0303/products/Pretty_Paint_Art_Cartoon_Leaf_Leaves_-_Fall_11_96229170_200x200.jpg?v=1508507362", @"https://i.pinimg.com/originals/d9/70/89/d970898b49b3198b6f57575227aba224.jpg" };
        public MainWindow()
        {
            InitializeComponent();





        }

        private void One_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Spin_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                Random r = new Random();
                string image = r.Next(0, 8).ToString();

            }
        }

        private void BtnPayTable_Click(object sender, RoutedEventArgs e)
        {
            Paytable pt = new Paytable();
            pt.Show(); 
        }
    }
}

