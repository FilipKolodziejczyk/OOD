using System;
using System.Text;

namespace Lab1.Decorators
{
    public class NewPrice : PotionDecorator
    {
        private readonly float _price;

        public NewPrice(IPotion potion, float price) : base(potion)
        {
            _price = price;
        }

        public override float Price { get => _price; }
    }

    public class NewVolume : PotionDecorator
    {
        private readonly float _volume;

        public NewVolume(IPotion potion, float volume) : base(potion)
        {
            _volume = volume;
        }

        public override float GetVolume() { return _volume; }

        public override float Price
        {
            get => base.Price * _volume / base.GetVolume();
        }
    }

    public class ColoredPotion : PotionDecorator
    {
        private readonly MyColor _color;

        public ColoredPotion(IPotion potion, MyColor color) : base(potion)
        {
            _color = color;
        }

        public override float Price
        {
            get => base.Price * 2;
        }

        public override string GetDescription()
        {
            string color = string.Empty;
            switch (_color)
            {
                case MyColor.Red:
                    color = "Red";
                    break;
                case MyColor.Green:
                    color = "Green";
                    break;
                case MyColor.Blue:
                    color = "Blue";
                    break;
                case MyColor.Yellow:
                    color = "Yellow";
                    break;
                case MyColor.Rainbow:
                    color = "Rainbow";
                    break;
                case MyColor.Translucent:
                    color = "Translucent";
                    break;
            }
            return base.GetDescription() + " " + color;
        }
    }

    public class OldPotion : PotionDecorator
    {
        private readonly int _years;

        public OldPotion(IPotion potion, int years) : base(potion)
        {
            _years = years;
        }

        public override DateTime BestBefore
        {
            get => base.BestBefore.AddYears(-_years);
        }

        public override float Price
        {
            get => base.Price / _years;
        }

        public override string GetDescription()
        {
            var newDescription = new StringBuilder(base.GetDescription());
            for (int i = 0; i < newDescription.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                    newDescription[i] = '_';
                else if ((i + 1) % 7 == 0)
                    newDescription[i] = '_';
            }

            return newDescription.ToString();
        }
    }

    public class RandomPotion : PotionDecorator
    {
        private Random rand;

        public RandomPotion(IPotion potion) : base(potion) 
        {
            rand = new Random(0);
        }

        public override float Price
        {
            get => (float)(base.Price * rand.NextDouble() * 3 + 0.5);
        }

        public override DateTime BestBefore
        {
            get => DateTime.MaxValue;
        }
    }

    public class BrokenPotion : PotionDecorator
    {
        public BrokenPotion(IPotion potion) : base(potion) { }

        public override string GetDescription()
        {
            var newDescription = new StringBuilder(base.GetDescription());
            for (int i = 0; i < newDescription.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                    newDescription[i] = '_';
            }

            return newDescription.ToString();
        }
    }

    public class TranslatedPotion : PotionDecorator
    {
        public TranslatedPotion(IPotion potion) : base(potion) { }

        public override string GetDescription()
        {
            return "following description is in latin\n" + base.GetDescription();
        }
    }
}
