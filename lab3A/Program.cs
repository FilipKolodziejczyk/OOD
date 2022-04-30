using System;

namespace Shipment
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory = new PGNiGFactory();
            Console.WriteLine("PGNiG");
            TransportGoods(factory.CreateGoods(), factory.CreateShipmentMethod(), factory.CreateEquipement());

            factory = new FordFactory();
            Console.WriteLine("Ford");
            TransportGoods(factory.CreateGoods(), factory.CreateShipmentMethod(), factory.CreateEquipement());

            factory = new XiaomiFactory();
            Console.WriteLine("Xiaomi");
            TransportGoods(factory.CreateGoods(), factory.CreateShipmentMethod(), factory.CreateEquipement());

            AbstractFactory factory2 = new PGNiGFactory();
            AbstractFactory factory3 = new FordFactory();
            Console.WriteLine("Mixed");
            TransportGoods(factory.CreateGoods(), factory2.CreateShipmentMethod(), factory3.CreateEquipement());
        }

        private static void TransportGoods(Goods goods, ShipmentMethod shipmentMethod, Equipement equipement)
        {
            Console.WriteLine($"{goods.GetName()} will arrive from {goods.GetOrigin()} by {shipmentMethod.GetName()}");
            Console.WriteLine($"Estimated time: {shipmentMethod.EstimateShipmentTime(goods)}");
            Console.WriteLine($"{equipement.GetName()} {(equipement.CanUnload(goods)?"will":"CANNOT")} unload the goods\n");
        }
    }
}
