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
    public partial class TipsMainPage : PhoneApplicationPage
    {
        List<string> listTips = new List<string>();
        int counter = 1;
        public TipsMainPage()
        {
            InitializeComponent();

            listTips.Add("Sebelum menghadapi psikotes usahakan keadaan pikiran tenang dan rileks, badan dalam keadaan sehat dan telah makan");
            listTips.Add("blablabla, ini adalah tips psikotes nomor 2. ntar tolong diedit ya, yang bener2 tips psikotes");
            listTips.Add("blablabla, ini adalah tips psikotes nomor 3. ntar tolong diedit ya, yang bener2 tips psikotes");
            listTips.Add("blablabla, ini adalah tips psikotes nomor 4. ntar tolong diedit ya, yang bener2 tips psikotes");
            listTips.Add("blablabla, ini adalah tips psikotes nomor 5. ntar tolong diedit ya, yang bener2 tips psikotes");
            btnTipsBefore.IsEnabled = false;
            
            tipsCounter.Text = ("Tips " + counter + "/5");
        }

        private void btnTipsNext_Click(object sender, RoutedEventArgs e)
        {
            if (counter == 1)
            {
                btnTipsBefore.IsEnabled = true;
                textBlockTips.Text = listTips.ElementAt(1);
                counter++;
                tipsCounter.Text = ("Tips " + counter + "/5");
            }
            else if (counter == 2)
            {
                textBlockTips.Text = listTips.ElementAt(2);
                counter++;
                tipsCounter.Text = ("Tips " + counter + "/5");
            }
            else if (counter == 3)
            {
                textBlockTips.Text = listTips.ElementAt(3);
                counter++;
                tipsCounter.Text = ("Tips " + counter + "/5");
            }
            else if (counter == 4)
            {
                textBlockTips.Text = listTips.ElementAt(4);
                btnTipsNext.IsEnabled = false;
                counter++;
                tipsCounter.Text = ("Tips " + counter + "/5");
            }
        }

        private void btnTipsBefore_Click(object sender, RoutedEventArgs e)
        {
            if (counter == 2)
            {
                btnTipsBefore.IsEnabled = false;
                textBlockTips.Text = listTips.ElementAt(0);
                counter--;
                tipsCounter.Text = ("Tips " + counter + "/5");
            }
            else if (counter == 3)
            {
                textBlockTips.Text = listTips.ElementAt(1);
                counter--;
                tipsCounter.Text = ("Tips " + counter + "/5");
            }
            else if (counter == 4)
            {
                textBlockTips.Text = listTips.ElementAt(2);
                counter--;
                tipsCounter.Text = ("Tips " + counter + "/5");
            }
            else if (counter == 5)
            {
                textBlockTips.Text = listTips.ElementAt(3);
                btnTipsNext.IsEnabled = true;
                counter--;
                tipsCounter.Text = ("Tips " + counter + "/5");
            }
        }
    }
}