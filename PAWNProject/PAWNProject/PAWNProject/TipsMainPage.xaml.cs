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

            listTips.Add("Berdoa adalah langkah pertama yang harus kita lakukan dan juga hal terakhir ketika kita akan memulai segala aktifitas, Kerjakan hal ini dengan dimulai berdoa, ditengah-tengah berusaha, diakhiri juga dengan berdoa serta tawakkal akan hasil semuanya setelah kita lampaui proses satu demi satu. Berdoa adalah wujud nyata kelemahan kita sebagai manusia untuk mengharapkan kemudahan dari Allah Ta'ala dalam segala aktifitas kehidupan kita demi mencapai kesuksesan.");
            listTips.Add("Dalam mengerjakan soal demi soal psikotes, konsentrasi, ketelitian dan ketenangan diri adalah bagian penting dalam strategi memudahkan kita mengerjakan tes semacam ini. Karena tanpa ketiganya maka hasil yang diharapkan akan jauh dari kenyataan. Bisa saja kita pandai dan cerdas akan tetapi tanpa ketelitian serta ketenangan diri maka hal ini akan dirasakan sebagai kekurangan.");
            listTips.Add("Dalam mengerjakan segala sesuatu termasuk mengerjakan soal tes intelegensi semacam ini maka rasa kepercayaan diri yang tinggi sangat dibutuhkan. Bila ada awalnya kita sudah pesimis dan akan mengalami kesulitan dalam mengerjakan ujian tes ini maka hal ini akan membawa pengaruh buruk terhadap diri kita ketika mengerjakannya.");
            listTips.Add("Pelajari bentuk-bentuk soal psikotes dengan baik. Ini penting untuk mengakrabkan diri anda dengan soal-soal psikotes sehingga lebih memudahkan anda sendiri pada waktu mengikuti ujian psikotes yang sebenarnya.");
            listTips.Add("Ketika menghadapi tes kuantitatif (tes angka/numerik), anda harus ingat bahwa setiap soal bobot nilainya sama. Jadi, alokasikanlah energi konsentrasi dan waktu anda pada seluruh soal secara merata. Jika anda tidak mampu menemukan jawaban pada soal tertentu, jangan terpaku dan jangan penasaran pada soal tersebut. Karena hal ini dapat menguras energi, menguras konsentrasi, dan menguras waktu anda yang sangat terbatas.");
            listTips.Add("Ketika menghadapi tes persamaan kata (sinonim), jangan memilih kata yang mempunyai kata bunyi mirip dengan soal. Sebagaian besar jawaban yang demikian tidak tepat meski tidak selalu salah. Gunakan waktu yang tersedia dengan sebaik mungkin, cepat, tepat, dan teliti");
            listTips.Add("Ketika menghadapi tes kepribadian, jadilah diri anda sendiri yang terbaik. Jawablah pertanyaan yang paling sesuai dengan kondisi diri anda. Ini sangat penting. Karena dengan jawaban anda yang jujur tersebut, tim rekrutmen dapat menempatkan anda pada posisi yang paling tepat sesuai dengan karakter kepribadian diri anda. Sehingga potensi diri anda dapat dioptimalkan oleh perusahaan.");
            btnTipsBefore.IsEnabled = false;
            
            tipsCounter.Text = ("Tips " + counter + "/7");
        }

        private void btnTipsNext_Click(object sender, RoutedEventArgs e)
        {
            if (counter == 1)
            {
                btnTipsBefore.IsEnabled = true;
                textBlockTips.Text = listTips.ElementAt(1);
                counter++;
                tipsCounter.Text = ("Tips " + counter + "/7");
            }
            else if (counter == 2)
            {
                textBlockTips.Text = listTips.ElementAt(2);
                counter++;
                tipsCounter.Text = ("Tips " + counter + "/7");
            }
            else if (counter == 3)
            {
                textBlockTips.Text = listTips.ElementAt(3);
                counter++;
                tipsCounter.Text = ("Tips " + counter + "/7");
            }
            else if (counter == 4)
            {
                textBlockTips.Text = listTips.ElementAt(4);
                btnTipsNext.IsEnabled = false;
                counter++;
                tipsCounter.Text = ("Tips " + counter + "/7");
            }
            else if (counter == 5)
            {
                textBlockTips.Text = listTips.ElementAt(5);
                btnTipsNext.IsEnabled = false;
                counter++;
                tipsCounter.Text = ("Tips " + counter + "/7");
            }
            else if (counter == 6)
            {
                textBlockTips.Text = listTips.ElementAt(6);
                btnTipsNext.IsEnabled = false;
                counter++;
                tipsCounter.Text = ("Tips " + counter + "/7");
            }
        }

        private void btnTipsBefore_Click(object sender, RoutedEventArgs e)
        {
            if (counter == 2)
            {
                btnTipsBefore.IsEnabled = false;
                textBlockTips.Text = listTips.ElementAt(0);
                counter--;
                tipsCounter.Text = ("Tips " + counter + "/7");
            }
            else if (counter == 3)
            {
                textBlockTips.Text = listTips.ElementAt(1);
                counter--;
                tipsCounter.Text = ("Tips " + counter + "/7");
            }
            else if (counter == 4)
            {
                textBlockTips.Text = listTips.ElementAt(2);
                counter--;
                tipsCounter.Text = ("Tips " + counter + "/7");
            }
            else if (counter == 5)
            {
                textBlockTips.Text = listTips.ElementAt(3);
                btnTipsNext.IsEnabled = true;
                counter--;
                tipsCounter.Text = ("Tips " + counter + "/7");
            }
            else if (counter == 6)
            {
                textBlockTips.Text = listTips.ElementAt(4);
                btnTipsNext.IsEnabled = true;
                counter--;
                tipsCounter.Text = ("Tips " + counter + "/7");
            }
            else if (counter == 7)
            {
                textBlockTips.Text = listTips.ElementAt(5);
                btnTipsNext.IsEnabled = true;
                counter--;
                tipsCounter.Text = ("Tips " + counter + "/7");
            }
        }
    }
}