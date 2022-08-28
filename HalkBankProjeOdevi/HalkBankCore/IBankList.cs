using System;

namespace HalkBankCore
{
    public interface IBankList
    {
        void Ekle(object eleman);

        void Sil(int index);

        void KosulluSil(Func<object, bool> kosul);

        void Temizle();

        int ElemanSayisi { get; }

        object this[int index]
        {
            get;
            set;
        }
    }
}
