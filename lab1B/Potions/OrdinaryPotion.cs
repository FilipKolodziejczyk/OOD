using System;

namespace Lab1
{
    public class OrdinaryPotion: IPotion
    {
        private readonly string _name;

        public string Name
        {
            get => _name;
        }

        private readonly DateTime _bestBefore;
        public DateTime BestBefore
        {
            get => _bestBefore;
        }

        private readonly float _price;
        public float Price
        {
            get => _price;
        }

        public OrdinaryPotion(string Name, DateTime BestBefore, float Price)
        {
            _name = Name;
            _bestBefore = BestBefore;
            _price = Price;
        }

        public string GetDescription()
        {
            return "OrdinaryPotion";
        }
        
        public float GetVolume()
        {
            return 5.0f;
        }

        public override string ToString()
        {
            return
                $"\nPotion: {Name}\nPrice: {Price}\nVolume: {GetVolume()}\nDescription: {GetDescription()}\nBest before: {BestBefore}\n";
        }
    }
}