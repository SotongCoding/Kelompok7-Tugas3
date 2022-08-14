using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Character
{
    public class AlienShip : MonoBehaviour, IDamageable
    {
        private List<GameObject> Enemyship;
        public void ObjectDestroy()
        {
            Destroy(this.gameObject);
        }

        public void TakeDamage()
        {
            
        }
    }
}

