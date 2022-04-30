namespace Shipment
{
    public enum Origin{
        Poland = 10,
        USA = 20,
        China = 30
    }
    public abstract class Goods
    {
        public abstract string GetName();
        public abstract Origin GetOrigin();
    }

    public class PGNiGGoods : Goods
    {
        public override string GetName()
        {
            return "Coal";
        }

        public override Origin GetOrigin()
        {
            return Origin.Poland;
        }
    }

    public class FordGoods : Goods
    {
        public override string GetName()
        {
            return "Cars";
        }

        public override Origin GetOrigin()
        {
            return Origin.USA;
        }
    }

    public class XiaomiGoods : Goods
    {
        public override string GetName()
        {
            return "Electronics";
        }

        public override Origin GetOrigin()
        {
            return Origin.China;
        }
    }
}
