﻿using Assets.Scripts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    internal class Magic_Fireball : MagicWeapon
    {
        protected UpgradableParametr _fireballCount;
        public override void Attack(IDamageable damageable)
        {
            throw new NotImplementedException();
        }
        public override UpgradableParametr Upgrade(string lvl)
        {
            throw new NotImplementedException();
        }
    }
}