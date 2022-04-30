namespace Shipment
{
    public abstract class AbstractFactory
    {
        public abstract Goods CreateGoods();
        public abstract Equipement CreateEquipement();
        public abstract ShipmentMethod CreateShipmentMethod();
    }

    class PGNiGFactory : AbstractFactory
    {
        public override Goods CreateGoods()
        {
            return new PGNiGGoods();
        }

        public override Equipement CreateEquipement()
        {
            return new PGNiGEquipment();
        }

        public override ShipmentMethod CreateShipmentMethod()
        {
            return new PGNiGShipmentMethod();
        }
    }

    class FordFactory : AbstractFactory
    {
        public override Goods CreateGoods()
        {
            return new FordGoods();
        }

        public override Equipement CreateEquipement()
        {
            return new FordEquipement();
        }

        public override ShipmentMethod CreateShipmentMethod()
        {
            return new FordShipmentMethod();
        }
    }

    class XiaomiFactory : AbstractFactory
    {
        public override Goods CreateGoods()
        {
            return new XiaomiGoods();
        }

        public override Equipement CreateEquipement()
        {
            return new XiaomiEquipement();
        }

        public override ShipmentMethod CreateShipmentMethod()
        {
            return new XiaomiShipmentMethod();
        }
    }
}