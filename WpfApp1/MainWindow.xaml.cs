using ClassLibrary1;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void result_Click(object sender, RoutedEventArgs e)
        {
            string boba;
            int boobs = Convert.ToInt32(textbox1.Text);
            int biba = Class1.Summa(boobs,out boba);
            textbox2.Text = boba;
            textbox3.Text = Convert.ToString(biba);
        }
    }

}
