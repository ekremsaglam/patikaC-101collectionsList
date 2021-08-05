using System;
using System.Collections.Generic;

namespace collectionsList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiList = new List<int>();

            sayiList.Add(23);
            sayiList.Add(10);
            sayiList.Add(4);
            sayiList.Add(5);
            sayiList.Add(92);
            sayiList.Add(34);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiList.Count);

            foreach(var sayi in sayiList){
                Console.WriteLine(sayi);
            }
            foreach (var renk in renkListesi){
                Console.WriteLine(renk);
            }
            sayiList.ForEach(sayi=> Console.WriteLine(sayi));

            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            sayiList.Remove(4);
            renkListesi.Remove("Yeşil");

            List<User> userList = new List<User>();

            User user1 = new User();
            User user2 = new User();

            userList.Add(user1);
            userList.Add(user2);
            

        }//main end
    }//class Program end

    class User{
        private string isim;
        private string soyism;
        private int yas;

        public string getIsım(){
            return isim;
        }
        public string getSoyisim(){
            return soyism;
        }
        public int getYas(){
            return yas;
        }
    }
}
