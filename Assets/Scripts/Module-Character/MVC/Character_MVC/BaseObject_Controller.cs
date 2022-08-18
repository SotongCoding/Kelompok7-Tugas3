using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceInvader.Messege;
using SpaceInvader.PowerUps;

namespace SpaceInvader.Character
{
    public class BaseObject_Controller : ObjectController<BaseObject_Controller, BaseObject_Model, IBaseObject_Model, BaseObject_View>
    {
        public override void SetView(BaseObject_View view)
        {
            view.TakeDamage += TakeDamage;
            view.ShootBullet += ShootBullet;
            base.SetView(view);
        }
        private void TakeDamage()
        {
            Publish<characterTakeDamageMessage>(new characterTakeDamageMessage());
            Publish<PlayAuidoMessege>(new PlayAuidoMessege("sfx_charDestroy"));
        }
        private void ShootBullet()
        {
            Publish<PlayAuidoMessege>(new PlayAuidoMessege("sfx_shoot"));
        }
        public void GetPowerUp(RecivePowerUpMessege MSG)
        {
            _view.ChangeBullet(MSG.powerUpId);
            _view.GetDuration(MSG.powerUpDuration);
        }
    }
}


