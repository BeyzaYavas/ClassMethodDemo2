using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo2
{
    class MusteriManager2
    {
        public void Add(Musteri2 musteri)
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("\n" + musteri.Name + "\t" + musteri.Surname + "\t" + musteri.ID + "\tSisteme Eklendi...\n");
        }

        public void Delete(Musteri2 musteri)
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("\n" + musteri.Name + "\t" + musteri.Surname + "\t" + musteri.ID + "\tSistemden Silindi...\n");
        }

        public void ShowList(List<Musteri2> musteriList)
        {
            Console.WriteLine("Ad\tSoyad\tID\tYaş\tTipi");
            foreach (var item in musteriList)
            {
                Console.WriteLine(item.Name + "\t" + item.Surname + "\t" + item.ID + "\t" + item.Age + "\t" + item.CustomerType);
            }
        }
    }
}
