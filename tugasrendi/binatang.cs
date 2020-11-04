using System;

namespace tugasrendi
{
    class binatang{
        string nama = null;
        public string bulu = "";
        public string hewan = "Saya binatang ";

        public void setnama(string s){
            nama = s ;
            Console.WriteLine("Saya bernama " + nama);
        }

        public void getbulu(){
            bulu = nama.Substring(9);
        }

        public string berjalan(){
            return nama + " Berjalan";
        }
    }
}
