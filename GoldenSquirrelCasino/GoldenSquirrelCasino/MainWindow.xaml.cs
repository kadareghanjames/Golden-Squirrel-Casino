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
using WpfAnimatedGif;

namespace GoldenSquirrelCasino
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] symbols = { "https://pbs.twimg.com/profile_images/1087746536665243649/hO-51lBr.jpg", @"https://media.glassdoor.com/sqll/192597/golden-acorn-casino-squarelogo-1462369646556.png", @"https://media1.tenor.com/images/df0c7e27c55ba3ade8f0ebe78718be76/tenor.gif?itemid=7442174", @"http://clipart-library.com/data_images/306858.png", @"http://www.clker.com/cliparts/Z/Q/1/5/y/e/green-tree-md.png", @"https://cdn.shopify.com/s/files/1/2040/0303/products/Pretty_Paint_Art_Cartoon_Leaf_Leaves_-_Fall_11_96229170_200x200.jpg?v=1508507362", @"https://i.pinimg.com/originals/d9/70/89/d970898b49b3198b6f57575227aba224.jpg" };
        int winnings = 50;


        public MainWindow()
        {
            InitializeComponent();

            BitmapImage i1 = new BitmapImage();
            i1.BeginInit();
            i1.UriSource = new Uri(symbols[0]);
            Img1.Source = i1;
            i1.EndInit();

            BitmapImage i2 = new BitmapImage();
            i2.BeginInit();
            i2.UriSource = new Uri(symbols[0]);
            Img2.Source = i2;
            i2.EndInit();

            BitmapImage i3 = new BitmapImage();
            i3.BeginInit();
            i3.UriSource = new Uri(symbols[0]);
            Img3.Source = i3;
            i3.EndInit();

            BitmapImage i4 = new BitmapImage();
            i4.BeginInit();
            i4.UriSource = new Uri(symbols[1]);
            Img4.Source = i4;
            i4.EndInit();

            BitmapImage i5 = new BitmapImage();
            i5.BeginInit();
            i5.UriSource = new Uri(symbols[1]);
            Img5.Source = i5;
            i5.EndInit();

            BitmapImage i6 = new BitmapImage();
            i6.BeginInit();
            i6.UriSource = new Uri(symbols[1]);
            Img6.Source = i6;
            i6.EndInit();

            BitmapImage i7 = new BitmapImage();
            i7.BeginInit();
            i7.UriSource = new Uri(symbols[2]);
            Img7.Source = i7;
            i7.EndInit();
            //ImageBehavior.SetAnimatedSource(Img7, i7);


            BitmapImage i8 = new BitmapImage();
            i8.BeginInit();
            i8.UriSource = new Uri(symbols[2]);
            Img8.Source = i8;
            i8.EndInit();

            BitmapImage i9 = new BitmapImage();
            i9.BeginInit();
            i9.UriSource = new Uri(symbols[2]);
            Img9.Source = i9;
            i9.EndInit();

            txtWinnings.Text = "$" + winnings.ToString(); 
        }

        private void One_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Spin_Click(object sender, RoutedEventArgs e)
        {
            int bet; 
            bet = Convert.ToInt32(CboBet.Text.ToString().Substring(1));

            winnings = winnings - bet;
            List<int> n = new List<int>(); 
            for (int i = 1; i < 10; i++)
            {
                int image = 0; 
                Random r = new Random();
                image = r.Next(0, 8);
                n.Add(image);
                MessageBox.Show(image.ToString());
            }



            BitmapImage i1 = new BitmapImage();
            i1.BeginInit();
            i1.UriSource = new Uri(symbols[n[0]-1]);
            Img1.Source = i1;
            i1.EndInit();

            BitmapImage i2 = new BitmapImage();
            i2.BeginInit();
            i2.UriSource = new Uri(symbols[n[1]-1]);
            Img2.Source = i2;
            i2.EndInit();

            BitmapImage i3 = new BitmapImage();
            i3.BeginInit();
            i3.UriSource = new Uri(symbols[n[2]-1]);
            Img3.Source = i3;
            i3.EndInit();

            BitmapImage i4 = new BitmapImage();
            i4.BeginInit();
            i4.UriSource = new Uri(symbols[n[3]-1]);
            Img4.Source = i4;
            i4.EndInit();

            BitmapImage i5 = new BitmapImage();
            i5.BeginInit();
            i5.UriSource = new Uri(symbols[n[4]-1]);
            Img5.Source = i5;
            i5.EndInit();

            BitmapImage i6 = new BitmapImage();
            i6.BeginInit();
            i6.UriSource = new Uri(symbols[n[5]-1]);
            Img6.Source = i6;
            i6.EndInit();

            BitmapImage i7 = new BitmapImage();
            i7.BeginInit();
            i7.UriSource = new Uri(symbols[n[6]-1]);
            Img7.Source = i7;
            i7.EndInit();
            //ImageBehavior.SetAnimatedSource(Img7, i7);


            BitmapImage i8 = new BitmapImage();
            i8.BeginInit();
            i8.UriSource = new Uri(symbols[n[7]-1]);
            Img8.Source = i8;
            i8.EndInit();

            BitmapImage i9 = new BitmapImage();
            i9.BeginInit();
            i9.UriSource = new Uri(symbols[n[8]-1]);
            Img9.Source = i9;
            i9.EndInit();



            if (n[0] == n[1] && n[1] == n[2])
            {
                if(n[0] == 1)
                {
                    winnings = winnings + bet * 10; 
                }
                else if(n[0] == 2)
                {
                    winnings = winnings + bet * 2; 
                    //bonus round goes here 
                }
                else if(n[0] == 3)
                {
                    winnings = winnings + bet * 2;
                    //free spins goes here 
                }
                else if(n[0] == 4)
                {
                    winnings = winnings + bet * 2; 
                }
                else if (n[0] == 5)
                {
                    winnings = winnings + bet * 4;
                }
                else if (n[0] == 6||n[0]==8||n[0]==9||n[0]==10||n[0]==11)
                {
                    winnings = winnings + bet;
                }
                else if (n[0] == 7)
                {
                    winnings = winnings + bet * 6;
                }
            }

            if (n[3] == n[4] && n[4] == n[5])
            {
                if (n[3] == 1)
                {
                    winnings = winnings + bet * 10;
                }
                else if (n[3] == 2)
                {
                    winnings = winnings + bet * 2;
                    //bonus round goes here 
                }
                else if (n[3] == 3)
                {
                    winnings = winnings + bet * 2;
                    //free spins goes here 
                }
                else if (n[3] == 4)
                {
                    winnings = winnings + bet * 2;
                }
                else if (n[3] == 5)
                {
                    winnings = winnings + bet * 4;
                }
                else if (n[3] == 6 || n[3] == 8 || n[3] == 9 || n[3] == 10 || n[3] == 11)
                {
                    winnings = winnings + bet;
                }
                else if (n[3] == 7)
                {
                    winnings = winnings + bet * 6;
                }
            }

            if (n[6] == n[7] && n[7] == n[8])
            {
                if (n[6] == 1)
                {
                    winnings = winnings + bet * 10;
                }
                else if (n[6] == 2)
                {
                    winnings = winnings + bet * 2;
                    //bonus round goes here 
                }
                else if (n[6] == 3)
                {
                    winnings = winnings + bet * 2;
                    //free spins goes here 
                }
                else if (n[6] == 4)
                {
                    winnings = winnings + bet * 2;
                }
                else if (n[6] == 5)
                {
                    winnings = winnings + bet * 4;
                }
                else if (n[6] == 6 || n[6] == 8 || n[6] == 9 || n[6] == 10 || n[6] == 11)
                {
                    winnings = winnings + bet;
                }
                else if (n[6] == 7)
                {
                    winnings = winnings + bet * 6;
                }
            }

            if (n[0] == n[4] && n[4] == n[8])
            {
                if (n[0] == 1)
                {
                    winnings = winnings + bet * 10;
                }
                else if (n[0] == 2)
                {
                    winnings = winnings + bet * 2;
                    //bonus round goes here 
                }
                else if (n[0] == 3)
                {
                    winnings = winnings + bet * 2;
                    //free spins goes here 
                }
                else if (n[0] == 4)
                {
                    winnings = winnings + bet * 2;
                }
                else if (n[0] == 5)
                {
                    winnings = winnings + bet * 4;
                }
                else if (n[0] == 6 || n[0] == 8 || n[0] == 9 || n[0] == 10 || n[0] == 11)
                {
                    winnings = winnings + bet;
                }
                else if (n[0] == 7)
                {
                    winnings = winnings + bet * 6;
                }
            }

            if (n[6] == n[4] && n[4] == n[2])
            {
                if (n[6] == 1)
                {
                    winnings = winnings + bet * 10;
                }
                else if (n[6] == 2)
                {
                    winnings = winnings + bet * 2;
                    //bonus round goes here 
                }
                else if (n[6] == 3)
                {
                    winnings = winnings + bet * 2;
                    //free spins goes here 
                }
                else if (n[6] == 4)
                {
                    winnings = winnings + bet * 2;
                }
                else if (n[6] == 5)
                {
                    winnings = winnings + bet * 4;
                }
                else if (n[6] == 6 || n[6] == 8 || n[6] == 9 || n[6] == 10 || n[6] == 11)
                {
                    winnings = winnings + bet;
                }
                else if (n[6] == 7)
                {
                    winnings = winnings + bet * 6;
                }
            }
            txtWinnings.Text = "$" + winnings.ToString(); 

        }

        private void BtnPayTable_Click(object sender, RoutedEventArgs e)
        {
            Paytable pt = new Paytable();
            pt.Show(); 
        }

        private void CboBet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }
    }
}

