using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Character
{
    public interface IEnemySatu_Model : IBaseModel, IDamageable
    {
        void EnemyMove(Transform T);
        void SpawnBullet(GameObject bulletPrefabs);
        void Generate(List<GameObject> Enemyship);
    }
}

