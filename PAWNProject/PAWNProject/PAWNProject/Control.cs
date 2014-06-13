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
    }
}
