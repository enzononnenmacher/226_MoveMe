using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveMe
{
    public class Person : IPerson
    {
        #region private attributs
        private bool _isSleeping;

        public bool IsSleeping { get => _isSleeping; }
        #endregion

        #region public methods
        public string Drink()
        {
            return "Je bois";
        }

        public virtual string Eat()
        {
            return "Je mange";
        }

        public virtual string Sleep()
        {
            return "Je dors";
        }
        #endregion
    }
}
