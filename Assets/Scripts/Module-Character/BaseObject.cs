using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Character
{
    public abstract class BaseObject : MonoBehaviour, IMoveable, IAttackable, IDamageable
    {
        protected int speed = 10;
        protected int damage;
        protected int attackDamage;
        public abstract void Attack();

        public abstract void Move();

        public virtual void ObjectDestroy()
        {
            Destroy(this.gameObject);
        }

        public virtual void TakeDamage()
        {
            throw new System.NotImplementedException();
        }

        // Update is called once per frame
        void Update()
        {
            Move();
            TakeDamage();

        }
    }
}

