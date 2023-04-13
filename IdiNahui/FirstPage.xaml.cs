using HandyControl.Tools.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace IdiNahui
{
    /// <summary>
    /// Логика взаимодействия для FirstPage.xaml
    /// </summary>
    public partial class FirstPage : INotifyPropertyChanged
    {
        private DateTime currentMonth;
        public DateTime CurrentMonth
        {
            get { return currentMonth; }
            set
            {
                currentMonth = value;
                RaisePropertyChanged("CurrentMonth");
                RaisePropertyChanged("CurrentMonthName");

            }
        }
        public string CurrentMonthName
        {
            get { return currentMonth.ToString("MMMM"); }
        }

        public FirstPage()
        {
            InitializeComponent();
            UserView dyu = new UserView();
            dyu.NumDay.Text = "1";
            dyu.img.Visibility = Visibility.Hidden;
            UserView dyu2 = new UserView();
            dyu2.NumDay.Text = "2";
            dyu2.img.Visibility = Visibility.Hidden;
            UserView dyu3 = new UserView();
            dyu3.NumDay.Text = "3";
            dyu3.img.Visibility = Visibility.Hidden;
            UserView dyu4 = new UserView();
            dyu4.NumDay.Text = "4";
            dyu4.img.Visibility = Visibility.Hidden;
            UserView dyu5 = new UserView();
            dyu5.NumDay.Text = "5";
            dyu5.img.Visibility = Visibility.Hidden;
            UserView dyu6 = new UserView();
            dyu6.NumDay.Text = "6";
            dyu6.img.Visibility = Visibility.Hidden;
            UserView dyu7 = new UserView();
            dyu7.NumDay.Text = "7";
            dyu7.img.Visibility = Visibility.Hidden;
            UserView dyu8 = new UserView();
            dyu8.NumDay.Text = "8";
            dyu8.img.Visibility = Visibility.Hidden;
            UserView dyu9 = new UserView();
            dyu9.NumDay.Text = "9";
            dyu9.img.Visibility = Visibility.Hidden;
            UserView dyu10 = new UserView();
            dyu10.NumDay.Text = "10";
            dyu10.img.Visibility = Visibility.Hidden;
            UserView dyu11 = new UserView();
            dyu11.NumDay.Text = "11";
            dyu11.img.Visibility = Visibility.Hidden;
            UserView dyu12 = new UserView();
            dyu12.NumDay.Text = "12";
            dyu12.img.Visibility = Visibility.Hidden;
            UserView dyu13 = new UserView();
            dyu13.NumDay.Text = "13";
            dyu13.img.Visibility = Visibility.Hidden;
            UserView dyu14 = new UserView();
            dyu14.NumDay.Text = "14";
            dyu14.img.Visibility = Visibility.Hidden;
            UserView dyu15 = new UserView();
            dyu15.NumDay.Text = "15";
            dyu15.img.Visibility = Visibility.Hidden;
            UserView dyu16 = new UserView();
            dyu16.NumDay.Text = "16";
            dyu16.img.Visibility = Visibility.Hidden;
            UserView dyu17 = new UserView();
            dyu17.NumDay.Text = "17";
            dyu17.img.Visibility = Visibility.Hidden;
            UserView dyu18 = new UserView();
            dyu18.NumDay.Text = "18";
            dyu18.img.Visibility = Visibility.Hidden;
            UserView dyu19 = new UserView();
            dyu19.NumDay.Text = "19";
            dyu19.img.Visibility = Visibility.Hidden;
            UserView dyu20 = new UserView();
            dyu20.NumDay.Text = "20";
            dyu20.img.Visibility = Visibility.Hidden;
            UserView dyu21 = new UserView();
            dyu21.NumDay.Text = "21";
            dyu21.img.Visibility = Visibility.Hidden;
            UserView dyu22 = new UserView();
            dyu22.NumDay.Text = "22";
            dyu22.img.Visibility = Visibility.Hidden;
            UserView dyu23 = new UserView();
            dyu23.NumDay.Text = "23";
            dyu23.img.Visibility = Visibility.Hidden;
            UserView dyu24 = new UserView();
            dyu24.NumDay.Text = "24";
            dyu24.img.Visibility = Visibility.Hidden;
            UserView dyu25 = new UserView();
            dyu25.NumDay.Text = "25";
            dyu25.img.Visibility = Visibility.Hidden;
            UserView dyu26 = new UserView();
            dyu26.NumDay.Text = "26";
            dyu26.img.Visibility = Visibility.Hidden;
            UserView dyu27 = new UserView();
            dyu27.NumDay.Text = "27";
            dyu27.img.Visibility = Visibility.Hidden;
            UserView dyu28 = new UserView();
            dyu28.NumDay.Text = "28";
            dyu28.img.Visibility = Visibility.Hidden;
            UserView dyu29 = new UserView();
            dyu29.NumDay.Text = "29";
            dyu29.img.Visibility = Visibility.Hidden;
            UserView dyu30 = new UserView();
            dyu30.NumDay.Text = "30";
            dyu30.img.Visibility = Visibility.Hidden;
            UserView dyu31 = new UserView();
            dyu31.NumDay.Text = "31";
            dyu31.img.Visibility = Visibility.Hidden;

            OO.Content = dyu;
            O2.Content = dyu2;
            O3.Content = dyu3;
            O4.Content = dyu4;
            O5.Content = dyu5;
            O6.Content = dyu6;
            O7.Content = dyu7;
            O8.Content = dyu8;
            O9.Content = dyu9;
            O10.Content = dyu10;
            O11.Content = dyu11;
            O12.Content = dyu12;
            O13.Content = dyu13;
            O14.Content = dyu14;
            O15.Content = dyu15;
            O16.Content = dyu16;
            O17.Content = dyu17;
            O18.Content = dyu18;
            O19.Content = dyu19;
            O20.Content = dyu20;
            O21.Content = dyu21;
            O22.Content = dyu22;
            O23.Content = dyu23;
            O24.Content = dyu24;
            O25.Content = dyu25;
            O26.Content = dyu26;
            O27.Content = dyu27;
            O28.Content = dyu28;
            O29.Content = dyu29;
            O30.Content = dyu30;
            O31.Content = dyu31;


            CurrentMonth = DateTime.Now;
            DataContext = this;


        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }



        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (calen.Visibility == Visibility.Collapsed)
            {
                calen.Visibility = Visibility.Visible;
            }
            else
            {
                calen.Visibility = Visibility.Collapsed;
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            CurrentMonth = CurrentMonth.AddMonths(1);


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            CurrentMonth = CurrentMonth.AddMonths(-1);

        }

        private void OO_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();
            
        }
        private void O2_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();


        }
        private void O3_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();

        }
        private void O4_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();
        }
        private void O5_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();
        }
        private void O6_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();
        }
        private void O7_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();
        }
        private void O8_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();
        }
        private void O9_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();
        }
        private void O10_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();
        }
        private void O11_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();
        }
        private void O12_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();
        }
        private void O13_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();
        }
        private void O14_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();
        }
        private void O15_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();
        }
        private void O16_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();
        }
        private void O17_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();
        }
        private void O18_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();
        }
        private void O19_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();
        }
        private void O20_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();
        }
        private void O21_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();
        }
        private void O22_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();
        }
        private void O23_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();
        }
        private void O24_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();
        }
        private void O25_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();
        }
        private void O26_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();
        }
        private void O27_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();
        }
        private void O28_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();
        }
        private void O29_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();
        }
        private void O30_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();
        }
        private void O31_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ChoosePage();
        }
    }

}



