using System;

namespace Shipment
{
    public abstract class ShipmentMethod
    {
        public abstract string GetName();
        public abstract double EstimateShipmentTime(Goods goods);
    }

    public class PGNiGShipmentMethod : ShipmentMethod
    {
        public override string GetName()
        {
            return "Truck";
        }

        public override double EstimateShipmentTime(Goods goods)
        {
            int distance = (int)goods.GetOrigin();
            return Math.Sqrt(distance);
        }
    }

    public class FordShipmentMethod : ShipmentMethod
    {
        public override string GetName()
        {
            return "Ship";
        }

        public override double EstimateShipmentTime(Goods goods)
        {
            int distance = (int)goods.GetOrigin();
            return distance / 2;
        }
    }

    public class XiaomiShipmentMethod : ShipmentMethod
    {
        public override string GetName()
        {
            return "Plane";
        }

        public override double EstimateShipmentTime(Goods goods)
        {
            int distance = (int)goods.GetOrigin();
            return Math.Log(distance);
        }
    }
}
