using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Character
{
    public class AlienShip : MonoBehaviour, IDamageable
    {
        private List<GameObject> Enemyship;
        public System.Action killed;
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
        }
    }
}

