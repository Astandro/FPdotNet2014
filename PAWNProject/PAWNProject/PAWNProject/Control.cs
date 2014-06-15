using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAWNProject
{
    //Semua logic code dan controller ada di sini
    public static class Control
    {
        public static List<SoalPsikotes> LoadSoalFromDB(DBSoalContext db)
        {
            List<SoalPsikotes> listSoal = new List<SoalPsikotes>();
            db.CreateIfNotExists();
            db.LogDebug = true;
            listSoal = db.SoalPsikotes.ToList();
            return listSoal;
        }

        public static List<SoalKepribadian> loadsoalKepribadianFromDB(DBSoalContext db)
        {
            List<SoalKepribadian> listSoal = new List<SoalKepribadian>();
            db.CreateIfNotExists();
            db.LogDebug = true;
            listSoal = db.SoalKepribadian.ToList();
            return listSoal;
        }

        public static List<SoalPsikotes> LoadSoalLogikaAngkaFromDB(DBSoalContext db)
        {
            List<SoalPsikotes> listSoal = new List<SoalPsikotes>();
            db.CreateIfNotExists();
            db.LogDebug = true;
            listSoal = (from soal in db.SoalPsikotes
                        where soal.Jenis_Soal.Equals("Angka")
                        select soal).ToList();
            return listSoal;
        }

        public static List<SoalPsikotes> LoadSoalLogikaFormilFromDB(DBSoalContext db)
        {
            List<SoalPsikotes> listSoal = new List<SoalPsikotes>();
            db.CreateIfNotExists();
            db.LogDebug = true;
            listSoal = (from soal in db.SoalPsikotes
                        where soal.Jenis_Soal.Equals("Formal")
                        select soal).ToList();
            return listSoal;
        }

        public static List<SoalPsikotes> LoadSoalPadananKataFromDB(DBSoalContext db)
        {
            List<SoalPsikotes> listSoal = new List<SoalPsikotes>();
            db.CreateIfNotExists();
            db.LogDebug = true;
            listSoal = (from soal in db.SoalPsikotes
                        where soal.Jenis_Soal.Equals("Padanan Kata")
                        select soal).ToList();
            return listSoal;
        }

        public static HasilKepribadian LoadHasilKepribadian(DBSoalContext db, int indicator)
        {
            HasilKepribadian hk = new HasilKepribadian();
            db.CreateIfNotExists();
            db.LogDebug = true;
            hk = (from p in db.HasilKepribadian
                               where p.Id.Equals(indicator)
                               select p).FirstOrDefault();
            return hk;
        }

        public static double HitungSkor(int benar, List<SoalPsikotes> listSoal)
        {
            return ((double)benar / listSoal.Count) * 100;
        }



        public static int HitungBenar(List<Jawaban> jawabanUser, List<SoalPsikotes> listSoal)
        {
            int benar = 0;
            foreach (Jawaban item in jawabanUser)
            {
                foreach (SoalPsikotes soal in listSoal)
                {
                    if (item.jawaban.ToArray().First() == soal.JawabanBenar.ToArray().First() && item.kodeSoal.Equals(soal.Kode_Soal))
                    {
                        benar++;
                    }
                }
            }
            return benar;
        }

        public static int HasilKepribadian(List<Jawaban> jawabanUser)
        {
            int[] jawaban = new int[4];
            int hasil = 0;
            foreach (var item in jawabanUser)
            {
                if (item.jawaban.Equals("A"))
                    jawaban[0]++;
                else if (item.jawaban.Equals("B"))
                    jawaban[1]++;
                else if (item.jawaban.Equals("C"))
                    jawaban[2]++;
                else if (item.jawaban.Equals("D"))
                    jawaban[3]++;
            }
            for(int i =0;i<jawaban.Count();i++)
            {
                if (jawaban[i] > hasil)
                    hasil = i;
            }
            return hasil;
        }
    }
}
