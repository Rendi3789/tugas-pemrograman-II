using System;

namespace tugasrendi
{
    class Program
    {
        static void Main(string[] args)
        {
            kucing kucing = new kucing();
            kucing.setnama("Kucing Orange");
            kucing.getbulu();
            kucing.berjalan();
            Console.WriteLine(kucing.berbulu());
            kucing.pemakan();

            
        }
    }
}
