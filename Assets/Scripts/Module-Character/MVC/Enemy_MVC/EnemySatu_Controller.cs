using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceInvader.Messege;

namespace SpaceInvader.Character
{
    public class EnemySatu_Controller : ObjectController<EnemySatu_Controller, EnemySatu_Model, IEnemySatu_Model, EnemySatu_View>
    {
        public override void SetView(EnemySatu_View view)
        {
            // view.TakeDamage += TakeDamage;
            view.ShootBullet += ShootBullet;
            base.SetView(view);
        }
        private void TakeDamage()
        {
            // Publish<EnemyTakeDamageMessage>(new EnemyTakeDamageMessage());
        }
        private void ShootBullet()
        {
            Publish<PlayAuidoMessege>(new PlayAuidoMessege("sfx_shoot"));
        }
    }
}

