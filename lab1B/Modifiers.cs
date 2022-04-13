using Lab1.Decorators;

namespace Lab1
{
    public static class Modifiers
    {
        public static IPotion MakeDescriptionUnreadable(IPotion potion)
        {
            return new BrokenPotion(potion);
        }

        public static IPotion TranslateDescription(IPotion potion)
        {
            return new TranslatedPotion(potion);
        }
    }
}