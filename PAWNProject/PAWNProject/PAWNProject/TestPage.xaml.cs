using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PAWNProject
{
    public partial class TestPage : PhoneApplicationPage
    {
        public TestPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (radioTrue.IsChecked == true)
                MessageBox.Show("Anda benar");
            else if (radioFalse.IsChecked == true)
                MessageBox.Show("Anda salah");
            else
                MessageBox.Show("pilih pilhan yang anda anggap benar");
        }
    }
}