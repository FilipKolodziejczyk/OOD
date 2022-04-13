using Lab1.Decorators;

namespace Lab1
{
    public static class PotionsManipulator
    {
        public static IPotion ChangePotionPrice(IPotion potion, float price)
        {
            return new NewPrice(potion, price);
            //throw new NotImplementedException();
        }

        public static IPotion ChangedPotionVolume(IPotion potion, float volume)
        {
            return new NewVolume(potion, volume);
            //throw new NotImplementedException();
        }
    
        public static IPotion MakePotionColored(IPotion potion, MyColor color)
        {
            return new ColoredPotion(potion, color);
            //throw new NotImplementedException();
        }

        public static IPotion MakePotionOld(IPotion potion, int years)
        {
            return new OldPotion(potion, years);
            //throw new NotImplementedException();
        }
    
        public static IPotion MakePotionRandom(IPotion potion)
        {
            return new RandomPotion(potion);
            //throw new NotImplementedException();
        }
        
    }
}