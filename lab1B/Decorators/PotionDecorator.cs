using System;

namespace Lab1.Decorators
{
    public abstract class PotionDecorator : IPotion
    {
        protected IPotion _potion;

        public PotionDecorator(IPotion potion)
        {
            this._potion = potion;
        }

        public virtual string Name { get => this._potion.Name; }

        public virtual DateTime BestBefore { get => this._potion.BestBefore; }

        public virtual float Price { get => this._potion.Price; }

        public virtual string GetDescription() { return this._potion.GetDescription(); }

        public virtual float GetVolume() { return this._potion.GetVolume(); }
    }
}
