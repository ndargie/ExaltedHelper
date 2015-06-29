using ExaltedHelper.Infrastructure.Interfaces;
using System;

namespace ExaltedHelper.Infrastructure.Implementations
{
    public class CharmCosts : ICharmCost
    {

        private int _willpower = 0;
        private int _essance = 0;
        private int _health = 0;

        public int Willpower
        {
            get
            {
                return _willpower;
            }
            set
            {
                _willpower = value;
            }
        }

        public int Essance
        {
            get
            {
                return _essance;
            }
            set
            {
                _essance = value;
            }
        }

        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
            }
        }
    }
}