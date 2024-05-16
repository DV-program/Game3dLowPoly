﻿using Assets.Scripts.Attack;
using Assets.Scripts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    internal class MeeleAxe : MeeleWeapon
    {
        protected UpgradableParametr _enemyMaxCount;
        [SerializeField] protected GameObject _prefab;
        [SerializeField] protected Vector3 _offset;
        AxeCreator axeCreator = new();
        public override string _animationName { get { return "AxeAttack"; } }
        public override void Attack()
        {
            Axe axe = axeCreator.CreateAttack(
                _prefab,
                gameObject.transform.localPosition + Quaternion.Euler(gameObject.transform.eulerAngles) * _offset,
                gameObject.transform.eulerAngles,
                _offset.z,
                gameObject.transform.position + new Vector3(0,_offset.y,0),
                gameObject.transform.eulerAngles.y,
                gameObject.tag
                );
            axe.StartAttack(10);
        }
        public void Awake()
        {
            _damage._current = WeaponConfig.axeLevels["damage"][0];
            _damage._currentLvl = 0;
            _damage._lvlsDictionary = WeaponConfig.axeLevels["damage"];
        }
        public override UpgradableParametr Upgrade(string param)
        {
            throw new NotImplementedException();
        }
    }
}
