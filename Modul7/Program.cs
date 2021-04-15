using System;

namespace Modul7
{


	class Program
    {
        static void Main(string[] args)
        {

			Console.WriteLine("Hello World!");
		}
    }

    abstract class Delivery
    {
        public string Address;
    }

    class HomeDelivery : Delivery
    {
        /* ... */
    }

    class PickPointDelivery : Delivery
    {
        /* ... */
    }

    class ShopDelivery : Delivery
    {
        /* ... */
    }

    class Klient
    {
        // Мин набор для клиента
        public string Name { get; set; }
    }

    class KlietFizik : Klient
    {
        // клиент физ лицо
    }

    class KlientYurick : Klient
    {
        //  клиент юр. лицо
        public string Dogovor { get; set; }
    }


    class Order<TDelivery , TStruct> where TDelivery : Delivery
    {
        public TDelivery Delivery;

        public int Number;

        public string Description;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        // ... Другие поля
    }

}
