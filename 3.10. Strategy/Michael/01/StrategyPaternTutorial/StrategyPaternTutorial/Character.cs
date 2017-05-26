using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPaternTutorial
{
    /// <summary>
    /// Strategy Context
    /// </summary>
    class Character
    {
        private IWeapon _weapon;
        public void SetWeapon(IWeapon newWeapon)
        {
            _weapon = newWeapon;
        }

        public void Attack()
        {
            _weapon.Use();
        }
    }
}
