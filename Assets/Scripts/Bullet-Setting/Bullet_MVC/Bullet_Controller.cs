using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Core;
using Agate.MVC.Base;
using System;

namespace SpaceInvader.BulletSetting
{
    public class Bullet_Controller : ObjectController<Bullet_Controller, Bullet_Model, IBullet_Model, Bullet_View>
    {
        public void init(Bullet_View BW, Bullet_Model BM)
        {
            SetView(BW);
            _model = BM;
            BW.OnHitEnemy += OnHitEnemy;
            
            
        }

        private void OnHitEnemy()
        {
            _model.reduceHP();
            Debug.Log(_model.hp);
            if (_model.hp <= 0)
            {
                MonoBehaviour.Destroy(_view.gameObject);
            }
            
        }
    }

}


