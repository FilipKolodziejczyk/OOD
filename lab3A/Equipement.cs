namespace Shipment
{
    public abstract class Equipement
    {
        public abstract string GetName();

        public abstract bool CanUnload(Goods goods);
    }

    public class PGNiGEquipment : Equipement
    {
        public override string GetName()
        {
            return "Excavator";
        }

        public override bool CanUnload(Goods goods)
        {
            if (goods.GetName() == "Coal")
                return true;

            return false;
        }
    }

    public class FordEquipement : Equipement
    {
        public override string GetName()
        {
            return "Crane";
        }

        public override bool CanUnload(Goods goods)
        {
            if (goods.GetName() == "Cars" || goods.GetName() == "Coal")
                return true;

            return false;
        }
    }

    public class XiaomiEquipement : Equipement
    {
        public override string GetName()
        {
            return "Forklift";
        }

        public override bool CanUnload(Goods goods)
        {
            if (goods.GetName() == "Electronics")
                return true;

            return false;
        }
    }
}
