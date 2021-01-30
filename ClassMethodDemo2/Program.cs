using System;
using System.Collections.Generic;

namespace ClassMethodDemo2
{
    class Program
    {
        static void Main(string[] args)
        {

                Musteri2 musteri1 = new Musteri2();
                musteri1.Name = "Emel";
                musteri1.Surname = "Demirci";
                musteri1.ID = "12345";
                musteri1.Age = 21;
                musteri1.CustomerType = "Öğrenci";

                Musteri2 musteri2 = new Musteri2();
                musteri2.Name = "Hasan";
                musteri2.Surname = "Dağlı";
                musteri2.ID = "65789";
                musteri2.Age = 69;
                musteri2.CustomerType = "Emekli";

                MusteriManager2 musteriManager = new MusteriManager2();
                musteriManager.Add(musteri1);
                musteriManager.Add(musteri2);

                List<Musteri2> musteriList = new List<Musteri2> { musteri1, musteri2 };
                musteriManager.ShowList(musteriList);

                musteriManager.Delete(musteri2);
                musteriManager.Delete(musteri1);


            

        }
    }
}
