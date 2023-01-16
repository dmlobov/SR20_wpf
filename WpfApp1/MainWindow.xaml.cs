using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            textBox.Text += str;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
               string value1 = textBox.Text;               
               string value2 = (1 / Convert.ToDouble(value1)).ToString();
                textBox.Text = value2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string value3 = textBox.Text;
            string value4 = (Convert.ToDouble(value3)* Convert.ToDouble(value3)).ToString();
            textBox.Text = value4;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                string value5 = textBox.Text;
                string value6 = (Math.Sqrt(Convert.ToDouble(value5))).ToString();
                textBox.Text = value6;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            string value7 = textBox.Text;
            string value8 = (Convert.ToDouble(value7) * (-1)).ToString();
            textBox.Text = value8;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            try
            {
                string value9 = new DataTable().Compute(textBox.Text, null).ToString();
                textBox.Text = value9;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text.Substring(0, textBox.Text.Length-1);
        }
    }
}
