using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceInvader.Character;

namespace SpaceInvader.BulletSetting
{
    public class Bullet_View : ObjectView<IBullet_Model>, IMoveable
    {
        public System.Action OnHitEnemy;
        public void Move(Transform T)
        {
            transform.Translate(Vector2.up * _model.speed * Time.deltaTime);
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Enemy"))
            {
                OnHitEnemy?.Invoke();
            }
        }
        private void Start()
        {
            
        }
        protected override void InitRenderModel(IBullet_Model model)
        {
            
        }

        protected override void UpdateRenderModel(IBullet_Model model)
        {
            
        }
        private void Update()
        {
            Move(this.transform);
        }
    }
}


