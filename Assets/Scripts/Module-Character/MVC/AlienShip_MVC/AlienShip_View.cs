using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Character
{
    public class AlienShip_View : BaseView, IDamageable
    {
        private List<GameObject> Enemyship;
        public System.Action killed;
        public System.Action damaged;
        public void ObjectDestroy()
        {
            Destroy(this.gameObject);
        }

        public void TakeDamage()
        {

        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.layer == LayerMask.NameToLayer("PlayerBullet"))
            {
                this.killed.Invoke();
                this.gameObject.SetActive(false);
            }
            if (collision.CompareTag("Bullet"))
            {
                damaged?.Invoke();
            }
        }
    }
}




