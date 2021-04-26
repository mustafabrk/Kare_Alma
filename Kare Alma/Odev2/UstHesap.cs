namespace Odev2
{
    class UstHesap
    {
        private int sayi;
        private int sonuc;

        public int Hesapla(int _sayi)
        {
            sayi = _sayi;
            sonuc = sayi * sayi;
            return sonuc;
        }
    }
}
