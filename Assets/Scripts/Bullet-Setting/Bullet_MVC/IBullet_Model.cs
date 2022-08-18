using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using SpaceInvader.Character;

namespace SpaceInvader.BulletSetting
{
    
    public interface IBullet_Model : IBaseModel
    {
        float speed { get; }
        int hp { get; }
        void reduceHP();
    }
}
