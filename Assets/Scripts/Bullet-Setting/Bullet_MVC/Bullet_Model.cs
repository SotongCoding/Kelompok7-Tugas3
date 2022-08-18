using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.BulletSetting
{
    public class Bullet_Model : BaseModel, IBullet_Model
    {

        public float speed => 5f;

        public virtual int hp { private set; get; }

        public void reduceHP()
        {
            hp -= 1;
            SetDataAsDirty();
        }
    }
}


