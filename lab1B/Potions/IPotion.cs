using System;
using System.Text;

namespace Lab1
{
    public interface IPotion
    {
        public string Name { get; }

        public DateTime BestBefore { get; }

        public float Price { get; }

        public string GetDescription();

        public float GetVolume();

        public string ToString();
    }
}