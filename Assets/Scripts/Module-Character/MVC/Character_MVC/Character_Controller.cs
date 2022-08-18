using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceInvader.Messege;
using SpaceInvader.PowerUps;
using SpaceInvader.BulletSetting;

namespace SpaceInvader.Character
{
    public class Character_Controller : ObjectController<Character_Controller, Character_Model, ICharacter_Model, Character_View>
    {
        public override void SetView(Character_View view)
        {
            view.TakeDamage += TakeDamage;
            view.ShootBullet += ShootBullet;
            view.createBullet += UpgradeBullet;
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
        public void UpgradeBullet(Bullet_View bulletPrefabs, int i)
        {
            var view = MonoBehaviour.Instantiate(bulletPrefabs, _view.transform.position, Quaternion.identity);


            Bullet_Controller control = new Bullet_Controller();
            Bullet_Model models = i == 0 ? new BulletNormal_Model() : new BulletPiercing_Model();
            InjectDependencies(control);
            control.init(view, models);
        }
    }
}


