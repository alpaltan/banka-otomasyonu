﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Otomasyonu
{
    public class Musteri
    {
       
        public int MusteriNo { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public string MusteriTipi { get; set; }
        public long Sifre { get; set; }

        public List<Hesap> Hesaplar = new List<Hesap>();
        public Musteri(string Isim, string Soyisim, string musteriTipi, long sifre)
        {
            MusteriNoAta();
            MusteriAdi = Isim;
            MusteriSoyadi = Soyisim;
            MusteriTipi = musteriTipi;
            Sifre = sifre;
        }

        public void  HesapEkle()
        {
            Hesap hesap = new Hesap();
            hesap.HesapTipi = MusteriTipi;
            Hesaplar.Add(hesap);
        }

        public void MusteriNoAta()
        {
            Random random = new Random();
            MusteriNo = random.Next(200, 1000);
        }


    }
}
