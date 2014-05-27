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
        public TipsMainPage()
        {
            InitializeComponent();

            listTips.Add("Sebelum menghadapi psikotes usahakan keadaan pikiran tenang dan rileks, badan dalam keadaan sehat dan telah makan");
            listTips.Add("blablabla, ini adalah tips psikotes nomor 3. ntar tolong diedit ya, yang bener2 tips psikotes");
            listTips.Add("blablabla, ini adalah tips psikotes nomor 4. ntar tolong diedit ya, yang bener2 tips psikotes");
            listTips.Add("blablabla, ini adalah tips psikotes nomor 5. ntar tolong diedit ya, yang bener2 tips psikotes");
            listTips.Add("blablabla, ini adalah tips psikotes nomor 5. ntar tolong diedit ya, yang bener2 tips psikotes");
            btnTipsBefore.IsEnabled = true;
        }

        private void btnTipsNext_Click(object sender, RoutedEventArgs e)
        {
            if (tipsCounter.Equals("Tips 1/5"))
            {
                btnTipsBefore.IsEnabled = true;
                textBlockTips.Text = listTips.ElementAt(1);
            }
            else if (tipsCounter.Equals("Tips 2/5"))
            {
                textBlockTips.Text = listTips.ElementAt(2);
            }
            else if (tipsCounter.Equals("Tips 3/5"))
            {
                textBlockTips.Text = listTips.ElementAt(3);
            }
            else if (tipsCounter.Equals("Tips 4/5"))
            {
                textBlockTips.Text = listTips.ElementAt(4);
                btnTipsNext.IsEnabled = false;
            }
        }

        private void btnTipsBefore_Click(object sender, RoutedEventArgs e)
        {
            if (tipsCounter.Equals("Tips 1/5"))
            {
                btnTipsBefore.IsEnabled = false;
                textBlockTips.Text = listTips.ElementAt(0);
            }
            else if (tipsCounter.Equals("Tips 2/5"))
            {
                textBlockTips.Text = listTips.ElementAt(1);
            }
            else if (tipsCounter.Equals("Tips 3/5"))
            {
                textBlockTips.Text = listTips.ElementAt(2);
            }
            else if (tipsCounter.Equals("Tips 4/5"))
            {
                textBlockTips.Text = listTips.ElementAt(3);
                btnTipsNext.IsEnabled = true;
            }
        }
    }
}