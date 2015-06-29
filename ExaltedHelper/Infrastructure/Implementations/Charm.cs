using ExaltedHelper.Infrastructure.Interfaces;
using System;

namespace ExaltedHelper.Infrastructure.Implementations
{
    public class Charm : ICharm
    {
        private string _name;
        private ICharmCost _cost;
        private string _description;
        private bool _comboOk;
        
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public ICharmCost cost
        {
            get
            {
                return _cost;
            }
            set
            {
                _cost = value;
            }
        }

        public string Description
        {
            get
            {
                return _description ;
            }
            set
            {
                _description = value;
            }
        }

        public bool ComboOk
        {
            get
            {
                return _comboOk;
            }
            set
            {
                _comboOk = value;
            }
        }


        public bool SaveCharm()
        {
            bool saved = false;

            return saved;
        }
    }
}