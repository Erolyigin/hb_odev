using HalkBankCore;

namespace HalkBankListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new HalkBankList();
            list.Ekle("Salih");
            list.Ekle("Engin");
            list.Ekle("Mustafa");
            list.Ekle("Ahmet");
            list.Ekle("Erol");

            list[2] = "Mehmet";

            list.Sil(3);
            list.KosulluSil(p => p.Equals("Erol"));

            Console.WriteLine("Eleman Sayısı:{0}", list.ElemanSayisi);
            foreach (var eleman in list)
            {
                Console.WriteLine(eleman);
            }

            list.Temizle();

            Console.WriteLine("Eleman Sayısı:{0}", list.ElemanSayisi);

            Console.ReadLine();
        }
    }
}