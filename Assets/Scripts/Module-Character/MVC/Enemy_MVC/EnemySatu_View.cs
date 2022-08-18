using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceInvader.Pooling;

namespace SpaceInvader.Character
{
    public class EnemySatu_View : ObjectView<IEnemySatu_Model>, IMoveable, IAttackable
    {
        [SerializeField] GameObject bulletPrefabs;
        public System.Action TakeDamage;
        public System.Action ShootBullet;
        public bool CanMove = false;
        public void Attack()
        {
            StartCoroutine(SpawnBulletEnemy());
        }

        public void Move(Transform T)
        {
            _model.EnemyMove(T);
        }
        
        IEnumerator SpawnBulletEnemy()
        {
            while (true)
            {
                _model.SpawnBullet(bulletPrefabs);
                yield return new WaitForSeconds(2f);
            }
            
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag ("Bullet"))
            {
                TakeDamage?.Invoke();
            }    
        }

        protected override void InitRenderModel(IEnemySatu_Model model)
        {
            
        }

        protected override void UpdateRenderModel(IEnemySatu_Model model)
        {
            
        }
        private void Update()
        {
            if (CanMove == true)
            {
                Move(this.transform);
            }
            
        }
    }
}


